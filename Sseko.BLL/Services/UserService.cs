using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Exceptionless;
using Microsoft.AspNetCore.Http.Internal;
using Sseko.Akka.DataService.Messages;
using Sseko.Akka.DataService.Services;
using Sseko.Akka.ReportGeneration.Services;
using Sseko.BLL.Interfaces;
using Sseko.DAL.DocumentDb.Entities;

namespace Sseko.BLL.Services
{
    public class UserService : IUserService
    {
        private ServiceFactory _serviceFactory;
        private UserDataService _ds;
        public UserService()
        {
            _serviceFactory = new ServiceFactory();
            _ds = new UserDataService();
        }

        public async Task UpdateFellows()
        {
            var fellowsToAdd = await GetNewFellows();

            foreach (var fellow in fellowsToAdd)
            {
                fellow.Role = "fellow";
                fellow.PasswordHash = CreateHash("p@s5w0rD");
                fellow.SecurityStamp = Guid.NewGuid().ToString();
                var request = await _ds.UpsertAsync(fellow);

                //if(!request.IsError)
                //TODO: Send confirmation email
            }
        }

        public async Task<bool> Exists(string username)
        {
            try
            {
                return await GetByUserNameAsync(username) != null;
            }
            catch (Exception e)
            {
                e.ToExceptionless().Submit();
                return false;
            }
        }

        public async Task<DataOperations.ResultList<User>> GetAllAsync()
        {
            return await _ds.GetAllAsync();
        }

        public async Task<DataOperations.Result<User>> GetAsync(string id)
        {
            return await _ds.GetAsync(id);
        }

        public async Task<User> GetByUserNameAsync(string username)
        {
            var result = await GetWhereAsync(u => u.UserName == username);
            if (result.IsError) throw result.Exception;
            return result.Output.FirstOrDefault();
        }

        public async Task<DataOperations.ResultList<User>> GetWhereAsync(Expression<Func<User, bool>> predicate)
        {
            return await _ds.GetAsync(predicate);
        }

        public async Task<DataOperations.Result<User>> ResetPassword(string username, string password)
        {
            var user = await GetByUserNameAsync(username);

            if (user == null) return null;

            user.PasswordHash = CreateHash(password);
            user.SecurityStamp = Guid.NewGuid().ToString();
            user.PasswordResetDetails = null;

            return await UpsertAsync(user);
        }

        public async Task<DataOperations.Result<User>> UpdatePassword(string userId, string password)
        {
            var request = await _ds.GetAsync(userId);

            if (request.IsError) return request;

            var user = request.Output;

            user.PasswordHash = CreateHash(password);

            return await UpsertAsync(user);
        }

        public async Task<DataOperations.Result<User>> UpsertAsync(User user)
        {
            return await _ds.UpsertAsync(user);
        }

        public async Task<User> ValidateUser(string username, string password)
        {
            var user = await GetByUserNameAsync(username);

            if (user == null)
                return null;
            var passwordHash = user.PasswordHash;

            var hashBytes = Convert.FromBase64String(passwordHash);

            var salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            var hash = pbkdf2.GetBytes(20);

            // TODO fix passwords
            //for (int i = 0; i < 20; i++)
            //    if (hashBytes[i + 16] != hash[i])
            //        return null;
            return user;
        }

        public async Task<string> VerifyResetLink(string resetCode)
        {
            var request = await GetWhereAsync(u => u.PasswordResetDetails != null);

            if (request.IsError) throw request.Exception;

            var user = request.Output.FirstOrDefault(u => u.PasswordResetDetails.Code == resetCode);

            return user != null && user.PasswordResetDetails.Expiration < DateTime.UtcNow ? user.UserName : string.Empty;
        }

        private static string CreateHash(string password)
        {
            var rand = RandomNumberGenerator.Create();

            var salt = new byte[16];
            rand.GetBytes(salt);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            var hash = pbkdf2.GetBytes(20);

            var hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            return Convert.ToBase64String(hashBytes);
        }

        private async Task<List<User>> GetNewFellows()
        {
            var lastUpdated = await GetLastUpdated();

            var request = await _serviceFactory.ReportService().GetNewFellows(lastUpdated);

            if (request.IsError)
            {
                throw request.Exception;
            }
            return request.Output;
        }

        private static async Task<DateTime> GetLastUpdated()
        {
            var userDs = new UserDataService();

            var request = await userDs.GetAllAsync();

            if (request.IsError)
            {
                throw request.Exception;
            }

            var users = request.Output;

            return users?.Select(u => u.Created).OrderByDescending(d => d.Date).FirstOrDefault()
                          ?? DateTime.MinValue;
        }
    }
}

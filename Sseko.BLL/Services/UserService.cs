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
using Sseko.DAL.DocumentDb.Models;

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

        public async Task<DataOperations.Result<User>> SetPasswordReset(string username)
        {
            var user = await GetByUserNameAsync(username);

            if (user == null) return null;

            //Invalidate the current password
            var rand = new Random();
            user.PasswordHash = string.Concat(rand.Next(int.MaxValue).ToString(), user.PasswordHash);

            //Change the security stamp. This will force already authenticated users to logout
            user.SecurityStamp = Guid.NewGuid().ToString();

            user.PasswordResetDetails = new PasswordResetDetails();

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

            if (user == null) return null;

            return VerifyHashedPassword(user.PasswordHash, password) ? user : null;
        }

        public async Task<string> VerifyResetLink(string resetCode)
        {
            var request = await GetWhereAsync(u => u.PasswordResetDetails != null);

            if (request.IsError) throw request.Exception;

            var user = request.Output.FirstOrDefault(u => u.PasswordResetDetails.Code == resetCode);
            
            return user != null && DateTime.UtcNow  < user.PasswordResetDetails.Expiration ? user.UserName : string.Empty;
        }

        private static string CreateHash(string password)
        {
            byte[] salt;
            byte[] buffer2;
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 0x10, 0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }
            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);
            return Convert.ToBase64String(dst);
        }

        private static bool VerifyHashedPassword(string hashedPassword, string password)
        {
            byte[] buffer4;
            if (hashedPassword == null)
            {
                return false;
            }
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            byte[] src = Convert.FromBase64String(hashedPassword);
            if ((src.Length != 0x31) || (src[0] != 0))
            {
                return false;
            }
            byte[] dst = new byte[0x10];
            Buffer.BlockCopy(src, 1, dst, 0, 0x10);
            byte[] buffer3 = new byte[0x20];
            Buffer.BlockCopy(src, 0x11, buffer3, 0, 0x20);
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, dst, 0x3e8))
            {
                buffer4 = bytes.GetBytes(0x20);
            }
            return ByteArrayCompare(buffer3, buffer4);
        }

        private static bool ByteArrayCompare(byte[] a1, byte[] a2)
        {
            if (a1.Length != a2.Length)
                return false;

            for (int i = 0; i < a1.Length; i++)
                if (a1[i] != a2[i])
                    return false;

            return true;
        }

        private async Task<List<User>> GetNewFellows()
        {
            var lastUpdated = await GetLastUpdated();

            var request = await _serviceFactory.MagentoService().GetNewFellows(lastUpdated);

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

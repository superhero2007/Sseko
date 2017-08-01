using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Identity.DocumentDb;
using Exceptionless;
using Sseko.Akka.DataService.Services;
using Sseko.Akka.ReportGeneration.Services;
using Sseko.BLL.Interfaces;
using Sseko.DAL.DocumentDb.Entities;

namespace Sseko.BLL.Services
{
    public class UserService : IUserService
    {
        private ServiceFactory _serviceFactory;
        public UserService()
        {
            _serviceFactory = new ServiceFactory();
        }

        public async Task UpdateFellows()
        {
            var userDs = new UserDataService();
            var roleDs = new RoleDataService();

            var fellowRole = (await roleDs.GetAsync(r => r.NormalizedName == "Fellow")).Output.FirstOrDefault();
            var fellowsToAdd = await GetNewFellows();

            foreach (var fellow in fellowsToAdd)
            {
                fellow.Roles.Add(fellowRole);
                fellow.PasswordHash = "AQAAAAEAACcQAAAAEIxQFu+YBiNsMZNhl49mc1YK0NulPS3yjTG3gVPsASO2ae7MulF5V7bEzUJSlndgeA==";
                fellow.SecurityStamp = "d2b5686f-8291-484a-8534-8fd21b705526";
                var request = await userDs.UpsertAsync(fellow);

                //if(!request.IsError)
                //TODO: Send confirmation email
            }
        }

        public async Task DeleteAllUsers()
        {
            var userDs = new UserDataService();

            var request = await userDs.GetAllAsync(true);

            var users = request.Output;

            foreach (var user in users)
            {
                await userDs.DeleteAsync(user);
            }
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

        private async Task<DateTime> GetLastUpdated()
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

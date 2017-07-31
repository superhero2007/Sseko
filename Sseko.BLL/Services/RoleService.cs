using System.Collections.Generic;
using System.Threading.Tasks;
using Sseko.Akka.DataService.Services;
using Sseko.BLL.Interfaces;
using Sseko.DAL.DocumentDb.Entities;

namespace Sseko.BLL.Services
{
    public class RoleService : IRoleService
    {
        public async Task<Role> UpsertAsync(Role role)
        {
            var roleDs = new RoleDataService();

            var request = await roleDs.UpsertAsync(role);

            if (request.IsError)
                throw request.Exception;
            return request.Output;
        }

        public async Task<List<Role>> GetAllAsync()
        {
            var roleDs = new RoleDataService();

            var request = await roleDs.GetAllAsync();

            if (request.IsError)
                throw request.Exception;
            return request.Output;
        }
    }
}

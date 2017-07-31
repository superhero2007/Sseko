using System.Collections.Generic;
using System.Threading.Tasks;
using Sseko.DAL.DocumentDb.Entities;

namespace Sseko.BLL.Interfaces
{
    public interface IRoleService
    {
        Task<Role> UpsertAsync(Role role);

        Task<List<Role>> GetAllAsync();
    }
}

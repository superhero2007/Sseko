using System.Threading.Tasks;
using Sseko.Akka.DataService.Messages;
using Sseko.DAL.DocumentDb.Entities;

namespace Sseko.BLL.Interfaces
{
    public interface IUserService
    {
        Task UpdateFellows();

        Task<bool> Exists(string username);

        Task<DataOperations.Result<User>> GetAsync(string i);

        Task<User> GetByUserNameAsync(string username);

        Task<DataOperations.Result<User>> ResetPassword(string username, string password);

        Task<DataOperations.Result<User>> UpdatePassword(string userId, string password);

        Task<DataOperations.Result<User>> UpsertAsync(User user);

        Task<DataOperations.ResultList<User>> GetAllAsync();

        Task<User> ValidateUser(string username, string password);

        Task<string> VerifyResetLink(string resetCode);
    }
}

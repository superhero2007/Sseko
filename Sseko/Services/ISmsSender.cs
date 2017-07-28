using System.Threading.Tasks;

namespace Sseko.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}

using System.Threading.Tasks;

namespace Sseko.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}

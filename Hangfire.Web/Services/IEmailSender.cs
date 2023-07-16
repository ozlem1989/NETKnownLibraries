using System.Threading.Tasks;

namespace Hangfire.Web.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string userId, string message);
    }
}

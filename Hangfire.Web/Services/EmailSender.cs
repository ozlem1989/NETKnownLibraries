using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace Hangfire.Web.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration _configuration;

        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string userId, string message)
        {
            var apiKey = _configuration.GetSection("APIs")["HangfireApiKey"];
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("oslem.1989@gmail.com", "Example User");
            var subject = "Hello Hangfire example!";
            var to = new EmailAddress("ozlem.engin@turkcell.com.tr", "Example User");
            var htmlContent = $"<strong>{message}</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, null, htmlContent);
            await client.SendEmailAsync(msg);
        }
    }
}

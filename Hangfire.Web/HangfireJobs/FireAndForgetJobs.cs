using Hangfire.Web.Services;

namespace Hangfire.Web.HangfireJobs
{
    public class FireAndForgetJobs
    {
        public static void SendEmailToUser(string userId, string message)
        {
            Hangfire.BackgroundJob.Enqueue<IEmailSender>(x => x.SendEmailAsync(userId, message));
        }
    }
}

using System.Diagnostics;


namespace Hangfire.Web.HangfireJobs
{
    public class RecurringJobs
    {
        public static void EmailReportJob()
        {
            Hangfire.RecurringJob.AddOrUpdate("recurringJob1", () => EmailReport(), Cron.Minutely);
        }

        public static void EmailReport()
        {
            Debug.WriteLine("Rapor mail ile gönderildi.");
        }
    }
}

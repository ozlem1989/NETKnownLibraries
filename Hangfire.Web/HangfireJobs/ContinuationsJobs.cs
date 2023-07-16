using System.Diagnostics;

namespace Hangfire.Web.HangfireJobs
{
    public class ContinuationsJobs
    {
        public static void WorkAfterWriteJob(string jobId)
        {
            Hangfire.BackgroundJob.ContinueJobWith(jobId, () => Debug.WriteLine("Working after writing..")); 
        }
    }
}

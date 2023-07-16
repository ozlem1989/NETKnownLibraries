using System;
using System.Diagnostics;

namespace Hangfire.Web.HangfireJobs
{
    public class DelayedJobs
    {
        public static void WriteJob()
        {
           var jobId =  Hangfire.BackgroundJob.Schedule(() => Write(), TimeSpan.FromSeconds(20));
            ContinuationsJobs.WorkAfterWriteJob(jobId); 
        }

        public static void Write()
        {
            Debug.WriteLine("Writing..");
        }

    }
}

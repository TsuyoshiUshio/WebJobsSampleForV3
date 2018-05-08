using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace WebJobsSDKSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new JobHostConfiguration();
            config.DashboardConnectionString = "";
            var loggerFactory = new LoggerFactory();
            config.LoggerFactory = loggerFactory.AddConsole();
            config.UseDevelopmentSettings();
            var host = new JobHost(config);
            host.RunAndBlock();

        }
    }
}

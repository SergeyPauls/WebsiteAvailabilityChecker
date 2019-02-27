using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using WebsiteAvailabilityChecker.Helper;
using WebsiteAvailabilityChecker.Infrastructure;

namespace WebsiteAvailabilityChecker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHost(args).MigrateDbContext<WebsitesDbContext>((_, __) => { });

            host.Run();
        }

        private static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .SuppressStatusMessages(true)
                .UseStartup<Startup>()
                .ConfigureLogging((hostingContext, builder) =>
                {
                    builder.AddConfiguration(hostingContext.Configuration.GetSection("LOGGING"));
                    builder.AddDebug();
                    builder.AddConsole();
                }).Build();
        }
    }
}

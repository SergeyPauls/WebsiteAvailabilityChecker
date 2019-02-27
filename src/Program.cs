using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
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

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
        }
    }
}

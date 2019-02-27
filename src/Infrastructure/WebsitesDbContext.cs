using Microsoft.EntityFrameworkCore;
using WebsiteAvailabilityChecker.Infrastructure.EntityConfiguration;
using WebsiteAvailabilityChecker.Models.Database;

namespace WebsiteAvailabilityChecker.Infrastructure
{
    public class WebsitesDbContext : DbContext
    {
        public WebsitesDbContext(DbContextOptions<WebsitesDbContext> options) : base(options)
        {
        }

        public DbSet<WebsiteEntity> WebSites { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new WebsiteEntityTypeConfiguration());
        }
    }
}

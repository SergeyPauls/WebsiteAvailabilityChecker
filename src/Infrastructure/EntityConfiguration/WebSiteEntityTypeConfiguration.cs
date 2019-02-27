using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebsiteAvailabilityChecker.Models.Database;

namespace WebsiteAvailabilityChecker.Infrastructure.EntityConfiguration
{
    public class WebsiteEntityTypeConfiguration : IEntityTypeConfiguration<WebsiteEntity>
    {
        public void Configure(EntityTypeBuilder<WebsiteEntity> builder)
        {
            builder.ToTable("WebSites");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.WebsiteName)
                .IsRequired();
        }
    }
}

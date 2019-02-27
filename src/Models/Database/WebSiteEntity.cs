using System;

namespace WebsiteAvailabilityChecker.Models.Database
{
    public class WebsiteEntity
    {
        public int Id { get; set; }

        public string WebsiteName { get; set; }

        public int CheckIntervalInSeconds { get; set; }

        public DateTime? LastCheckDate { get; set; }

        public DateTime? LastErrorDate { get; set; }

        public string LastErrorDescription { get; set; }
    }
}

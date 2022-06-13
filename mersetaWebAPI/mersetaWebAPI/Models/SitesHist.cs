using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SitesHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public string? CompanyGuid { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyRegistrationNumber { get; set; }
        public string? CompanySiteNumber { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Email { get; set; }
        public string? FaxNumber { get; set; }
        public string? LevyNumber { get; set; }
        public int? NumberOfEmployees { get; set; }
        public string? SiteNumber { get; set; }
        public int? SiteStatus { get; set; }
        public string? TelNumber { get; set; }
        public long? CompanyId { get; set; }
        public long? FormUserId { get; set; }
        public long? LegacyOrganisationSitesId { get; set; }
        public long? RegisteredAddressId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

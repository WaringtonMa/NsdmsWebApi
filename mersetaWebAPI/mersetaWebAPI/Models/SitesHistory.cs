using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SitesHistory
    {
        public long Id { get; set; }
        public string? CompanyGuid { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyRegistrationNumber { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Email { get; set; }
        public string? FaxNumber { get; set; }
        public string? LevyNumber { get; set; }
        public int? NumberOfEmployees { get; set; }
        public string? SiteNumber { get; set; }
        public int? SiteStatus { get; set; }
        public string? TelNumber { get; set; }
        public long? CompanyId { get; set; }
        public long? ForSiteId { get; set; }
        public long? FormUserId { get; set; }
        public long? RegisteredAddressId { get; set; }
        public long? ForSiteFlatId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual Site? ForSite { get; set; }
        public virtual User? FormUser { get; set; }
        public virtual Address? RegisteredAddress { get; set; }
    }
}

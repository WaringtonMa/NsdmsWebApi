using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SiteVisitReportSme
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? FullNames { get; set; }
        public string? IdentityNumber { get; set; }
        public string? Passport { get; set; }
        public string? SiteName { get; set; }
        public long? QualificationId { get; set; }
        public long? Site { get; set; }
        public long? SiteVisitReportId { get; set; }
        public long? TradeId { get; set; }
        public long? UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public virtual SaqaQualification? Qualification { get; set; }
        public virtual Site? SiteNavigation { get; set; }
        public virtual SiteVisitReportNew? SiteVisitReport { get; set; }
        public virtual OfoCode? Trade { get; set; }
        public virtual User? User { get; set; }
    }
}

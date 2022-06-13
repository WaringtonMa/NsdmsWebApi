using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SiteVisitReportDispute
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? ResonForDispute { get; set; }
        public long? CreateUserId { get; set; }
        public long? SiteVisitReportId { get; set; }

        public virtual User? CreateUser { get; set; }
        public virtual SiteVisitReportNew? SiteVisitReport { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkplaceMonitoringPurposeOfSiteVisit
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? PurposeOfSiteVisit { get; set; }
        public long? WorkplaceMonitoringId { get; set; }

        public virtual PurposeOfSiteVisit? PurposeOfSiteVisitNavigation { get; set; }
        public virtual WorkplaceMonitoring? WorkplaceMonitoring { get; set; }
    }
}

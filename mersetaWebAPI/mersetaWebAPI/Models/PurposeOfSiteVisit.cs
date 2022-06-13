using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class PurposeOfSiteVisit
    {
        public PurposeOfSiteVisit()
        {
            InversePurposeOfSiteVisitParent = new HashSet<PurposeOfSiteVisit>();
            PurposeOfSiteVisitChildren = new HashSet<PurposeOfSiteVisitChild>();
            WorkplaceMonitoringPurposeOfSiteVisits = new HashSet<WorkplaceMonitoringPurposeOfSiteVisit>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? Description { get; set; }
        public long? PurposeOfSiteVisitParentId { get; set; }

        public virtual PurposeOfSiteVisit? PurposeOfSiteVisitParent { get; set; }
        public virtual ICollection<PurposeOfSiteVisit> InversePurposeOfSiteVisitParent { get; set; }
        public virtual ICollection<PurposeOfSiteVisitChild> PurposeOfSiteVisitChildren { get; set; }
        public virtual ICollection<WorkplaceMonitoringPurposeOfSiteVisit> WorkplaceMonitoringPurposeOfSiteVisits { get; set; }
    }
}

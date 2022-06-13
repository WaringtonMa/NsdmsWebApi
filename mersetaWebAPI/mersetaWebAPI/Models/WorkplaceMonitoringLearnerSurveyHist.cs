using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkplaceMonitoringLearnerSurveyHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? CompanyLearnersId { get; set; }
        public long? CreateUserId { get; set; }
        public long? InterventionTypeId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

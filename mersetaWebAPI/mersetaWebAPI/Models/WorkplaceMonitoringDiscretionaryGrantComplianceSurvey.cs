using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkplaceMonitoringDiscretionaryGrantComplianceSurvey
    {
        public WorkplaceMonitoringDiscretionaryGrantComplianceSurvey()
        {
            WorkplaceMonitoringMitigationPlans = new HashSet<WorkplaceMonitoringMitigationPlan>();
        }

        public long Id { get; set; }
        public int? Answer { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastActionDate { get; set; }
        public int? Number { get; set; }
        public string? Question { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? AnswerLookUpId { get; set; }
        public long? LastActionUser { get; set; }

        public virtual YesNoLookup? AnswerLookUp { get; set; }
        public virtual User? LastActionUserNavigation { get; set; }
        public virtual ICollection<WorkplaceMonitoringMitigationPlan> WorkplaceMonitoringMitigationPlans { get; set; }
    }
}

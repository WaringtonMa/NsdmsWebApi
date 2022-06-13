using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkplaceMonitoringLearnerSurvey
    {
        public WorkplaceMonitoringLearnerSurvey()
        {
            WorkplaceMonitoringMitigationPlans = new HashSet<WorkplaceMonitoringMitigationPlan>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? CompanyLearnersId { get; set; }
        public long? CreateUserId { get; set; }
        public long? InterventionTypeId { get; set; }

        public virtual CompanyLearner? CompanyLearners { get; set; }
        public virtual User? CreateUser { get; set; }
        public virtual InterventionType? InterventionType { get; set; }
        public virtual ICollection<WorkplaceMonitoringMitigationPlan> WorkplaceMonitoringMitigationPlans { get; set; }
    }
}

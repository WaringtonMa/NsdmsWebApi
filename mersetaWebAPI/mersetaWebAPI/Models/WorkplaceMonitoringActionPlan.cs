using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkplaceMonitoringActionPlan
    {
        public long Id { get; set; }
        public string? Action { get; set; }
        public int? ActionPlanValidiationType { get; set; }
        public int? AtRisk { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Criteria { get; set; }
        public DateTime? LastActionDate { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? LastActionUser { get; set; }

        public virtual User? LastActionUserNavigation { get; set; }
    }
}

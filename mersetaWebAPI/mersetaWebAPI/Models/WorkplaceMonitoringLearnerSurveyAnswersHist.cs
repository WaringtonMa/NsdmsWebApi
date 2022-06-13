using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkplaceMonitoringLearnerSurveyAnswersHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public int? Answer { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastActionDate { get; set; }
        public string? Note { get; set; }
        public string? Question { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? InterventionTypeId { get; set; }
        public long? LastActionUser { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

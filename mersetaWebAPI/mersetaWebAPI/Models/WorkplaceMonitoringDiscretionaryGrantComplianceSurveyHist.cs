using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkplaceMonitoringDiscretionaryGrantComplianceSurveyHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public int? Answer { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastActionDate { get; set; }
        public int? Number { get; set; }
        public string? Question { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? AnswerLookUpId { get; set; }
        public long? LastActionUser { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

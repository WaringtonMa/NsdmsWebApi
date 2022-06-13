using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkplaceMonitoringMitigationPlanHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public string? ActionPlan { get; set; }
        public ulong? AllInfoProvided { get; set; }
        public ulong? CanAction { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? LastActionDate { get; set; }
        public int? NonComplianceIssue { get; set; }
        public int? OpenClosed { get; set; }
        public string? Responsible { get; set; }
        public ulong? SoftDeleted { get; set; }
        public int? Status { get; set; }
        public ulong? SystemGenerated { get; set; }
        public string? SystemGeneratedMessage { get; set; }
        public long? CreateUserId { get; set; }
        public long? DiscretionaryGrantComplianceLinkSurveyId { get; set; }
        public long? LastActionUser { get; set; }
        public long? LearnerSurveyAnswerLinkId { get; set; }
        public long? LearnerSurveyLinkId { get; set; }
        public long? WorkplaceMonitoringSiteVisit { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

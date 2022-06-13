using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DgVerificationHistory
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public ulong? ApplicationAppealed { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public ulong? CloAlteration { get; set; }
        public int? CloRecommendation { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CrmAppealedDateApproved { get; set; }
        public DateTime? CrmApprovalRejectionDate { get; set; }
        public int? CrmDecision { get; set; }
        public DateTime? DateAppealed { get; set; }
        public DateTime? DateCaptured { get; set; }
        public int? DiscretionalWithdrawalAppealEnum { get; set; }
        public string? EnsureExplanation { get; set; }
        public string? FinalResponse { get; set; }
        public ulong? LiaisonApplicationNotRecommended { get; set; }
        public string? LiaisonApplicationNotRecommendedDetail { get; set; }
        public ulong? LiaisonApplicationRecommended { get; set; }
        public ulong? ReadyForAllocation { get; set; }
        public ulong? RequiresSiteVisit { get; set; }
        public ulong? RmApplicationNotRecommended { get; set; }
        public ulong? RmApplicationRecommended { get; set; }
        public string? RmNonDgApplicationNotRecommendedDetail { get; set; }
        public string? RmOveridingNonDgApplicationRecommendedDetail { get; set; }
        public int? Status { get; set; }
        public ulong? WithSdf { get; set; }
        public long? AccessCover { get; set; }
        public long? AccessMaterialConsumable { get; set; }
        public long? ApprovedBySeta { get; set; }
        public long? AsPerSkillsArea { get; set; }
        public long? EffectiveRecord { get; set; }
        public long? ExtensionOfScope { get; set; }
        public long? HealthSafetyOfficer { get; set; }
        public long? NewApplication { get; set; }
        public long? PretectiveWear { get; set; }
        public long? PreviouslyApproved { get; set; }
        public long? RelevantCoreWork { get; set; }
        public long? RelevantLearnerRatio { get; set; }
        public long? SuitableQualifiedMentor { get; set; }
        public long? WorkplaceLayout { get; set; }
        public long? WspId { get; set; }
        public ulong? SystemApprovalRejection { get; set; }
        public long? CloUserId { get; set; }
        public long? CrmUserId { get; set; }
        public long? FinalResponseId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

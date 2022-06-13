using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SdpExtensionOfScopeHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public int? ApprovalStatus { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Note { get; set; }
        public int? PreviousApprovalStatus { get; set; }
        public DateTime? PreviousCodeOfConductAcceptDate { get; set; }
        public DateTime? RecommendedDate { get; set; }
        public DateTime? RecommendedToRevireCommDate { get; set; }
        public string? SiteVisitComment { get; set; }
        public DateTime? SiteVisitDate { get; set; }
        public ulong? SiteVisitDone { get; set; }
        public DateTime? SiteVisitReportDate { get; set; }
        public int? UseSkillProgrammeRoute { get; set; }
        public long? ManagerQaUserId { get; set; }
        public long? QualityAssuranceUserId { get; set; }
        public long? ReviewCommitteeMeetingId { get; set; }
        public long? ReviewCommitteeMeetingAgendaId { get; set; }
        public long? SenioManagerQaUserId { get; set; }
        public long? SkillsProgramId { get; set; }
        public long? TrainingProviderApplicationId { get; set; }
        public long? UsersId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class TrainingProviderApplicationHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public int? AccreditationApplicationType { get; set; }
        public string? AccreditationNumber { get; set; }
        public string? AccreditationPeriod { get; set; }
        public int? ApprovalStatus { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public ulong? AssessmentOnly { get; set; }
        public string? CertificateNumber { get; set; }
        public DateTime? CodeOfConductAcceptDate { get; set; }
        public ulong? CodeOfConductAccepted { get; set; }
        public DateTime? CreateDate { get; set; }
        public ulong? DuplicateApplication { get; set; }
        public DateTime? EtqaEviewCommitteeDate { get; set; }
        public DateTime? ExpiriyDate { get; set; }
        public ulong? FacilitatorAssessorModAvailable { get; set; }
        public DateTime? FinalRejectDate { get; set; }
        public ulong? FinalRejected { get; set; }
        public int? PreviousStatus { get; set; }
        public DateTime? RecommendedDate { get; set; }
        public DateTime? RecommendedToRevireCommDate { get; set; }
        public string? SiteVisitComment { get; set; }
        public DateTime? SiteVisitDate { get; set; }
        public ulong? SiteVisitDone { get; set; }
        public DateTime? SiteVisitReportDate { get; set; }
        public DateTime? StartDate { get; set; }
        public int? StatusBeforeSuspension { get; set; }
        public ulong? TrainingAssessment { get; set; }
        public int? UseSkillProgrammeRoute { get; set; }
        public long? AccreditationStatus { get; set; }
        public long? CompanyId { get; set; }
        public long? EtqaId { get; set; }
        public long? LegacyProviderAccreditationId { get; set; }
        public long? ManagerQaUserId { get; set; }
        public long? NonSetaCompanyId { get; set; }
        public long? ProviderClass { get; set; }
        public long? ProviderStatusId { get; set; }
        public long? ProviderType { get; set; }
        public long? QualityAssuranceUserId { get; set; }
        public long? RelationshipToCompanyId { get; set; }
        public long? ReviewCommitteeMeetingId { get; set; }
        public long? ReviewCommitteeMeetingAgendaId { get; set; }
        public long? ScopeOfResponsibilityId { get; set; }
        public long? SenioManagerQaUserId { get; set; }
        public long? SkillsProgramId { get; set; }
        public long? SkillsSetId { get; set; }
        public long? TrainingSiteId { get; set; }
        public long? UsersId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

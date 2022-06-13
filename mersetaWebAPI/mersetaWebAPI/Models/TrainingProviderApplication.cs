using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class TrainingProviderApplication
    {
        public TrainingProviderApplication()
        {
            CompanyLearnerTestCentreTrainingProviderApplications = new HashSet<CompanyLearner>();
            CompanyLearnerTrainingProviderApplications = new HashSet<CompanyLearner>();
            CompanyLearnerUsers = new HashSet<CompanyLearnerUser>();
            CompanyLearnersChanges = new HashSet<CompanyLearnersChange>();
            CompanyLearnersLostTimes = new HashSet<CompanyLearnersLostTime>();
            CompanyLearnersTerminations = new HashSet<CompanyLearnersTermination>();
            CompanyLearnersTradeTests = new HashSet<CompanyLearnersTradeTest>();
            CompanyLearnersTransferOrginalTrainingProviderApplications = new HashSet<CompanyLearnersTransfer>();
            CompanyLearnersTransferTransferTrainingProviderApplications = new HashSet<CompanyLearnersTransfer>();
            LegacyLearnerships = new HashSet<LegacyLearnership>();
            LegacyProviderApplicationAlterationAudits = new HashSet<LegacyProviderApplicationAlterationAudit>();
            LegacyProviderApplicationSiteAllocations = new HashSet<LegacyProviderApplicationSiteAllocation>();
            LegacySkillsProgrammes = new HashSet<LegacySkillsProgramme>();
            LegacyUnitStandards = new HashSet<LegacyUnitStandard>();
            ProviderApplicationSuspensionDeActivateds = new HashSet<ProviderApplicationSuspensionDeActivated>();
            ProviderApplicationTradeTestAssessorsLinks = new HashSet<ProviderApplicationTradeTestAssessorsLink>();
            SdpCompanyActions = new HashSet<SdpCompanyAction>();
            SdpExtensionOfScopes = new HashSet<SdpExtensionOfScope>();
            SdpReAccreditations = new HashSet<SdpReAccreditation>();
            TrainingProviderLearnerships = new HashSet<TrainingProviderLearnership>();
            TrainingProviderMonitorings = new HashSet<TrainingProviderMonitoring>();
            TrainingProviderSkillsPrograms = new HashSet<TrainingProviderSkillsProgram>();
            TrainingProviderSkillsSets = new HashSet<TrainingProviderSkillsSet>();
        }

        public long Id { get; set; }
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
        public DateTime? EtqaEviewCommitteeDate { get; set; }
        public DateTime? ExpiriyDate { get; set; }
        public ulong? FacilitatorAssessorModAvailable { get; set; }
        public DateTime? FinalRejectDate { get; set; }
        public ulong? FinalRejected { get; set; }
        public DateTime? RecommendedDate { get; set; }
        public DateTime? RecommendedToRevireCommDate { get; set; }
        public string? SiteVisitComment { get; set; }
        public DateTime? SiteVisitDate { get; set; }
        public ulong? SiteVisitDone { get; set; }
        public DateTime? SiteVisitReportDate { get; set; }
        public DateTime? StartDate { get; set; }
        public ulong? TrainingAssessment { get; set; }
        public int? UseSkillProgrammeRoute { get; set; }
        public long? AccreditationStatus { get; set; }
        public long? CompanyId { get; set; }
        public long? EtqaId { get; set; }
        public long? ManagerQaUserId { get; set; }
        public long? NonSetaCompanyId { get; set; }
        public long? ProviderClass { get; set; }
        public long? ProviderType { get; set; }
        public long? QualityAssuranceUserId { get; set; }
        public long? ReviewCommitteeMeetingId { get; set; }
        public long? ReviewCommitteeMeetingAgendaId { get; set; }
        public long? SenioManagerQaUserId { get; set; }
        public long? SkillsProgramId { get; set; }
        public long? SkillsSetId { get; set; }
        public long? UsersId { get; set; }
        public long? RelationshipToCompanyId { get; set; }
        public long? ScopeOfResponsibilityId { get; set; }
        public long? LegacyProviderAccreditationId { get; set; }
        public long? ProviderStatusId { get; set; }
        public ulong? DuplicateApplication { get; set; }
        public int? PreviousStatus { get; set; }
        public int? StatusBeforeSuspension { get; set; }
        public long? TrainingSiteId { get; set; }

        public virtual AccreditationStatus? AccreditationStatusNavigation { get; set; }
        public virtual Company? Company { get; set; }
        public virtual Etqa? Etqa { get; set; }
        public virtual LegacyProviderAccreditation? LegacyProviderAccreditation { get; set; }
        public virtual User? ManagerQaUser { get; set; }
        public virtual NonSetaCompany? NonSetaCompany { get; set; }
        public virtual ProviderClass? ProviderClassNavigation { get; set; }
        public virtual ProviderStatus? ProviderStatus { get; set; }
        public virtual ProviderType? ProviderTypeNavigation { get; set; }
        public virtual User? QualityAssuranceUser { get; set; }
        public virtual RelationshipToCompany? RelationshipToCompany { get; set; }
        public virtual ReviewCommitteeMeeting? ReviewCommitteeMeeting { get; set; }
        public virtual ReviewCommitteeMeetingAgendum? ReviewCommitteeMeetingAgenda { get; set; }
        public virtual ScopeOfResponsibility? ScopeOfResponsibility { get; set; }
        public virtual User? SenioManagerQaUser { get; set; }
        public virtual SkillsProgram? SkillsProgram { get; set; }
        public virtual SkillsSet? SkillsSet { get; set; }
        public virtual TrainingSite? TrainingSite { get; set; }
        public virtual User? Users { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearnerTestCentreTrainingProviderApplications { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearnerTrainingProviderApplications { get; set; }
        public virtual ICollection<CompanyLearnerUser> CompanyLearnerUsers { get; set; }
        public virtual ICollection<CompanyLearnersChange> CompanyLearnersChanges { get; set; }
        public virtual ICollection<CompanyLearnersLostTime> CompanyLearnersLostTimes { get; set; }
        public virtual ICollection<CompanyLearnersTermination> CompanyLearnersTerminations { get; set; }
        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTests { get; set; }
        public virtual ICollection<CompanyLearnersTransfer> CompanyLearnersTransferOrginalTrainingProviderApplications { get; set; }
        public virtual ICollection<CompanyLearnersTransfer> CompanyLearnersTransferTransferTrainingProviderApplications { get; set; }
        public virtual ICollection<LegacyLearnership> LegacyLearnerships { get; set; }
        public virtual ICollection<LegacyProviderApplicationAlterationAudit> LegacyProviderApplicationAlterationAudits { get; set; }
        public virtual ICollection<LegacyProviderApplicationSiteAllocation> LegacyProviderApplicationSiteAllocations { get; set; }
        public virtual ICollection<LegacySkillsProgramme> LegacySkillsProgrammes { get; set; }
        public virtual ICollection<LegacyUnitStandard> LegacyUnitStandards { get; set; }
        public virtual ICollection<ProviderApplicationSuspensionDeActivated> ProviderApplicationSuspensionDeActivateds { get; set; }
        public virtual ICollection<ProviderApplicationTradeTestAssessorsLink> ProviderApplicationTradeTestAssessorsLinks { get; set; }
        public virtual ICollection<SdpCompanyAction> SdpCompanyActions { get; set; }
        public virtual ICollection<SdpExtensionOfScope> SdpExtensionOfScopes { get; set; }
        public virtual ICollection<SdpReAccreditation> SdpReAccreditations { get; set; }
        public virtual ICollection<TrainingProviderLearnership> TrainingProviderLearnerships { get; set; }
        public virtual ICollection<TrainingProviderMonitoring> TrainingProviderMonitorings { get; set; }
        public virtual ICollection<TrainingProviderSkillsProgram> TrainingProviderSkillsPrograms { get; set; }
        public virtual ICollection<TrainingProviderSkillsSet> TrainingProviderSkillsSets { get; set; }
    }
}

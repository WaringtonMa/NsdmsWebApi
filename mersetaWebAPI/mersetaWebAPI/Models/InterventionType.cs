using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class InterventionType
    {
        public InterventionType()
        {
            ActiveContractDetails = new HashSet<ActiveContractDetail>();
            ActiveContracts = new HashSet<ActiveContract>();
            AllocationLists = new HashSet<AllocationList>();
            CompanyLearners = new HashSet<CompanyLearner>();
            CompanyLearnersDetailsChanges = new HashSet<CompanyLearnersDetailsChange>();
            DgAllocations = new HashSet<DgAllocation>();
            DgYearLearningPrograms = new HashSet<DgYearLearningProgram>();
            LearnershipDevelopmentRegistrations = new HashSet<LearnershipDevelopmentRegistration>();
            MandatoryGrantDetailArchives = new HashSet<MandatoryGrantDetailArchive>();
            MandatoryGrantDetails = new HashSet<MandatoryGrantDetail>();
            MandatoryGrantRecommendations = new HashSet<MandatoryGrantRecommendation>();
            MandatoryGrants = new HashSet<MandatoryGrant>();
            MgVerificationDetails = new HashSet<MgVerificationDetail>();
            ProjectImplementationPlanLearners = new HashSet<ProjectImplementationPlanLearner>();
            ProjectImplementationPlans = new HashSet<ProjectImplementationPlan>();
            SummativeAssessmentReports = new HashSet<SummativeAssessmentReport>();
            WorkplaceMonitoringLearnerSurveyAnswers = new HashSet<WorkplaceMonitoringLearnerSurveyAnswer>();
            WorkplaceMonitoringLearnerSurveys = new HashSet<WorkplaceMonitoringLearnerSurvey>();
            WspSkillsRequirements = new HashSet<WspSkillsRequirement>();
            WspStrategicPriorities = new HashSet<WspStrategicPriority>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? Description { get; set; }
        public int? PivotNonpivot { get; set; }
        public double? BasicGrantAmount { get; set; }
        public double? DisabilityGrantAmount { get; set; }
        public double? OtherGrantAmount { get; set; }
        public int? PrioritisationScale { get; set; }
        public int? Duration { get; set; }
        public int? InterventionTypeEnum { get; set; }
        public ulong? WorkplaceApprovalRequired { get; set; }
        public string? SmsCode { get; set; }
        public int? TranchIntervals { get; set; }
        public ulong? BursariesDocumentsRequired { get; set; }
        public ulong? ExtensionRequest { get; set; }
        public ulong? Busary { get; set; }
        public string? Dhet { get; set; }
        public ulong? ForTradeTest { get; set; }
        public string? Form { get; set; }
        public string? GovDescription { get; set; }
        public ulong? RequestVerificationOfAssessments { get; set; }
        public ulong? WorkplaceBasedLearning { get; set; }
        public ulong? ForSdpAccreditation { get; set; }
        public ulong? CompletionLetter { get; set; }
        public ulong? RegistrationByNonMerseta { get; set; }
        public ulong? Arpl { get; set; }
        public string? ShortDescription { get; set; }
        public string? PartOfIdString { get; set; }
        public ulong? AtrSelection { get; set; }
        public ulong? CanSelect { get; set; }
        public ulong? WspElection { get; set; }
        public int? QmrTypeSelection { get; set; }
        public int? QualificationTypeSelection { get; set; }
        public ulong? Institution { get; set; }
        public long? AetProgrammeLevelId { get; set; }
        public ulong? Onesidedtermination { get; set; }
        public int? TrancheRule { get; set; }
        public ulong? QmrTvetReport { get; set; }

        public virtual AetProgrammeLevel? AetProgrammeLevel { get; set; }
        public virtual ICollection<ActiveContractDetail> ActiveContractDetails { get; set; }
        public virtual ICollection<ActiveContract> ActiveContracts { get; set; }
        public virtual ICollection<AllocationList> AllocationLists { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearners { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChanges { get; set; }
        public virtual ICollection<DgAllocation> DgAllocations { get; set; }
        public virtual ICollection<DgYearLearningProgram> DgYearLearningPrograms { get; set; }
        public virtual ICollection<LearnershipDevelopmentRegistration> LearnershipDevelopmentRegistrations { get; set; }
        public virtual ICollection<MandatoryGrantDetailArchive> MandatoryGrantDetailArchives { get; set; }
        public virtual ICollection<MandatoryGrantDetail> MandatoryGrantDetails { get; set; }
        public virtual ICollection<MandatoryGrantRecommendation> MandatoryGrantRecommendations { get; set; }
        public virtual ICollection<MandatoryGrant> MandatoryGrants { get; set; }
        public virtual ICollection<MgVerificationDetail> MgVerificationDetails { get; set; }
        public virtual ICollection<ProjectImplementationPlanLearner> ProjectImplementationPlanLearners { get; set; }
        public virtual ICollection<ProjectImplementationPlan> ProjectImplementationPlans { get; set; }
        public virtual ICollection<SummativeAssessmentReport> SummativeAssessmentReports { get; set; }
        public virtual ICollection<WorkplaceMonitoringLearnerSurveyAnswer> WorkplaceMonitoringLearnerSurveyAnswers { get; set; }
        public virtual ICollection<WorkplaceMonitoringLearnerSurvey> WorkplaceMonitoringLearnerSurveys { get; set; }
        public virtual ICollection<WspSkillsRequirement> WspSkillsRequirements { get; set; }
        public virtual ICollection<WspStrategicPriority> WspStrategicPriorities { get; set; }
    }
}

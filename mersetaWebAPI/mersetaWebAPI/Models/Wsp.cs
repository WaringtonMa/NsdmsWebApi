using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Wsp
    {
        public Wsp()
        {
            ActiveContracts = new HashSet<ActiveContract>();
            DgAllocationParents = new HashSet<DgAllocationParent>();
            DgAllocations = new HashSet<DgAllocation>();
            DgVerifications = new HashSet<DgVerification>();
            Docs = new HashSet<Doc>();
            Employees = new HashSet<Employee>();
            EmployeesHistories = new HashSet<EmployeesHistory>();
            EmployeesImports = new HashSet<EmployeesImport>();
            ExtensionRequests = new HashSet<ExtensionRequest>();
            ImpactOfStaffTrainings = new HashSet<ImpactOfStaffTraining>();
            MandatoryGrantDetailArchives = new HashSet<MandatoryGrantDetailArchive>();
            MandatoryGrantDetails = new HashSet<MandatoryGrantDetail>();
            MandatoryGrantEvaluations = new HashSet<MandatoryGrantEvaluation>();
            MandatoryGrants = new HashSet<MandatoryGrant>();
            MgVerificationDetails = new HashSet<MgVerificationDetail>();
            MgVerifications = new HashSet<MgVerification>();
            ProjectImplementationPlanLearners = new HashSet<ProjectImplementationPlanLearner>();
            ProjectImplementationPlans = new HashSet<ProjectImplementationPlan>();
            RejectReasonsChildren = new HashSet<RejectReasonsChild>();
            Signoffs = new HashSet<Signoff>();
            WspChecklists = new HashSet<WspChecklist>();
            WspDisputes = new HashSet<WspDispute>();
            WspImpactOfStaffTrainings = new HashSet<WspImpactOfStaffTraining>();
            WspLocations = new HashSet<WspLocation>();
            WspRejectionInformations = new HashSet<WspRejectionInformation>();
            WspSignoffs = new HashSet<WspSignoff>();
            WspSkillsGaps = new HashSet<WspSkillsGap>();
            WspSkillsRequirements = new HashSet<WspSkillsRequirement>();
            WspStrategicPriorities = new HashSet<WspStrategicPriority>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? FinYear { get; set; }
        public DateTime? FromDatePeriod { get; set; }
        public DateTime? ToDatePeriod { get; set; }
        public string? WspGuid { get; set; }
        public int? WspStatusEnum { get; set; }
        public long? CompanyId { get; set; }
        public long? CreateUsersId { get; set; }
        public long? MajorityUnionId { get; set; }
        public long? RecognitionAgreementId { get; set; }
        public int? WspType { get; set; }
        public long? CoFundingPartnership { get; set; }
        public long? EmploymentEquityPlanInline { get; set; }
        public string? SkillsGapTrackSelectionDetail { get; set; }
        public long? SkillsGapTrackSelection { get; set; }
        public long? TrackSkillsGap { get; set; }
        public double? PercentagePayrollSpent { get; set; }
        public double? PercentageTrainingCostSpentTraining { get; set; }
        public double? TotalEstimatedCostTraining { get; set; }
        public double? TotalTrainingCosts { get; set; }
        public long? DeviatedWorkplaceSkillsPlan { get; set; }
        public long? TrainingReportedAtrPtrId { get; set; }
        public ulong? RequireDisputeDocs { get; set; }
        public ulong? RequireSignOffUpload { get; set; }
        public long? CompletedTraining { get; set; }
        public double? TotalPayroll { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string? FinalResponse { get; set; }
        public ulong? GrantRejected { get; set; }
        public DateTime? GrantRejectedDate { get; set; }
        public ulong? SdfAppealedGrant { get; set; }
        public DateTime? SdfAppealedGrantDate { get; set; }
        public ulong? WithSdf { get; set; }
        public ulong? SystemApprovalRejection { get; set; }
        public DateTime? DgTerminationDate { get; set; }
        public long? DgProjectTypeId { get; set; }
        public ulong? AdminReopened { get; set; }
        public ulong? ApplicationReopened { get; set; }
        public DateTime? ApllicationReopenedDate { get; set; }
        public int? ReopenedToLocation { get; set; }
        public long? UserReopenedApplication { get; set; }
        public DateTime? DateMancoApprovalRequired { get; set; }
        public ulong? MancoApprovalRequired { get; set; }
        public ulong? MancoDecisionReached { get; set; }
        public long? UserRequestedMancoApproval { get; set; }
        public string? AlignmentToMersetaStrategicPriorities { get; set; }
        public string? Benefits { get; set; }
        public double? EstimatedOverallProjectCost { get; set; }
        public string? Interventions { get; set; }
        public string? Location { get; set; }
        public string? Outcomes { get; set; }
        public string? PotentialRisks { get; set; }
        public string? ProjectDescription { get; set; }
        public string? Purpose { get; set; }
        public ulong? RejectionNotified { get; set; }
        public long? DgYearId { get; set; }
        public int? HoldingRoomStatusEnum { get; set; }
        public long? ProjectOwner { get; set; }
        public long? ProjectManager { get; set; }
        public long? CompanyContact { get; set; }
        public double? ApprovedAmount { get; set; }
        public ulong? ManuallyAdded { get; set; }
        public DateTime? ManuallySubmissionDate { get; set; }

        public virtual YesNoLookup? CoFundingPartnershipNavigation { get; set; }
        public virtual Company? Company { get; set; }
        public virtual CompanyUser? CompanyContactNavigation { get; set; }
        public virtual YesNoLookup? CompletedTrainingNavigation { get; set; }
        public virtual User? CreateUsers { get; set; }
        public virtual YesNoLookup? DeviatedWorkplaceSkillsPlanNavigation { get; set; }
        public virtual DgProjectType? DgProjectType { get; set; }
        public virtual DgYear? DgYear { get; set; }
        public virtual YesNoLookup? EmploymentEquityPlanInlineNavigation { get; set; }
        public virtual YesNoLookup? MajorityUnion { get; set; }
        public virtual User? ProjectManagerNavigation { get; set; }
        public virtual User? ProjectOwnerNavigation { get; set; }
        public virtual YesNoLookup? RecognitionAgreement { get; set; }
        public virtual SkillsGapTrackLookUp? SkillsGapTrackSelectionNavigation { get; set; }
        public virtual YesNoLookup? TrackSkillsGapNavigation { get; set; }
        public virtual TrainingReportedAtrPtr? TrainingReportedAtrPtr { get; set; }
        public virtual User? UserReopenedApplicationNavigation { get; set; }
        public virtual User? UserRequestedMancoApprovalNavigation { get; set; }
        public virtual ICollection<ActiveContract> ActiveContracts { get; set; }
        public virtual ICollection<DgAllocationParent> DgAllocationParents { get; set; }
        public virtual ICollection<DgAllocation> DgAllocations { get; set; }
        public virtual ICollection<DgVerification> DgVerifications { get; set; }
        public virtual ICollection<Doc> Docs { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<EmployeesHistory> EmployeesHistories { get; set; }
        public virtual ICollection<EmployeesImport> EmployeesImports { get; set; }
        public virtual ICollection<ExtensionRequest> ExtensionRequests { get; set; }
        public virtual ICollection<ImpactOfStaffTraining> ImpactOfStaffTrainings { get; set; }
        public virtual ICollection<MandatoryGrantDetailArchive> MandatoryGrantDetailArchives { get; set; }
        public virtual ICollection<MandatoryGrantDetail> MandatoryGrantDetails { get; set; }
        public virtual ICollection<MandatoryGrantEvaluation> MandatoryGrantEvaluations { get; set; }
        public virtual ICollection<MandatoryGrant> MandatoryGrants { get; set; }
        public virtual ICollection<MgVerificationDetail> MgVerificationDetails { get; set; }
        public virtual ICollection<MgVerification> MgVerifications { get; set; }
        public virtual ICollection<ProjectImplementationPlanLearner> ProjectImplementationPlanLearners { get; set; }
        public virtual ICollection<ProjectImplementationPlan> ProjectImplementationPlans { get; set; }
        public virtual ICollection<RejectReasonsChild> RejectReasonsChildren { get; set; }
        public virtual ICollection<Signoff> Signoffs { get; set; }
        public virtual ICollection<WspChecklist> WspChecklists { get; set; }
        public virtual ICollection<WspDispute> WspDisputes { get; set; }
        public virtual ICollection<WspImpactOfStaffTraining> WspImpactOfStaffTrainings { get; set; }
        public virtual ICollection<WspLocation> WspLocations { get; set; }
        public virtual ICollection<WspRejectionInformation> WspRejectionInformations { get; set; }
        public virtual ICollection<WspSignoff> WspSignoffs { get; set; }
        public virtual ICollection<WspSkillsGap> WspSkillsGaps { get; set; }
        public virtual ICollection<WspSkillsRequirement> WspSkillsRequirements { get; set; }
        public virtual ICollection<WspStrategicPriority> WspStrategicPriorities { get; set; }
    }
}

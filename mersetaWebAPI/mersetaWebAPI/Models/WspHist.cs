using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WspHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? FinYear { get; set; }
        public DateTime? FromDatePeriod { get; set; }
        public double? PercentagePayrollSpent { get; set; }
        public double? PercentageTrainingCostSpentTraining { get; set; }
        public ulong? RequireDisputeDocs { get; set; }
        public ulong? RequireSignOffUpload { get; set; }
        public string? SkillsGapTrackSelectionDetail { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public DateTime? ToDatePeriod { get; set; }
        public double? TotalEstimatedCostTraining { get; set; }
        public double? TotalPayroll { get; set; }
        public double? TotalTrainingCosts { get; set; }
        public string? WspGuid { get; set; }
        public int? WspStatusEnum { get; set; }
        public int? WspType { get; set; }
        public long? CoFundingPartnership { get; set; }
        public long? CompanyId { get; set; }
        public long? CompletedTraining { get; set; }
        public long? CreateUsersId { get; set; }
        public long? DeviatedWorkplaceSkillsPlan { get; set; }
        public long? EmploymentEquityPlanInline { get; set; }
        public long? MajorityUnionId { get; set; }
        public long? RecognitionAgreementId { get; set; }
        public long? SkillsGapTrackSelection { get; set; }
        public long? TrackSkillsGap { get; set; }
        public long? TrainingReportedAtrPtrId { get; set; }
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

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

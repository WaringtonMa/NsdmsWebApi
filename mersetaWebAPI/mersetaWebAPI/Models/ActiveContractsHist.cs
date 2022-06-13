using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ActiveContractsHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public double? AccrualRaised { get; set; }
        public DateTime? AmendmentDate { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public ulong? AwaitingBatchSignOff { get; set; }
        public DateTime? CloSignDate { get; set; }
        public string? ContractStatusEnum { get; set; }
        public double? ContractValue { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CrmSignDate { get; set; }
        public DateTime? DeadlineDate { get; set; }
        public ulong? EletronicSignoff { get; set; }
        public ulong? EtensionTerminationWorkflowActive { get; set; }
        public string? MoaType { get; set; }
        public int? NoOfLearners { get; set; }
        public DateTime? OriginalEndDate { get; set; }
        public DateTime? ProjectedRegistrationDateEnd { get; set; }
        public DateTime? ProjectedRegistrationDateStart { get; set; }
        public string? ProjectName { get; set; }
        public double? RecoverableAmount { get; set; }
        public string? RefNo { get; set; }
        public DateTime? RejectionDate { get; set; }
        public string? Reminder { get; set; }
        public DateTime? ReviseDate { get; set; }
        public DateTime? SdfSignDate { get; set; }
        public ulong? SignOffState { get; set; }
        public DateTime? SignDate { get; set; }
        public DateTime? StartDate { get; set; }
        public int? Status { get; set; }
        public ulong? Submitted { get; set; }
        public int? TranchIntervals { get; set; }
        public int? WithdrawalAppealEnum { get; set; }
        public DateTime? WithdrawnDate { get; set; }
        public long? CloId { get; set; }
        public long? CompanyId { get; set; }
        public long? CrmId { get; set; }
        public long? DepartmentId { get; set; }
        public long? DgAllocationParentId { get; set; }
        public long? InterventionId { get; set; }
        public long? RejectionUser { get; set; }
        public long? SdfId { get; set; }
        public long? UserResponsibleMoaSignOffId { get; set; }
        public long? ValidityId { get; set; }
        public long? WithdrawnUserId { get; set; }
        public long? WspId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ActiveContract
    {
        public ActiveContract()
        {
            ActiveContractDetails = new HashSet<ActiveContractDetail>();
            ActiveContractExtensionRequests = new HashSet<ActiveContractExtensionRequest>();
            ActiveContractTerminationRequests = new HashSet<ActiveContractTerminationRequest>();
            Addenda = new HashSet<Addendum>();
            DgContractingBulkItems = new HashSet<DgContractingBulkItem>();
            PaymentRequests = new HashSet<PaymentRequest>();
            ProjectImplementationPlanLearners = new HashSet<ProjectImplementationPlanLearner>();
            ProjectImplementationPlans = new HashSet<ProjectImplementationPlan>();
            WorkplaceMonitoringDgMonitorings = new HashSet<WorkplaceMonitoringDgMonitoring>();
            WorkplaceMonitoringLearnerPayments = new HashSet<WorkplaceMonitoringLearnerPayment>();
            WorkplaceMonitorings = new HashSet<WorkplaceMonitoring>();
        }

        public long Id { get; set; }
        public double? AccrualRaised { get; set; }
        public DateTime? AmendmentDate { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? CloSignDate { get; set; }
        public string? ContractStatusEnum { get; set; }
        public double? ContractValue { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CrmSignDate { get; set; }
        public string? MoaType { get; set; }
        public int? NoOfLearners { get; set; }
        public DateTime? OriginalEndDate { get; set; }
        public string? ProjectName { get; set; }
        public string? RefNo { get; set; }
        public string? Reminder { get; set; }
        public DateTime? ReviseDate { get; set; }
        public DateTime? SdfSignDate { get; set; }
        public DateTime? SignDate { get; set; }
        public DateTime? StartDate { get; set; }
        public int? Status { get; set; }
        public int? TranchIntervals { get; set; }
        public long? CloId { get; set; }
        public long? CompanyId { get; set; }
        public long? CrmId { get; set; }
        public long? DepartmentId { get; set; }
        public long? DgAllocationParentId { get; set; }
        public long? InterventionId { get; set; }
        public long? SdfId { get; set; }
        public long? ValidityId { get; set; }
        public double? RecoverableAmount { get; set; }
        public ulong? AwaitingBatchSignOff { get; set; }
        public ulong? SignOffState { get; set; }
        public long? UserResponsibleMoaSignOffId { get; set; }
        public ulong? EletronicSignoff { get; set; }
        public int? WithdrawalAppealEnum { get; set; }
        public DateTime? WithdrawnDate { get; set; }
        public long? WithdrawnUserId { get; set; }
        public DateTime? ProjectedRegistrationDateEnd { get; set; }
        public DateTime? ProjectedRegistrationDateStart { get; set; }
        public DateTime? RejectionDate { get; set; }
        public long? RejectionUser { get; set; }
        public DateTime? DeadlineDate { get; set; }
        public ulong? EtensionTerminationWorkflowActive { get; set; }
        public ulong? Submitted { get; set; }
        public long? WspId { get; set; }

        public virtual User? Clo { get; set; }
        public virtual Company? Company { get; set; }
        public virtual User? Crm { get; set; }
        public virtual Department? Department { get; set; }
        public virtual DgAllocationParent? DgAllocationParent { get; set; }
        public virtual InterventionType? Intervention { get; set; }
        public virtual User? RejectionUserNavigation { get; set; }
        public virtual User? Sdf { get; set; }
        public virtual User? UserResponsibleMoaSignOff { get; set; }
        public virtual Validity? Validity { get; set; }
        public virtual User? WithdrawnUser { get; set; }
        public virtual Wsp? Wsp { get; set; }
        public virtual ICollection<ActiveContractDetail> ActiveContractDetails { get; set; }
        public virtual ICollection<ActiveContractExtensionRequest> ActiveContractExtensionRequests { get; set; }
        public virtual ICollection<ActiveContractTerminationRequest> ActiveContractTerminationRequests { get; set; }
        public virtual ICollection<Addendum> Addenda { get; set; }
        public virtual ICollection<DgContractingBulkItem> DgContractingBulkItems { get; set; }
        public virtual ICollection<PaymentRequest> PaymentRequests { get; set; }
        public virtual ICollection<ProjectImplementationPlanLearner> ProjectImplementationPlanLearners { get; set; }
        public virtual ICollection<ProjectImplementationPlan> ProjectImplementationPlans { get; set; }
        public virtual ICollection<WorkplaceMonitoringDgMonitoring> WorkplaceMonitoringDgMonitorings { get; set; }
        public virtual ICollection<WorkplaceMonitoringLearnerPayment> WorkplaceMonitoringLearnerPayments { get; set; }
        public virtual ICollection<WorkplaceMonitoring> WorkplaceMonitorings { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ProjectImplementationPlan
    {
        public ProjectImplementationPlan()
        {
            ActiveContractDetails = new HashSet<ActiveContractDetail>();
            CompanyLearners = new HashSet<CompanyLearner>();
            CompanyLearnersDetailsChanges = new HashSet<CompanyLearnersDetailsChange>();
            PaymentRequests = new HashSet<PaymentRequest>();
            ProjectImplementationPlanLearners = new HashSet<ProjectImplementationPlanLearner>();
        }

        public long Id { get; set; }
        public int? AccreditedProviderIdentified { get; set; }
        public int? CoFundingLearnersAwarded { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EstimatedCompletionDate { get; set; }
        public DateTime? EstimatedProgressDate { get; set; }
        public int? FullyFundedLearnerAwarded { get; set; }
        public string? InterventionTypeDescription { get; set; }
        public decimal? LearnersWithDisability { get; set; }
        public double? LearnersWithDisabilityAllowanceValue { get; set; }
        public decimal? LearnersWithoutDisability { get; set; }
        public double? LearnersWithoutDisabilityAllowanceValue { get; set; }
        public int? LogisticalAspectsAddressed { get; set; }
        public decimal? NumberOfLearningInterventions { get; set; }
        public DateTime? ProjectedInductionDate { get; set; }
        public DateTime? ProjectedRecruitmentDate { get; set; }
        public DateTime? ProjectedRegistrationDate { get; set; }
        public decimal? TotalAwardAmount { get; set; }
        public double? TotalFundingValue { get; set; }
        public long? CompanyId { get; set; }
        public long? WspId { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public double? RecoverableAmount { get; set; }
        public int? Status { get; set; }
        public long? ActiveContractsId { get; set; }
        public long? DgAllocationId { get; set; }
        public long? InterventionTypeId { get; set; }

        public virtual ActiveContract? ActiveContracts { get; set; }
        public virtual Company? Company { get; set; }
        public virtual DgAllocation? DgAllocation { get; set; }
        public virtual InterventionType? InterventionType { get; set; }
        public virtual Wsp? Wsp { get; set; }
        public virtual ICollection<ActiveContractDetail> ActiveContractDetails { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearners { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChanges { get; set; }
        public virtual ICollection<PaymentRequest> PaymentRequests { get; set; }
        public virtual ICollection<ProjectImplementationPlanLearner> ProjectImplementationPlanLearners { get; set; }
    }
}

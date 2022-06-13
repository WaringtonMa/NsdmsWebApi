using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ProjectImplementationPlanLearner
    {
        public ProjectImplementationPlanLearner()
        {
            ActiveContractDetails = new HashSet<ActiveContractDetail>();
            WorkplaceMonitoringLearnerPayments = new HashSet<WorkplaceMonitoringLearnerPayment>();
        }

        public long Id { get; set; }
        public ulong? AllPaymentsCompleted { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? CompanyId { get; set; }
        public long? CompanyLearnersId { get; set; }
        public long? DgAllocationId { get; set; }
        public long? ProjectImplementationPlanId { get; set; }
        public long? WspId { get; set; }
        public int? LearnerNumber { get; set; }
        public int? NextTranchPayment { get; set; }
        public long? ActiveContractsId { get; set; }
        public long? InterventionTypeLink { get; set; }

        public virtual ActiveContract? ActiveContracts { get; set; }
        public virtual Company? Company { get; set; }
        public virtual CompanyLearner? CompanyLearners { get; set; }
        public virtual DgAllocation? DgAllocation { get; set; }
        public virtual InterventionType? InterventionTypeLinkNavigation { get; set; }
        public virtual ProjectImplementationPlan? ProjectImplementationPlan { get; set; }
        public virtual Wsp? Wsp { get; set; }
        public virtual ICollection<ActiveContractDetail> ActiveContractDetails { get; set; }
        public virtual ICollection<WorkplaceMonitoringLearnerPayment> WorkplaceMonitoringLearnerPayments { get; set; }
    }
}

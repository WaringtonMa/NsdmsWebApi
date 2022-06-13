using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ProjectImplementationPlanLearnersHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
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

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

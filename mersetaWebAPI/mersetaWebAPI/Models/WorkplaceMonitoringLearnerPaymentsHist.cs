using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkplaceMonitoringLearnerPaymentsHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? CreateDate { get; set; }
        public ulong? FinalTranchePaid { get; set; }
        public DateTime? LastActionDate { get; set; }
        public ulong? PayTranchPayment { get; set; }
        public ulong? PaymentAvalible { get; set; }
        public ulong? RanCheck { get; set; }
        public string? ReasonPaymentNotAvalaible { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public string? TranchPayment { get; set; }
        public long? ActiveContractsId { get; set; }
        public long? LastActionUser { get; set; }
        public long? ProjectImplementationPlanLearnersId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class PaymentRequest
    {
        public long Id { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public ulong? FinalPaymentForContract { get; set; }
        public string? RejectionReason { get; set; }
        public int? Status { get; set; }
        public decimal? TotalPayment { get; set; }
        public string? TranchNumber { get; set; }
        public long? ActiveContractDetailId { get; set; }
        public long? ActiveContractsId { get; set; }
        public long? ApprovalUserId { get; set; }
        public long? CompanyId { get; set; }
        public long? CreateUserId { get; set; }
        public long? ProjectImplementationPlanId { get; set; }
        public long? RegionalManagerUserId { get; set; }
        public long? SloUserId { get; set; }

        public virtual ActiveContractDetail? ActiveContractDetail { get; set; }
        public virtual ActiveContract? ActiveContracts { get; set; }
        public virtual User? ApprovalUser { get; set; }
        public virtual Company? Company { get; set; }
        public virtual User? CreateUser { get; set; }
        public virtual ProjectImplementationPlan? ProjectImplementationPlan { get; set; }
        public virtual User? RegionalManagerUser { get; set; }
        public virtual User? SloUser { get; set; }
    }
}

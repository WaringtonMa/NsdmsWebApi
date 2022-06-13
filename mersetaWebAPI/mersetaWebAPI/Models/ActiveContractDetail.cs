using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ActiveContractDetail
    {
        public ActiveContractDetail()
        {
            GpGrantBatchEntries = new HashSet<GpGrantBatchEntry>();
            PaymentRequests = new HashSet<PaymentRequest>();
        }

        public long Id { get; set; }
        public double? Accruals { get; set; }
        public double? AccrualsReversals { get; set; }
        public double? AddendumsAmmendments { get; set; }
        public double? Additions { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public decimal? ClosingBalance { get; set; }
        public double? CorrectionToBalances { get; set; }
        public DateTime? CreateDate { get; set; }
        public double? NoOfTerminations { get; set; }
        public decimal? OpeningBalance { get; set; }
        public DateTime? PaymentMonth { get; set; }
        public double? Payments { get; set; }
        public int? Status { get; set; }
        public double? TerminationValue { get; set; }
        public decimal? Total { get; set; }
        public double? WriteBack { get; set; }
        public long? ActiveContractsId { get; set; }
        public string? TrancheEnum { get; set; }
        public long? CompanyLearnersId { get; set; }
        public long? InterventionTypeId { get; set; }
        public long? ProjectImplementationPlanId { get; set; }
        public long? UsersId { get; set; }
        public long? ProjectImplementationPlanLearnersId { get; set; }

        public virtual ActiveContract? ActiveContracts { get; set; }
        public virtual CompanyLearner? CompanyLearners { get; set; }
        public virtual InterventionType? InterventionType { get; set; }
        public virtual ProjectImplementationPlan? ProjectImplementationPlan { get; set; }
        public virtual ProjectImplementationPlanLearner? ProjectImplementationPlanLearners { get; set; }
        public virtual User? Users { get; set; }
        public virtual ICollection<GpGrantBatchEntry> GpGrantBatchEntries { get; set; }
        public virtual ICollection<PaymentRequest> PaymentRequests { get; set; }
    }
}

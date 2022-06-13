using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyLearnersTransferHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? LearnerTransferType { get; set; }
        public int? Status { get; set; }
        public string? TransferReason { get; set; }
        public int? TransferRequestType { get; set; }
        public long? CompanyLearnersId { get; set; }
        public long? TransferToCompanyId { get; set; }
        public DateTime? ApprovalDateCompanySelected { get; set; }
        public DateTime? ApprovalDateLearner { get; set; }
        public int? CompanyLearnerPreviousStatus { get; set; }
        public int? LearnerPreviousStatus { get; set; }
        public int? LearnerTransferApproval { get; set; }
        public string? RejectionNote { get; set; }
        public ulong? WithNewProvider { get; set; }
        public long? ApproveUser { get; set; }
        public long? CompanySelectedApprovalUser { get; set; }
        public long? CreateUser { get; set; }
        public long? LearnerApproved { get; set; }
        public int? Recommendation { get; set; }
        public DateTime? SiteVisitDate { get; set; }
        public long? TasksId { get; set; }
        public long? AdminUserId { get; set; }
        public long? ApproveUserId { get; set; }
        public long? CoordinatorUserId { get; set; }
        public long? CreateUserId { get; set; }
        public long? CurrentCompanyAssignedId { get; set; }
        public long? LearnerUserId { get; set; }
        public long? OrginalTrainingProviderApplicationId { get; set; }
        public long? TransferCompanyRepresentativeUserId { get; set; }
        public long? TransferTrainingProviderApplicationId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

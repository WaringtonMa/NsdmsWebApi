using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyLearnersTransfer
    {
        public long Id { get; set; }
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

        public virtual User? AdminUser { get; set; }
        public virtual User? ApproveUser1 { get; set; }
        public virtual User? ApproveUserNavigation { get; set; }
        public virtual CompanyLearner? CompanyLearners { get; set; }
        public virtual User? CompanySelectedApprovalUserNavigation { get; set; }
        public virtual User? CoordinatorUser { get; set; }
        public virtual User? CreateUser1 { get; set; }
        public virtual User? CreateUserNavigation { get; set; }
        public virtual Company? CurrentCompanyAssigned { get; set; }
        public virtual User? LearnerApprovedNavigation { get; set; }
        public virtual User? LearnerUser { get; set; }
        public virtual TrainingProviderApplication? OrginalTrainingProviderApplication { get; set; }
        public virtual Task? Tasks { get; set; }
        public virtual User? TransferCompanyRepresentativeUser { get; set; }
        public virtual Company? TransferToCompany { get; set; }
        public virtual TrainingProviderApplication? TransferTrainingProviderApplication { get; set; }
    }
}

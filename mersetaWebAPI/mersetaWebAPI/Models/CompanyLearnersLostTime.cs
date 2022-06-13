using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyLearnersLostTime
    {
        public long Id { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? LostTimeReason { get; set; }
        public int? Status { get; set; }
        public long? CompanyLearnersId { get; set; }
        public int? DaysExtended { get; set; }
        public DateTime? LostTimeEndDate { get; set; }
        public DateTime? LostTimeStartDate { get; set; }
        public DateTime? NewCompletionDate { get; set; }
        public long? CreateUserId { get; set; }
        public DateTime? FirstApprovalDate { get; set; }
        public long? ApprovalUserId { get; set; }
        public long? TrainingProviderApplicationId { get; set; }
        public DateTime? CalculatedEndDate { get; set; }
        public ulong? DesignatedTradeExtension { get; set; }
        public DateTime? OrginalEndDate { get; set; }
        public int? WeeksAssigned { get; set; }
        public long? DesignatedTradeId { get; set; }
        public long? DesignatedTradeLevelId { get; set; }
        public int? CreatedByEnum { get; set; }
        public int? SignoffByEnum { get; set; }

        public virtual User? ApprovalUser { get; set; }
        public virtual CompanyLearner? CompanyLearners { get; set; }
        public virtual User? CreateUser { get; set; }
        public virtual DesignatedTrade? DesignatedTrade { get; set; }
        public virtual DesignatedTradeLevel? DesignatedTradeLevel { get; set; }
        public virtual TrainingProviderApplication? TrainingProviderApplication { get; set; }
    }
}

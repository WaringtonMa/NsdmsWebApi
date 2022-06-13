using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SdpCompanyAction
    {
        public long Id { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? ApprovalStatus { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? SdpCompanyAction1 { get; set; }
        public long? SdpCompanyFlatId { get; set; }
        public long? TrainingProviderApplicationId { get; set; }
        public long? ApprovalUserId { get; set; }
        public long? CompanyId { get; set; }
        public long? CreateUserId { get; set; }
        public long? CurrentDesignationId { get; set; }
        public long? NewDesignationId { get; set; }
        public long? SdpUserId { get; set; }
        public long? TrainingSiteId { get; set; }
        public string? Reason { get; set; }

        public virtual User? ApprovalUser { get; set; }
        public virtual Company? Company { get; set; }
        public virtual User? CreateUser { get; set; }
        public virtual SdpType? CurrentDesignation { get; set; }
        public virtual SdpType? NewDesignation { get; set; }
        public virtual User? SdpUser { get; set; }
        public virtual TrainingProviderApplication? TrainingProviderApplication { get; set; }
        public virtual TrainingSite? TrainingSite { get; set; }
    }
}

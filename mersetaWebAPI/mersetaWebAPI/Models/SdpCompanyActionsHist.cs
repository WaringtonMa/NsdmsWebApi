using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SdpCompanyActionsHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? ApprovalStatus { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? SdpCompanyAction { get; set; }
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

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

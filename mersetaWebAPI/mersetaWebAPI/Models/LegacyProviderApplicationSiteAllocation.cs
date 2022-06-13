using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyProviderApplicationSiteAllocation
    {
        public long Id { get; set; }
        public string? AccreditationNumberAtTime { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Reason { get; set; }
        public long? CompanyId { get; set; }
        public long? CreateUserId { get; set; }
        public long? TrainingProviderApplicationId { get; set; }
        public long? TrainingSiteId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual User? CreateUser { get; set; }
        public virtual TrainingProviderApplication? TrainingProviderApplication { get; set; }
        public virtual TrainingSite? TrainingSite { get; set; }
    }
}

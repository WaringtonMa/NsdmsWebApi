using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyLearnerUser
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreatedByEnum { get; set; }
        public long? CompanyId { get; set; }
        public long? CreateUserId { get; set; }
        public long? TrainingProviderApplicationId { get; set; }
        public long? UserId { get; set; }
        public long? LegalGaurdianId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual User? CreateUser { get; set; }
        public virtual User? LegalGaurdian { get; set; }
        public virtual TrainingProviderApplication? TrainingProviderApplication { get; set; }
        public virtual User? User { get; set; }
    }
}

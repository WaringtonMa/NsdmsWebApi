using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class TrainingProviderLearnership
    {
        public long Id { get; set; }
        public ulong? Accept { get; set; }
        public DateTime? CreateDate { get; set; }
        public ulong? ManuallyAdded { get; set; }
        public string? Note { get; set; }
        public ulong? SoftDelete { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? LearnershipId { get; set; }
        public long? TrainingProviderApplicationId { get; set; }
        public long? TrainingProviderDocParentId { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }

        public virtual Learnership? Learnership { get; set; }
        public virtual Revinfo RevNavigation { get; set; } = null!;
        public virtual TrainingProviderApplication? TrainingProviderApplication { get; set; }
        public virtual TrainingProviderDocParent? TrainingProviderDocParent { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class TrainingProviderSkillsSet
    {
        public long Id { get; set; }
        public ulong? Accept { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Note { get; set; }
        public ulong? SoftDelete { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? SkillsSetId { get; set; }
        public long? TrainingProviderApplicationId { get; set; }
        public long? TrainingProviderDocParentId { get; set; }
        public ulong? ManuallyAdded { get; set; }

        public virtual SkillsSet? SkillsSet { get; set; }
        public virtual TrainingProviderApplication? TrainingProviderApplication { get; set; }
        public virtual TrainingProviderDocParent? TrainingProviderDocParent { get; set; }
    }
}

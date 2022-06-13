using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class TrainingProviderSkillsProgram
    {
        public long Id { get; set; }
        public ulong? Accept { get; set; }
        public ulong? SoftDelete { get; set; }
        public long? SkillsProgramId { get; set; }
        public long? TrainingProviderApplicationId { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? TrainingProviderDocParentId { get; set; }
        public ulong? ManuallyAdded { get; set; }

        public virtual SkillsProgram? SkillsProgram { get; set; }
        public virtual TrainingProviderApplication? TrainingProviderApplication { get; set; }
        public virtual TrainingProviderDocParent? TrainingProviderDocParent { get; set; }
    }
}

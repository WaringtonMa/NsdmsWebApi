using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SkillsIdentification
    {
        public SkillsIdentification()
        {
            LearnershipDevelopmentRegistrations = new HashSet<LearnershipDevelopmentRegistration>();
            SkillsRegistrations = new HashSet<SkillsRegistration>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? Description { get; set; }
        public string? SmsCode { get; set; }

        public virtual ICollection<LearnershipDevelopmentRegistration> LearnershipDevelopmentRegistrations { get; set; }
        public virtual ICollection<SkillsRegistration> SkillsRegistrations { get; set; }
    }
}

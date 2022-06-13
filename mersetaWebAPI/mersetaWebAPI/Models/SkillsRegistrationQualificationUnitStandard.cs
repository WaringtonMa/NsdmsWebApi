using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SkillsRegistrationQualificationUnitStandard
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? QualificationId { get; set; }
        public long? SkillsRegistrationId { get; set; }
        public long? UnitStandardsId { get; set; }

        public virtual SaqaQualification? Qualification { get; set; }
        public virtual SkillsRegistration? SkillsRegistration { get; set; }
        public virtual SaqaUnitstandard? UnitStandards { get; set; }
    }
}

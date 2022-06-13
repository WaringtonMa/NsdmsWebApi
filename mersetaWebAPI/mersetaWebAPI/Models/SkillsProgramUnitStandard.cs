using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SkillsProgramUnitStandard
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public long? SkillsProgramId { get; set; }
        public long? UnitStandardsId { get; set; }
        public string? SmsCode { get; set; }
        public long? QualificationId { get; set; }
        public int? UnitStandardTypeEnum { get; set; }

        public virtual SaqaQualification? Qualification { get; set; }
        public virtual SkillsProgram? SkillsProgram { get; set; }
        public virtual SaqaUnitstandard? UnitStandards { get; set; }
    }
}

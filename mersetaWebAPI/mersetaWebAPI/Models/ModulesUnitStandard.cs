using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ModulesUnitStandard
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public long ModulesId { get; set; }
        public long UnitStandardsId { get; set; }
        public string? SmsCode { get; set; }

        public virtual Module Modules { get; set; } = null!;
        public virtual SaqaUnitstandard UnitStandards { get; set; } = null!;
    }
}

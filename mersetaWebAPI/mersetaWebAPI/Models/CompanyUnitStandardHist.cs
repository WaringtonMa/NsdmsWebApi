using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyUnitStandardHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public ulong? Accept { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Note { get; set; }
        public ulong? SoftDelete { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? CompanyId { get; set; }
        public long? ForQualificationId { get; set; }
        public long? NonSetaCompanyId { get; set; }
        public long? TrainingProviderDocParentId { get; set; }
        public long? UnitStandardId { get; set; }
        public ulong? ManuallyAdded { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

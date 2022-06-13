using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkPlaceApprovalUnitStandard
    {
        public long Id { get; set; }
        public ulong? Accept { get; set; }
        public int? AcceptEnum { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Note { get; set; }
        public ulong? SoftDelete { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? TrainingProviderDocParentId { get; set; }
        public long? UnitStandardsId { get; set; }
        public long? WorkPlaceApprovalId { get; set; }

        public virtual TrainingProviderDocParent? TrainingProviderDocParent { get; set; }
        public virtual SaqaUnitstandard? UnitStandards { get; set; }
        public virtual WorkPlaceApproval? WorkPlaceApproval { get; set; }
    }
}

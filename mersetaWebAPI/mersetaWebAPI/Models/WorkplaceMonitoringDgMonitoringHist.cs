using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkplaceMonitoringDgMonitoringHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public int? ActiveContractStatus { get; set; }
        public ulong? CanTermiateMoa { get; set; }
        public string? ContractStatusEnum { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? KeepContractActive { get; set; }
        public DateTime? LastActionDate { get; set; }
        public string? MoaType { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? ActiveContractsId { get; set; }
        public long? LastActionUser { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ScheduleChangesLog
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Information { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? CompanyId { get; set; }
        public ulong? ManualIntervention { get; set; }
        public long? ForUserId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual User? ForUser { get; set; }
    }
}

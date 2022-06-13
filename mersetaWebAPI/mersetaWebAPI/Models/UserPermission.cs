using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class UserPermission
    {
        public long Id { get; set; }
        public ulong? ProviderSuspension { get; set; }
        public ulong? ProviderSuspensionAlter { get; set; }
        public long? UserId { get; set; }
        public ulong? LegacySiteAllocation { get; set; }
        public ulong? LegacySiteAllocationAlter { get; set; }

        public virtual User? User { get; set; }
    }
}

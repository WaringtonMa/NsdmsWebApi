using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class AllocationChangesReason
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? AllocationChangeId { get; set; }
        public long? DgAllocationParentId { get; set; }

        public virtual AllocationChange? AllocationChange { get; set; }
        public virtual DgAllocationParent? DgAllocationParent { get; set; }
    }
}

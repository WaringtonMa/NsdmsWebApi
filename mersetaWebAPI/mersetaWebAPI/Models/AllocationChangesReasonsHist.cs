using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class AllocationChangesReasonsHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? AllocationChangeId { get; set; }
        public long? DgAllocationParentId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

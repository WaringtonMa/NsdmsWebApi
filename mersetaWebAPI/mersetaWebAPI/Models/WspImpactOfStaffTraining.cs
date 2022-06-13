using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WspImpactOfStaffTraining
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public ulong? NotAtAll { get; set; }
        public ulong? NotReally { get; set; }
        public ulong? Nuetral { get; set; }
        public string? RowDescription { get; set; }
        public ulong? ToaLargeExtent { get; set; }
        public ulong? ToaLimitedExtent { get; set; }
        public long? WspId { get; set; }

        public virtual Wsp? Wsp { get; set; }
    }
}

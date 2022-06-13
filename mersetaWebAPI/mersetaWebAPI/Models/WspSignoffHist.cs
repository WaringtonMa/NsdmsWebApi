using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WspSignoffHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public ulong? Accept { get; set; }
        public DateTime? CreateDate { get; set; }
        public ulong? Dispute { get; set; }
        public DateTime? SignOffDate { get; set; }
        public long? SdfTypeId { get; set; }
        public long? UserId { get; set; }
        public long? WspId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

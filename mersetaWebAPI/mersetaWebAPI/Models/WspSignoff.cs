using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WspSignoff
    {
        public long Id { get; set; }
        public ulong? Accept { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? UserId { get; set; }
        public long? WspId { get; set; }
        public ulong? Dispute { get; set; }
        public long? SdfTypeId { get; set; }
        public DateTime? SignOffDate { get; set; }

        public virtual SdfType? SdfType { get; set; }
        public virtual User? User { get; set; }
        public virtual Wsp? Wsp { get; set; }
    }
}

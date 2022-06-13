using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WspRejectionInformation
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? FlatTaskLinkId { get; set; }
        public ulong? LatestEntry { get; set; }
        public long? RejectReasonId { get; set; }
        public long? RoleId { get; set; }
        public long? UserId { get; set; }
        public long? WspId { get; set; }

        public virtual RejectReason? RejectReason { get; set; }
        public virtual Role? Role { get; set; }
        public virtual User? User { get; set; }
        public virtual Wsp? Wsp { get; set; }
    }
}

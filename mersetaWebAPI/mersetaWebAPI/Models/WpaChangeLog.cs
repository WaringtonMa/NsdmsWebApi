using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WpaChangeLog
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? QualificationId { get; set; }
        public long? UserId { get; set; }
        public ulong? Value { get; set; }
    }
}

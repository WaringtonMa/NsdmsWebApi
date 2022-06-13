using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class RejectReasonMultipleSelectionHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ForProcess { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? CreateUserId { get; set; }
        public long? RejectReasonId { get; set; }
        public string? AdditionalInformation { get; set; }
        public long? TaskId { get; set; }

        public virtual User? CreateUser { get; set; }
        public virtual RejectReason? RejectReason { get; set; }
        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

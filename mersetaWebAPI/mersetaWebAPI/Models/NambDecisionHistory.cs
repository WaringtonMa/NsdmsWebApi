using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class NambDecisionHistory
    {
        public long Id { get; set; }
        public string? AdditionalInformation { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Status { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? CreateUserId { get; set; }

        public virtual User? CreateUser { get; set; }
    }
}

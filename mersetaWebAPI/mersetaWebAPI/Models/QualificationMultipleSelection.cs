using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class QualificationMultipleSelection
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ForProcess { get; set; }
        public string? TargetClass { get; set; }
        public long TargetKey { get; set; }
        public long? CreateUserId { get; set; }
        public long QualificationId { get; set; }

        public virtual User? CreateUser { get; set; }
        public virtual SaqaQualification Qualification { get; set; } = null!;
    }
}

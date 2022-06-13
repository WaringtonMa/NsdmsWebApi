using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ChangeReason
    {
        public ChangeReason()
        {
            Docs = new HashSet<Doc>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Description { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }

        public virtual ICollection<Doc> Docs { get; set; }
    }
}

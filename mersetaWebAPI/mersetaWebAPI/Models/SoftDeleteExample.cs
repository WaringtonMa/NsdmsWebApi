using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SoftDeleteExample
    {
        public SoftDeleteExample()
        {
            SoftDeleteChildExamples = new HashSet<SoftDeleteChildExample>();
        }

        public long Id { get; set; }
        public ulong? Deleted { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<SoftDeleteChildExample> SoftDeleteChildExamples { get; set; }
    }
}

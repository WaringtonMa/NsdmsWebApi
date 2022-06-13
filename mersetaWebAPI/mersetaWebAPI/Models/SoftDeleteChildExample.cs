using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SoftDeleteChildExample
    {
        public long Id { get; set; }
        public ulong? Deleted { get; set; }
        public string? ChildDescription { get; set; }
        public long? SoftDeleteExampleId { get; set; }

        public virtual SoftDeleteExample? SoftDeleteExample { get; set; }
    }
}

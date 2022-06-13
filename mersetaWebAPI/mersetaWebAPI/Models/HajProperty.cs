using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class HajProperty
    {
        public long EPropertyId { get; set; }
        public string EProperty { get; set; } = null!;
        public string? EValue { get; set; }
    }
}

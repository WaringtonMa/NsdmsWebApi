using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DocByte
    {
        public byte[]? Data { get; set; }
        public long DocId { get; set; }

        public virtual Doc Doc { get; set; } = null!;
    }
}

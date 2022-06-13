using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class RestoreDocByte
    {
        public int? DocId { get; set; }
        public byte[]? Data { get; set; }
    }
}

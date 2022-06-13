using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SupportEmail
    {
        public long Id { get; set; }
        public string? Email { get; set; }
        public int? SupportType { get; set; }
    }
}

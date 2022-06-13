using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ExceptionsTable
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Exception { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
    }
}

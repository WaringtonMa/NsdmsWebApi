using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ExtractErrorList
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public long FileId { get; set; }
        public string? FileName { get; set; }
        public string? Note { get; set; }
        public string? TargetClass { get; set; }
    }
}

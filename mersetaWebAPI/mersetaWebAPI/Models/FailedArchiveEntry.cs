using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class FailedArchiveEntry
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Exception { get; set; }
        public string? LocationFailed { get; set; }
        public long? MandatoryGrantDetailId { get; set; }
    }
}

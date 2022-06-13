using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class JasperDownloadTracker
    {
        public long Id { get; set; }
        public string? Action { get; set; }
        public string? AdditionalInformation { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? PageUrl { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? UserId { get; set; }
    }
}

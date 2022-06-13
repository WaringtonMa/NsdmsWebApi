using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class UploadTrackerAtrWsp
    {
        public long Id { get; set; }
        public string? Action { get; set; }
        public int? Amount { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Section { get; set; }
        public long? UserId { get; set; }
        public long? WspId { get; set; }
    }
}

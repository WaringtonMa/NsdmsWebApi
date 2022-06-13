using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DocumentTracker
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public int? DocumentTrackerEnum { get; set; }
        public long DocId { get; set; }
        public long? UserId { get; set; }

        public virtual Doc Doc { get; set; } = null!;
        public virtual User? User { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LearnerInduction
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? NumberOfAttendees { get; set; }
        public long? UserId { get; set; }
        public long? WorkplaceMonitoringId { get; set; }

        public virtual SaqaQualification? User { get; set; }
        public virtual WorkplaceMonitoring? WorkplaceMonitoring { get; set; }
    }
}

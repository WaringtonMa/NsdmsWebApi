using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkplaceMonitoringMitigation
    {
        public long Id { get; set; }
        public DateTime? ActionDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string? NonComplianceIssue { get; set; }
        public int? Status { get; set; }
        public long? ResponsibleId { get; set; }
        public long? WorkplaceMonitoringId { get; set; }

        public virtual User? Responsible { get; set; }
        public virtual WorkplaceMonitoring? WorkplaceMonitoring { get; set; }
    }
}

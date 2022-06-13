using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class UpdateAuditTrailChange
    {
        public long Id { get; set; }
        public string? FieldName { get; set; }
        public string? FromValue { get; set; }
        public string? ToValue { get; set; }
        public long? AuditTrailId { get; set; }

        public virtual UpdateAuditTrail? AuditTrail { get; set; }
    }
}

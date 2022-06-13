using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class MgVerificationCompleted
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? FinalFin { get; set; }
        public string? Note { get; set; }
        public DateTime? ResetDate { get; set; }
        public long? CompanyId { get; set; }

        public virtual Company? Company { get; set; }
    }
}

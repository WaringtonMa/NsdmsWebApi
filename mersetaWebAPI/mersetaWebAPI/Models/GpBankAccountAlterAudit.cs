using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class GpBankAccountAlterAudit
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Reason { get; set; }
        public string? ReasonForAlteration { get; set; }
        public ulong? SetToHold { get; set; }
        public long? CompanyId { get; set; }
        public long? UserId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual User? User { get; set; }
    }
}

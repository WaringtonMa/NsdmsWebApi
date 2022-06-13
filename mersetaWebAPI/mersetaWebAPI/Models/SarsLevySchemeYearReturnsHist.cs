using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SarsLevySchemeYearReturnsHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public ulong? AllowInvoicesDiscretionary { get; set; }
        public ulong? AllowInvoicesMandatory { get; set; }
        public ulong? AllowReturnsDiscretionary { get; set; }
        public ulong? AllowReturnsMandatory { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ForSchemeYear { get; set; }
        public DateTime? LastActionDate { get; set; }
        public long? LastActionUserId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SarsLevySchemeYearReturn
    {
        public long Id { get; set; }
        public ulong? AllowInvoicesDiscretionary { get; set; }
        public ulong? AllowInvoicesMandatory { get; set; }
        public ulong? AllowReturnsDiscretionary { get; set; }
        public ulong? AllowReturnsMandatory { get; set; }
        public DateTime? CreateDate { get; set; }
        public int ForSchemeYear { get; set; }
        public DateTime? LastActionDate { get; set; }
        public long? LastActionUserId { get; set; }

        public virtual User? LastActionUser { get; set; }
    }
}

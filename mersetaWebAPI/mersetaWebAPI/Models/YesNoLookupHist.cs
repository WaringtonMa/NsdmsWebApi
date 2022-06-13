using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class YesNoLookupHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? YesNoName { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

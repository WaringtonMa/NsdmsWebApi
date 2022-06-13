using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class FinYearQuartersLookUpHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public string? Description { get; set; }
        public int? FinYearQuarters { get; set; }
        public DateTime? FromDate { get; set; }
        public int? OrderNumber { get; set; }
        public DateTime? ToDate { get; set; }
        public ulong? UseNextYear { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

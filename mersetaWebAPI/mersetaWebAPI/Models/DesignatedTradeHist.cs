using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DesignatedTradeHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public ulong? AutoExtend { get; set; }
        public string? Description { get; set; }
        public int? DesignatedTradeType { get; set; }
        public long? Duration { get; set; }
        public long? Extention { get; set; }
        public string? QualificationId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

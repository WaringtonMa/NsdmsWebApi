using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DesignatedTradeLevelItemsHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public long? DesignatedTradeLevelId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

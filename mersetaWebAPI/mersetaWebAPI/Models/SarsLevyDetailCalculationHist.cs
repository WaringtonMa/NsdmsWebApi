using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SarsLevyDetailCalculationHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public double? AdminPercentage { get; set; }
        public DateTime? CreateDate { get; set; }
        public double? DiscretionaryPercentage { get; set; }
        public int? ForSchemeYear { get; set; }
        public DateTime? LastActionDate { get; set; }
        public double? MandatoryPercentage { get; set; }
        public double? QctoPercentage { get; set; }
        public long? LastActionUserId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

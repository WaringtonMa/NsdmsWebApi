using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SkillsGapTrackLookUpHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public string? Description { get; set; }
        public ulong? FutherDetailRequired { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SaqaQualificationAud
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public long? DesignatedTradeId { get; set; }
        public long? LearnerMentorRatioId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

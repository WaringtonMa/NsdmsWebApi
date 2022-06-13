using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SdpTypeHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public ulong? ActionLearners { get; set; }
        public ulong? ActionSdpInformation { get; set; }
        public ulong? ActionTradeTestCentreAssessors { get; set; }
        public ulong? AlterAssModLinked { get; set; }
        public ulong? AlterSdpsLinked { get; set; }
        public ulong? AlterSiteInfo { get; set; }
        public string? Description { get; set; }
        public ulong? RegisterLearners { get; set; }
        public ulong? ViewLearners { get; set; }
        public ulong? ViewSdpInformation { get; set; }
        public ulong? ViewTradeTestCentreAssessors { get; set; }
        public long? DesignationId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

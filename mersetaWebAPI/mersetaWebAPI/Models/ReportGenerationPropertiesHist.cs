using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ReportGenerationPropertiesHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? DateGenerationStarted { get; set; }
        public DateTime? DateLastCompleted { get; set; }
        public string? Description { get; set; }
        public ulong? GenerationUnderway { get; set; }
        public int? ReportProperty { get; set; }
        public long? UserStartedGenerationId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

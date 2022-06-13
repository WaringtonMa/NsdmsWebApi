using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class NqfLevelsHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Description { get; set; }
        public int? Level { get; set; }
        public string? Pre2009Description { get; set; }
        public string? SaqaQualificationDescription { get; set; }
        public string? UnitStandardCode { get; set; }
        public long? HighestQualificationRequiredId { get; set; }
        public long? InterventionLevelId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LevyIncomeSummary
    {
        public long Id { get; set; }
        public string? Auto { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Description { get; set; }
        public string? Metal { get; set; }
        public string? Motor { get; set; }
        public string? NewTyre { get; set; }
        public string? Plastic { get; set; }
        public string? Total { get; set; }
        public string? Unknown { get; set; }
        public int? ReportProperty { get; set; }
    }
}

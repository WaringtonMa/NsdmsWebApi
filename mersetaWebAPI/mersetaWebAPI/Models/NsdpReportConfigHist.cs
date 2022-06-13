using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class NsdpReportConfigHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Description { get; set; }
        public DateTime? LastActionDate { get; set; }
        public ulong? ManualCapture { get; set; }
        public int? NsdpReportRunType { get; set; }
        public int? TargetAmount { get; set; }
        public long? FinancialYearsId { get; set; }
        public long? LastActionUserId { get; set; }
        public string? NsdpOutcomes { get; set; }
        public string? NsdpSubOutcomes { get; set; }
        public int? OrderNumber { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

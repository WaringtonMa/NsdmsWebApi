using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DesignatedTradeLevelHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? DateLegacyAttempts { get; set; }
        public string? Description { get; set; }
        public string? DocumentNumber { get; set; }
        public string? DocumentTitle { get; set; }
        public ulong? Extension { get; set; }
        public int? LegacyMaxAttemptsAmount { get; set; }
        public long? Level { get; set; }
        public int? MaxAttemptsAmount { get; set; }
        public long? Maxweeks { get; set; }
        public long? Minweeks { get; set; }
        public ulong? NoOrder { get; set; }
        public string? ReportDisplayName { get; set; }
        public string? ReportDownloadName { get; set; }
        public int? TotalModulesAssigned { get; set; }
        public long? DesignatedTradeId { get; set; }
        public long? DesignatedTradeTypeId { get; set; }
        public long? QualificationId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

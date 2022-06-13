using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class NsdpQuarterReporting
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? FinYearQuarters { get; set; }
        public long? FinYearQuartersLookUpFlatKey { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? LastActionDate { get; set; }
        public int? QuarterAchivedAmount { get; set; }
        public int? QuarterTargetAmount { get; set; }
        public ulong? SystemUpdate { get; set; }
        public DateTime? ToDate { get; set; }
        public long? FinancialYearsId { get; set; }
        public long? LastActionUserId { get; set; }
        public long? NsdpReportConfigId { get; set; }
        public ulong? DataGenerated { get; set; }
        public DateTime? DataAutoPopulationRan { get; set; }

        public virtual FinancialYear? FinancialYears { get; set; }
        public virtual User? LastActionUser { get; set; }
        public virtual NsdpReportConfig? NsdpReportConfig { get; set; }
    }
}

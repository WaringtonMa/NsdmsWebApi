using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class FinancialYear
    {
        public FinancialYear()
        {
            NsdpQuarterReportings = new HashSet<NsdpQuarterReporting>();
            NsdpReportConfigs = new HashSet<NsdpReportConfig>();
            QmrFinYears = new HashSet<QmrFinYear>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? Description { get; set; }
        public int? EndYear { get; set; }
        public int? GrantFocusYear { get; set; }
        public int? StartYear { get; set; }

        public virtual ICollection<NsdpQuarterReporting> NsdpQuarterReportings { get; set; }
        public virtual ICollection<NsdpReportConfig> NsdpReportConfigs { get; set; }
        public virtual ICollection<QmrFinYear> QmrFinYears { get; set; }
    }
}

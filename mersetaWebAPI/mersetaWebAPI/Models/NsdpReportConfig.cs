using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class NsdpReportConfig
    {
        public NsdpReportConfig()
        {
            NsdpQuarterReportings = new HashSet<NsdpQuarterReporting>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
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

        public virtual FinancialYear? FinancialYears { get; set; }
        public virtual User? LastActionUser { get; set; }
        public virtual ICollection<NsdpQuarterReporting> NsdpQuarterReportings { get; set; }
    }
}

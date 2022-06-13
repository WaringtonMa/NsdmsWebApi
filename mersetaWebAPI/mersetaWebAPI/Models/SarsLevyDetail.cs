using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SarsLevyDetail
    {
        public SarsLevyDetail()
        {
            GpGrantBatchEntries = new HashSet<GpGrantBatchEntry>();
            LevyDetailMgPaymentsAlterAudits = new HashSet<LevyDetailMgPaymentsAlterAudit>();
        }

        public long Id { get; set; }
        public double? AdminLevy { get; set; }
        public DateTime? ArrivalDate1 { get; set; }
        public DateTime? ArrivalDate2 { get; set; }
        public DateTime? CreateDate { get; set; }
        public double? MandatoryLevy { get; set; }
        public double? Interest { get; set; }
        public double? DiscretionaryLevy { get; set; }
        public double? Penalty { get; set; }
        public string? RefNo { get; set; }
        public int? SchemeYear { get; set; }
        public string? SetaCode { get; set; }
        public double? Total { get; set; }
        public long? SarsEmployerDetailId { get; set; }
        public long? SarsFilelId { get; set; }
        public ulong? CanAppearOnMgPayments { get; set; }

        public virtual SarsEmployerDetail? SarsEmployerDetail { get; set; }
        public virtual SarsFile? SarsFilel { get; set; }
        public virtual ICollection<GpGrantBatchEntry> GpGrantBatchEntries { get; set; }
        public virtual ICollection<LevyDetailMgPaymentsAlterAudit> LevyDetailMgPaymentsAlterAudits { get; set; }
    }
}

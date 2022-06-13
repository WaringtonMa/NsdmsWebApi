using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SarsFile
    {
        public SarsFile()
        {
            LevyDetailMgPaymentsAlterAudits = new HashSet<LevyDetailMgPaymentsAlterAudit>();
            SarsEmployerDetailAllDataForTestings = new HashSet<SarsEmployerDetailAllDataForTesting>();
            SarsEmployerDetailUpdateHistories = new HashSet<SarsEmployerDetailUpdateHistory>();
            SarsEmployerDetails = new HashSet<SarsEmployerDetail>();
            SarsLeviesPaids = new HashSet<SarsLeviesPaid>();
            SarsLevyDetails = new HashSet<SarsLevyDetail>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ForMonth { get; set; }
        public DateTime? LoadGpDate { get; set; }
        public ulong? LoadedToBp { get; set; }
        public long? LoadedToGpByUserId { get; set; }
        public ulong? CanProcessMgPayments { get; set; }

        public virtual User? LoadedToGpByUser { get; set; }
        public virtual ICollection<LevyDetailMgPaymentsAlterAudit> LevyDetailMgPaymentsAlterAudits { get; set; }
        public virtual ICollection<SarsEmployerDetailAllDataForTesting> SarsEmployerDetailAllDataForTestings { get; set; }
        public virtual ICollection<SarsEmployerDetailUpdateHistory> SarsEmployerDetailUpdateHistories { get; set; }
        public virtual ICollection<SarsEmployerDetail> SarsEmployerDetails { get; set; }
        public virtual ICollection<SarsLeviesPaid> SarsLeviesPaids { get; set; }
        public virtual ICollection<SarsLevyDetail> SarsLevyDetails { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SarsEmployerDetail
    {
        public SarsEmployerDetail()
        {
            GpGrantBatchEntries = new HashSet<GpGrantBatchEntry>();
            SarsEmployerDetailAllDataForTestings = new HashSet<SarsEmployerDetailAllDataForTesting>();
            SarsLevyDetails = new HashSet<SarsLevyDetail>();
        }

        public long Id { get; set; }
        public string? CompanyRegistrationNumber { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? RefNo { get; set; }
        public string? RegisteredNameOfEntity { get; set; }
        public string? SicCode2 { get; set; }
        public string? TradingName { get; set; }
        public string? TradingStatus { get; set; }
        public long? SarsFilelId { get; set; }
        public int? NoEmployesAccordingToSars { get; set; }
        public string? EmployerPostCode { get; set; }

        public virtual SarsFile? SarsFilel { get; set; }
        public virtual ICollection<GpGrantBatchEntry> GpGrantBatchEntries { get; set; }
        public virtual ICollection<SarsEmployerDetailAllDataForTesting> SarsEmployerDetailAllDataForTestings { get; set; }
        public virtual ICollection<SarsLevyDetail> SarsLevyDetails { get; set; }
    }
}

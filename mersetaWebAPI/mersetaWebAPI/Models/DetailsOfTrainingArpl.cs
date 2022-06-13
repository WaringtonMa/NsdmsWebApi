using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DetailsOfTrainingArpl
    {
        public long Id { get; set; }
        public string? Course { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? FromDate { get; set; }
        public string? NameSkillsProvider { get; set; }
        public DateTime? ToDate { get; set; }
        public long? CompanyLearnersTradeTestId { get; set; }

        public virtual CompanyLearnersTradeTest? CompanyLearnersTradeTest { get; set; }
    }
}

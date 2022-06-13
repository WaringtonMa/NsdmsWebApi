using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class TradeTestTaskResult
    {
        public long Id { get; set; }
        public int? Competence { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Task { get; set; }
        public long? CompanyLearnersTradeTestId { get; set; }

        public virtual CompanyLearnersTradeTest? CompanyLearnersTradeTest { get; set; }
    }
}

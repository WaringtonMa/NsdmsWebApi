using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DetailsOfExperienceArpl
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Detail { get; set; }
        public DateTime? FromDate { get; set; }
        public string? NameAddressWorkplace { get; set; }
        public DateTime? ToDate { get; set; }
        public long? CompanyLearnersTradeTestId { get; set; }

        public virtual CompanyLearnersTradeTest? CompanyLearnersTradeTest { get; set; }
    }
}

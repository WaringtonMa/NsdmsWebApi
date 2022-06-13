using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyLearnersProgress
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreditsCompleted { get; set; }
        public int? CreditsNeeded { get; set; }
        public string? ProgressType { get; set; }
        public long? CompanyLearnersId { get; set; }
        public long? DesignatedTradeLevelId { get; set; }

        public virtual CompanyLearner? CompanyLearners { get; set; }
        public virtual DesignatedTradeLevel? DesignatedTradeLevel { get; set; }
    }
}

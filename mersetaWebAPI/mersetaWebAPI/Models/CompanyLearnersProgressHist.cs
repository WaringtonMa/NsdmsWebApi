using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyLearnersProgressHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreditsCompleted { get; set; }
        public int? CreditsNeeded { get; set; }
        public string? ProgressType { get; set; }
        public long? CompanyLearnersId { get; set; }
        public long? DesignatedTradeLevelId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

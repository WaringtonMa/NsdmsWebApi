using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class TrainingProviderVerficationLearnersHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? CompanyLearnersId { get; set; }
        public long? TrainingProviderVerificationId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

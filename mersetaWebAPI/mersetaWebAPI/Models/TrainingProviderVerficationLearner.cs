using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class TrainingProviderVerficationLearner
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? CompanyLearnersId { get; set; }
        public long? TrainingProviderVerificationId { get; set; }

        public virtual CompanyLearner? CompanyLearners { get; set; }
        public virtual TrainingProviderVerfication? TrainingProviderVerification { get; set; }
    }
}

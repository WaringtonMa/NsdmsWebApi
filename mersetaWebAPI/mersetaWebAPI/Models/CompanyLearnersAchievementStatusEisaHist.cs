using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyLearnersAchievementStatusEisaHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public string? AssessmentCentreCode { get; set; }
        public string? AssessmentPartnerCode { get; set; }
        public string? DateAssessed { get; set; }
        public string? DateStamp { get; set; }
        public string? EisaComponentAchievementValue { get; set; }
        public string? EisaComponentNumber { get; set; }
        public string? EisaPercentageObtained { get; set; }
        public string? LearnerAlternateId { get; set; }
        public string? NationalId { get; set; }
        public string? QualificationId { get; set; }
        public long? AdministrationOfAqpLearnersId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

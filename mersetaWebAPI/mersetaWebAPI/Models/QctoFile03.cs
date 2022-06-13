using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class QctoFile03
    {
        public long Id { get; set; }
        public string? AssessmentCentreCode { get; set; }
        public string? AssessmentPartnerCode { get; set; }
        public DateTime? DateAssessed { get; set; }
        public DateTime? DateStamp { get; set; }
        public string? EisaComponentAchievementValue { get; set; }
        public string? EisaComponentNumber { get; set; }
        public string? EisaPercentageObtained { get; set; }
        public string? LearnerAlternateId { get; set; }
        public string? NationalId { get; set; }
        public string? QualificationId { get; set; }
    }
}

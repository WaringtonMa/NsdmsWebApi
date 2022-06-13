using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class NlrdFile30
    {
        public long Id { get; set; }
        public decimal? AlternativeIdType { get; set; }
        public string? AssessorEtqaId { get; set; }
        public string? AssessorRegistrationNumber { get; set; }
        public DateTime? CertificationDate { get; set; }
        public DateTime? DateStamp { get; set; }
        public string? HonoursClassification { get; set; }
        public DateTime? LearnerAchievementDate { get; set; }
        public decimal? LearnerAchievementStatusId { get; set; }
        public string? LearnerAchievementTypeId { get; set; }
        public DateTime? LearnerEnrolledDate { get; set; }
        public string? LearnershipId { get; set; }
        public string? NationalId { get; set; }
        public string? PartOf { get; set; }
        public string? PersonAlternateId { get; set; }
        public string? ProviderCode { get; set; }
        public string? ProviderEtqaId { get; set; }
        public string? QualificationId { get; set; }
        public int? UnitStandardId { get; set; }
    }
}

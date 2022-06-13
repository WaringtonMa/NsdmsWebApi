using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class NlrdFile24
    {
        public long Id { get; set; }
        public DateTime? DateStamp { get; set; }
        public string? EtqaDecisionNumber { get; set; }
        public string? LearnershipId { get; set; }
        public DateTime? ProviderAccredEndDate { get; set; }
        public DateTime? ProviderAccredStartDate { get; set; }
        public decimal? ProviderAccredStatusCode { get; set; }
        public string? ProviderAccreditAssessorInd { get; set; }
        public string? ProviderAccreditationNum { get; set; }
        public string? ProviderCode { get; set; }
        public string? ProviderEtqaId { get; set; }
        public decimal? QualificationId { get; set; }
        public decimal? UnitStandardId { get; set; }
    }
}

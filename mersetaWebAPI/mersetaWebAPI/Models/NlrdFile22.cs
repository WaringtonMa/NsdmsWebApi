using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class NlrdFile22
    {
        public long Id { get; set; }
        public string? AbetBandId { get; set; }
        public DateTime? DateStamp { get; set; }
        public string? NqfLevelId { get; set; }
        public string? ProviderCode { get; set; }
        public string? ProviderEtqaId { get; set; }
        public DateTime? QualRegistrationEndDate { get; set; }
        public DateTime? QualRegistrationStartDate { get; set; }
        public string? QualificationCode { get; set; }
        public string? QualificationName { get; set; }
        public string? QualificationTypeId { get; set; }
        public string? SubdomainId { get; set; }
    }
}

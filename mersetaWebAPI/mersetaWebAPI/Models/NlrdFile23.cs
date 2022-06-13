using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class NlrdFile23
    {
        public long Id { get; set; }
        public string? AbetBandId { get; set; }
        public string? CourseCode { get; set; }
        public string? CourseName { get; set; }
        public DateTime? CourseRegistrationEndDate { get; set; }
        public DateTime? CourseRegistrationStartDate { get; set; }
        public DateTime? DateStamp { get; set; }
        public string? NqfLevelId { get; set; }
        public string? ProviderCode { get; set; }
        public string? ProviderEtqaId { get; set; }
        public string? SubdomainId { get; set; }
    }
}

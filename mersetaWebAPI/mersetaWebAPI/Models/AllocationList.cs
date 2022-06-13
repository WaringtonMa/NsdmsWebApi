using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class AllocationList
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? EmploymentStatus { get; set; }
        public string? SspPriority { get; set; }
        public long? TotalAllocationForYear { get; set; }
        public long? InterventionTypeId { get; set; }
        public long? OfoCodesId { get; set; }
        public long? QualificationId { get; set; }
        public int? FinYear { get; set; }
        public long? DgYearId { get; set; }

        public virtual DgYear? DgYear { get; set; }
        public virtual InterventionType? InterventionType { get; set; }
        public virtual OfoCode? OfoCodes { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
    }
}

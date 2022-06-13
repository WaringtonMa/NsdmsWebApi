using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DgYearLearningProgram
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public decimal? AllocationAmount { get; set; }
        public string? Description { get; set; }
        public int? NumberOfEmployedLearners { get; set; }
        public int? NumberOfUnemployedLearners { get; set; }
        public long DgYearId { get; set; }
        public long InterventionTypeId { get; set; }

        public virtual DgYear DgYear { get; set; } = null!;
        public virtual InterventionType InterventionType { get; set; } = null!;
    }
}

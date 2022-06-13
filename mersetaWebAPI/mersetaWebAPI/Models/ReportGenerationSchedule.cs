using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ReportGenerationSchedule
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public DateTime? DateOfGeneration { get; set; }
        public string? Description { get; set; }
        public int? FinYear { get; set; }
        public int? ReportGenerationEnum { get; set; }
    }
}

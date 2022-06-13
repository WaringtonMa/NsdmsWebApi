using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ReportGenerationProperty
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public DateTime? DateGenerationStarted { get; set; }
        public DateTime? DateLastCompleted { get; set; }
        public string? Description { get; set; }
        public ulong? GenerationUnderway { get; set; }
        public int? ReportProperty { get; set; }
        public long? UserStartedGenerationId { get; set; }

        public virtual User? UserStartedGeneration { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class AuditorMonitorReview
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? AccreditationCriteria { get; set; }
        public int? EvidenceRequired { get; set; }
        public string? EvidenceRequirements { get; set; }
        public int? Section { get; set; }
        public long? TrainingProviderMonitoring { get; set; }
        public string? Comment { get; set; }
        public string? ForProcess { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public int? TpAccreditationApplicationType { get; set; }
        public ulong? IsNotRelevant { get; set; }
        public long? AreasForImprovementId { get; set; }
        public int? EvidenceRequiredEvaluatorOutcome { get; set; }

        public virtual AreaForImprovement? AreasForImprovement { get; set; }
        public virtual TrainingProviderMonitoring? TrainingProviderMonitoringNavigation { get; set; }
    }
}

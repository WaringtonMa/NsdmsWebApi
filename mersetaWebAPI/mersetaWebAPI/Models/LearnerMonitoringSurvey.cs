using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LearnerMonitoringSurvey
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? Question { get; set; }
        public int? Section { get; set; }
        public string? WorkplaceSurveyType { get; set; }
        public string? YesNo { get; set; }
        public long? WorkplaceMonitoring { get; set; }

        public virtual WorkplaceMonitoring? WorkplaceMonitoringNavigation { get; set; }
    }
}

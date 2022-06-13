using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class TrainingProviderMonitoring
    {
        public TrainingProviderMonitoring()
        {
            AuditorMonitorReviews = new HashSet<AuditorMonitorReview>();
        }

        public long Id { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? MonitoringDate { get; set; }
        public int? Status { get; set; }
        public long? CompanyId { get; set; }
        public long? UserId { get; set; }
        public ulong? Audit { get; set; }
        public long? InitiatingQaId { get; set; }
        public string? QaComments { get; set; }
        public string? QaRecommendation { get; set; }
        public DateTime? QaDateSubmission { get; set; }
        public DateTime? SpdUserDateSubmission { get; set; }
        public long? QaManagerId { get; set; }
        public long? SpdUserId { get; set; }
        public long? TrainingProviderApplicationId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual User? InitiatingQa { get; set; }
        public virtual User? QaManager { get; set; }
        public virtual User? SpdUser { get; set; }
        public virtual TrainingProviderApplication? TrainingProviderApplication { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<AuditorMonitorReview> AuditorMonitorReviews { get; set; }
    }
}

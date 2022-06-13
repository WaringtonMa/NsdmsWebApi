using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class NonSetaQualificationsCompletion
    {
        public NonSetaQualificationsCompletion()
        {
            SummativeAssessmentReports = new HashSet<SummativeAssessmentReport>();
        }

        public long Id { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Status { get; set; }
        public long? CompanyId { get; set; }
        public long? TrainingProviderId { get; set; }
        public long? SummativeAssessmentReportId { get; set; }
        public long? CompanyLearnersId { get; set; }
        public long? CreateUserId { get; set; }
        public DateTime? ModerationDate { get; set; }
        public DateTime? AchievementDate { get; set; }
        public DateTime? AssessmentDate { get; set; }
        public int? CompetenceEnum { get; set; }

        public virtual Company? Company { get; set; }
        public virtual CompanyLearner? CompanyLearners { get; set; }
        public virtual User? CreateUser { get; set; }
        public virtual SummativeAssessmentReport? SummativeAssessmentReport { get; set; }
        public virtual Company? TrainingProvider { get; set; }
        public virtual ICollection<SummativeAssessmentReport> SummativeAssessmentReports { get; set; }
    }
}

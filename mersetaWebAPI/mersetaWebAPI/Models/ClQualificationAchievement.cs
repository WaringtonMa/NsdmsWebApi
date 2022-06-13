using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ClQualificationAchievement
    {
        public long Id { get; set; }
        public string? AssessmentCentreCode { get; set; }
        public string? AssessmentPartnerCode { get; set; }
        public string? CurrentDateStamp { get; set; }
        public string? EmploymentStatus { get; set; }
        public string? EnrolledSdpCode { get; set; }
        public string? ExpectedTrainingCompletionDate { get; set; }
        public string? Flc { get; set; }
        public string? FlcStatementResultNumber { get; set; }
        public string? LearnerAlternateId { get; set; }
        public string? LearnerEnrolledDate { get; set; }
        public string? LearnerModularAchievementDate { get; set; }
        public string? LearnerModularAchievementTypeId { get; set; }
        public string? LearnerReadinessForEisaTypeId { get; set; }
        public string? LinkedToWorkplace { get; set; }
        public string? ModuleAchievementStatus { get; set; }
        public string? ModuleCode { get; set; }
        public string? NationalId { get; set; }
        public string? QualificationEntryRequirement { get; set; }
        public string? QualificationId { get; set; }
        public string? StatementResultsIssueDate { get; set; }
        public string? StatementResultsStatus { get; set; }
        public long? AdministrationOfAqpLearnersId { get; set; }

        public virtual AdministrationOfApqLearner? AdministrationOfAqpLearners { get; set; }
    }
}

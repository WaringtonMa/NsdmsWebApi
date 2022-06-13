using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class QctoFile02
    {
        public long Id { get; set; }
        public string? AssessmentCentreCode { get; set; }
        public string? AssessmentPartnerCode { get; set; }
        public DateTime? DateStamp { get; set; }
        public string? EmploymentStatus { get; set; }
        public string? EnrolledSdpCode { get; set; }
        public DateTime? ExpectedTrainingCompletionDate { get; set; }
        public string? Flc { get; set; }
        public string? FlcStatementOfResultNumber { get; set; }
        public string? LearnerAlternateId { get; set; }
        public DateTime? LearnerEnrolledDate { get; set; }
        public string? LearnerModularAchievementTypeId { get; set; }
        public string? LearnerReadinessForEisaTypeId { get; set; }
        public DateTime? LearnerModularAchievementDate { get; set; }
        public string? LinkedToWorkplacePointOfEntryQualification { get; set; }
        public string? ModuleAchievementStatus { get; set; }
        public string? ModuleCode { get; set; }
        public string? NationalId { get; set; }
        public string? QualificationEntryRequirementStatus { get; set; }
        public string? QualificationId { get; set; }
        public string? StatementOfResultStatus { get; set; }
        public DateTime? StatementOfResultIssueDate { get; set; }
    }
}

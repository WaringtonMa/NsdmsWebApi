using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class TrainingProviderVerfication
    {
        public TrainingProviderVerfication()
        {
            InverseTrainingProviderVerficationParent = new HashSet<TrainingProviderVerfication>();
            SummativeAssessmentReports = new HashSet<SummativeAssessmentReport>();
            TrainingProviderVerficationLearners = new HashSet<TrainingProviderVerficationLearner>();
        }

        public long Id { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public ulong? AssessmentDone { get; set; }
        public int? CeritificateCollectionEnum { get; set; }
        public string? CertificateNumber { get; set; }
        public ulong? CetificateGenerated { get; set; }
        public DateTime? CetificateGeneratedDate { get; set; }
        public DateTime? CollectionDate { get; set; }
        public int? CollectionType { get; set; }
        public ulong? CompanyModerationDone { get; set; }
        public DateTime? CreateDate { get; set; }
        public ulong? CreatedByMerseta { get; set; }
        public ulong? DateForVisitProvided { get; set; }
        public int? Downloads { get; set; }
        public ulong? ForModeration { get; set; }
        public int? GenerateAddEnum { get; set; }
        public ulong? LearnerModerationDone { get; set; }
        public DateTime? ModerationDate { get; set; }
        public DateTime? ReviewDate { get; set; }
        public int? Status { get; set; }
        public int? VerificationStatus { get; set; }
        public long? CompanyLearnersId { get; set; }
        public long? CreateUserId { get; set; }
        public long? ReviewUserId { get; set; }
        public long? ScheduledEventId { get; set; }
        public long? TrainingProviderId { get; set; }
        public long? TrainingProviderVerficationParentId { get; set; }
        public ulong? CreatedFinalApproval { get; set; }
        public string? SerialNumber { get; set; }

        public virtual CompanyLearner? CompanyLearners { get; set; }
        public virtual User? CreateUser { get; set; }
        public virtual User? ReviewUser { get; set; }
        public virtual ScheduledEvent? ScheduledEvent { get; set; }
        public virtual Company? TrainingProvider { get; set; }
        public virtual TrainingProviderVerfication? TrainingProviderVerficationParent { get; set; }
        public virtual ICollection<TrainingProviderVerfication> InverseTrainingProviderVerficationParent { get; set; }
        public virtual ICollection<SummativeAssessmentReport> SummativeAssessmentReports { get; set; }
        public virtual ICollection<TrainingProviderVerficationLearner> TrainingProviderVerficationLearners { get; set; }
    }
}

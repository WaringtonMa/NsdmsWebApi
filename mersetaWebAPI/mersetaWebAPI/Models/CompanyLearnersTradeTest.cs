using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyLearnersTradeTest
    {
        public CompanyLearnersTradeTest()
        {
            DetailsOfExperienceArpls = new HashSet<DetailsOfExperienceArpl>();
            DetailsOfTrainingArpls = new HashSet<DetailsOfTrainingArpl>();
            TradeTestTaskResults = new HashSet<TradeTestTaskResult>();
        }

        public long Id { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? AttemptNumber { get; set; }
        public int? AttemptedTradeTest { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Flc { get; set; }
        public DateTime? PreviousAttemptDate { get; set; }
        public string? QualificationCode { get; set; }
        public int? Status { get; set; }
        public long? CompanyLearnersId { get; set; }
        public long? PreferredTrainingCenterId { get; set; }
        public long? PreviousTrainingCenterId { get; set; }
        public int? CompetenceEnum { get; set; }
        public DateTime? LearnerReadinessDate { get; set; }
        public DateTime? NambSubmissionDate { get; set; }
        public int? CollectionType { get; set; }
        public string? SerialNumber { get; set; }
        public int? AprlProgressEnum { get; set; }
        public int? ArplReporting { get; set; }
        public ulong? CbmtQualification { get; set; }
        public string? CollectionInformation { get; set; }
        public string? ContractNo { get; set; }
        public string? CurrentEmployerAddress { get; set; }
        public string? CurrentOcc { get; set; }
        public DateTime? DateOfTest { get; set; }
        public string? DetailsOfExperience { get; set; }
        public int? EmployedUnEmployed { get; set; }
        public ulong? FinalCbmtQualification { get; set; }
        public int? LearnerAgreement { get; set; }
        public string? LearnerAgreementNumber { get; set; }
        public DateTime? MaxDate { get; set; }
        public int? MedicalInfo { get; set; }
        public DateTime? MinDate { get; set; }
        public string? NatureMedicalInfo { get; set; }
        public string? Region { get; set; }
        public string? Specialisation { get; set; }
        public ulong? TestCenterSubmitted { get; set; }
        public int? TradeTestProgress { get; set; }
        public int? TradeTestType { get; set; }
        public long? ApprovedUserId { get; set; }
        public long? CreateUserId { get; set; }
        public long? DesignatedTradeLevelId { get; set; }
        public long? LearnerId { get; set; }
        public long? OccupationCategoryId { get; set; }
        public long? OfoCodeId { get; set; }
        public long? QualificationId { get; set; }
        public long? ReleventSetaId { get; set; }
        public ulong? ResultsVerified { get; set; }
        public long? CollectDetailId { get; set; }
        public DateTime? ActualFromDateOfTest { get; set; }
        public DateTime? ActualToDateOfTest { get; set; }
        public ulong? AlterEmployerInfo { get; set; }
        public DateTime? DateOfTestToDate { get; set; }
        public DateTime? DateSetToAwaitingNamb { get; set; }
        public DateTime? DateSubmittedToTestCenter { get; set; }
        public DateTime? DateToProvideOriginalCopies { get; set; }
        public int? Disability { get; set; }
        public string? DisabilityInfo { get; set; }
        public int? EmployerOnNsdms { get; set; }
        public int? EmploymentStatus { get; set; }
        public int? FlcEnglish { get; set; }
        public int? FlcMathsLit { get; set; }
        public int? NambDecision { get; set; }
        public ulong? TestDatesProvided { get; set; }
        public long? AdminUserId { get; set; }
        public long? ClientServiceAdminUserId { get; set; }
        public long? CompanyEmployer { get; set; }
        public long? CoordinatorUserId { get; set; }
        public long? QualityAssurorUserId { get; set; }
        public long? TestCenterUserId { get; set; }
        public DateTime? DateSubmissionOriginalDoc { get; set; }
        public DateTime? DueDateSubmissionOriginalDoc { get; set; }
        public ulong? OnHold { get; set; }
        public long? DisabilityRatingId { get; set; }
        public long? DisabilityStatus { get; set; }
        public long? CompanyProviderId { get; set; }
        public string? AssessorCertificateNumber { get; set; }
        public string? AssessorEmail { get; set; }
        public string? AssessorFirstName { get; set; }
        public string? AssessorLastName { get; set; }
        public string? ModeratorCertificateNumber { get; set; }
        public string? ModeratorEmail { get; set; }
        public string? ModeratorFirstName { get; set; }
        public string? ModeratorLastName { get; set; }
        public long? AssessorEtqaId { get; set; }
        public long? ModeratorEtqaId { get; set; }
        public ulong? CertificateCollected { get; set; }
        public DateTime? DateOfCollection { get; set; }
        public long? TrainingProviderApplicationId { get; set; }
        public string? CertificateNumber { get; set; }
        public DateTime? DateCertified { get; set; }
        public DateTime? NambReceivedDate { get; set; }
        public long? AssessorApplicationId { get; set; }
        public long? ModeratorApplicationId { get; set; }
        public long? LegacySectTwentyEightId { get; set; }
        public long? EmpoyerId { get; set; }

        public virtual User? AdminUser { get; set; }
        public virtual User? ApprovedUser { get; set; }
        public virtual AssessorModeratorApplication? AssessorApplication { get; set; }
        public virtual Etqa? AssessorEtqa { get; set; }
        public virtual User? ClientServiceAdminUser { get; set; }
        public virtual CollectDetail? CollectDetail { get; set; }
        public virtual Company? CompanyEmployerNavigation { get; set; }
        public virtual CompanyLearner? CompanyLearners { get; set; }
        public virtual Company? CompanyProvider { get; set; }
        public virtual User? CoordinatorUser { get; set; }
        public virtual User? CreateUser { get; set; }
        public virtual DesignatedTradeLevel? DesignatedTradeLevel { get; set; }
        public virtual DisabilityRating? DisabilityRating { get; set; }
        public virtual DisabilityStatus? DisabilityStatusNavigation { get; set; }
        public virtual CompanyTradeTestEmployer? Empoyer { get; set; }
        public virtual User? Learner { get; set; }
        public virtual LegacySectTwentyEight? LegacySectTwentyEight { get; set; }
        public virtual AssessorModeratorApplication? ModeratorApplication { get; set; }
        public virtual Etqa? ModeratorEtqa { get; set; }
        public virtual OccupationCategory? OccupationCategory { get; set; }
        public virtual OfoCode? OfoCode { get; set; }
        public virtual Company? PreferredTrainingCenter { get; set; }
        public virtual Company? PreviousTrainingCenter { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual User? QualityAssurorUser { get; set; }
        public virtual Setum? ReleventSeta { get; set; }
        public virtual User? TestCenterUser { get; set; }
        public virtual TrainingProviderApplication? TrainingProviderApplication { get; set; }
        public virtual ICollection<DetailsOfExperienceArpl> DetailsOfExperienceArpls { get; set; }
        public virtual ICollection<DetailsOfTrainingArpl> DetailsOfTrainingArpls { get; set; }
        public virtual ICollection<TradeTestTaskResult> TradeTestTaskResults { get; set; }
    }
}

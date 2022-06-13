using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class QmrArtisanDataHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public string? AccreditationNumberKnowladgeComponent { get; set; }
        public string? AccreditationNumberPracticalComponent { get; set; }
        public int? AgeIndicator { get; set; }
        public string? ArtisanTradeDiscription { get; set; }
        public long? CompanyLearnerFlatLink { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DateLearnerAgreementCancelation { get; set; }
        public DateTime? DateLearnerAgreementCompletion { get; set; }
        public DateTime? DateLearnerAgreementRegistration { get; set; }
        public DateTime? DateLearnerCertification { get; set; }
        public DateTime? DateLearnerDeclaredCompetent { get; set; }
        public DateTime? DateOfBirthNonSaCitizens { get; set; }
        public DateTime? DateTradeTest12And3 { get; set; }
        public ulong? DisabilityIdentified { get; set; }
        public string? DoesTheProgrammeAddressSspNeedsSipSkills { get; set; }
        public int? EmployedUnEmployed { get; set; }
        public string? Gender { get; set; }
        public string? LeadEmployer { get; set; }
        public string? LeadEmployerApprovalNumber { get; set; }
        public string? LeadSkillsDevelopmentProviderKnowladgeComponents { get; set; }
        public string? LeadSkillsDevelopmentProviderPracticalComponents { get; set; }
        public string? LearnerAlternateIdPassportNumber { get; set; }
        public string? LearnerCertificationNumber { get; set; }
        public string? LearnerIdNumber { get; set; }
        public string? LearnerMunicipality { get; set; }
        public string? LearnerName { get; set; }
        public string? LearnerOtherNames { get; set; }
        public string? LearnerPermanentlyEmployed { get; set; }
        public string? LearnerSurname { get; set; }
        public string? OfoCode { get; set; }
        public string? Pwd { get; set; }
        public int? QmrEnteredCompleted { get; set; }
        public int? QmrEquity { get; set; }
        public int? QmrGender { get; set; }
        public string? Race { get; set; }
        public string? ReasonForCancelation { get; set; }
        public string? ReasonForNotYetCompetent { get; set; }
        public string? ReportingPeriod { get; set; }
        public ulong? RsaCitizen { get; set; }
        public string? SaNonSaCitizens { get; set; }
        public string? SetaIdlelaOrPublicFetAcronym { get; set; }
        public int? TradeTest12And3 { get; set; }
        public string? TradeTestAssessorIdNumber { get; set; }
        public string? TradeTestAssessorName { get; set; }
        public string? TradeTestAssessorSurname { get; set; }
        public string? TradeTestCenter { get; set; }
        public string? TradeTestCenterAccreditationNumber { get; set; }
        public string? TradeTestModeratorIdNumber { get; set; }
        public string? TradeTestModeratorName { get; set; }
        public string? TradeTestModeratorSurname { get; set; }
        public long? QmrFinYearsId { get; set; }
        public int? AgeOfLearner { get; set; }
        public string? Disability { get; set; }
        public string? NonRsaCitizen { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

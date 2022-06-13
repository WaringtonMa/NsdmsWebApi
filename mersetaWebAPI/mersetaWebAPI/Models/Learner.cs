using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Learner
    {
        public long Id { get; set; }
        public string? CellNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Email { get; set; }
        public string? FaxNumber { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? PassportNumber { get; set; }
        public string? RsaIdNumber { get; set; }
        public string? TelNumber { get; set; }
        public string? WorkContactNumber { get; set; }
        public long? DisabilityStatus { get; set; }
        public long? DisabledId { get; set; }
        public long? EquityId { get; set; }
        public long? GenderId { get; set; }
        public int? MunicipalityId { get; set; }
        public long? NationalityId { get; set; }
        public long? PostalAddressId { get; set; }
        public long? ResidentialAddressId { get; set; }
        public string? AlternativeIdNumber { get; set; }
        public DateTime CommencementDateLearnershipAgreement { get; set; }
        public string CompletedLearnerAfricanCitizen { get; set; } = null!;
        public string? CompletedLearnerCell { get; set; }
        public DateTime CompletedLearnerDateBirth { get; set; }
        public string? CompletedLearnerEmailAddress { get; set; }
        public string? CompletedLearnerHome { get; set; }
        public string CompletedLearnerHowManyCredits { get; set; } = null!;
        public string CompletedLearnerIfSpecify { get; set; } = null!;
        public string CompletedLearnerNameTheUnion { get; set; } = null!;
        public string CompletedLearnerSpecifyRegistration { get; set; } = null!;
        public string CompletedLearnerStandardGradeLevels { get; set; } = null!;
        public DateTime CompletedLearnerStartWork { get; set; }
        public string? CompletedLearnerWork { get; set; }
        public string CompletedLearnerYesSpecifyTitle { get; set; } = null!;
        public string CompletedLearnerYourHighest { get; set; } = null!;
        public string ConditionsOfEmploymentYes { get; set; } = null!;
        public string DepartmentHigherEducation { get; set; } = null!;
        public string EmployerApplicantCitizen { get; set; } = null!;
        public string EmployerCitizenCertified { get; set; } = null!;
        public DateTime EmployerCommencementDate { get; set; }
        public string EmployerCorrectionsInitialled { get; set; } = null!;
        public string EmployerDesignatedClearly { get; set; } = null!;
        public string EmployerDetailsAreRegistered { get; set; } = null!;
        public string EmployerDetailsContactPerson { get; set; } = null!;
        public string? EmployerDetailsEmail { get; set; }
        public string? EmployerDetailsFax { get; set; }
        public string EmployerDetailsRegisteredEmployer { get; set; } = null!;
        public string EmployerDetailsSdlNo { get; set; } = null!;
        public string EmployerDetailsSic { get; set; } = null!;
        public string? EmployerDetailsTel { get; set; }
        public string EmployerDetailsTradingName { get; set; } = null!;
        public string EmployerFullNames { get; set; } = null!;
        public string EmployerFullNamesApplicant { get; set; } = null!;
        public string EmployerHighestQualification { get; set; } = null!;
        public string? EmployerIdPassport { get; set; }
        public string EmployerInitialledLearnership { get; set; } = null!;
        public string EmployerOriginalAgreements { get; set; } = null!;
        public string EmployerPhysicalAddress { get; set; } = null!;
        public string EmployerTheTrainingLearner { get; set; } = null!;
        public string EmployerTheTrainingLearnerYes { get; set; } = null!;
        public string FullNameSurname { get; set; } = null!;
        public string? LearnerNumberBeSupplied { get; set; }
        public string LearnershipDesignatedTrade { get; set; } = null!;
        public string? ParentGuardianCell { get; set; }
        public string? ParentGuardianEmailAddress { get; set; }
        public string ParentGuardianFullNames { get; set; } = null!;
        public string? ParentGuardianHome { get; set; }
        public string? ParentGuardianIdentityNumber { get; set; }
        public string? ParentGuardianWork { get; set; }
        public string ProviderDetailsContactPerson { get; set; } = null!;
        public string? ProviderDetailsEmail { get; set; }
        public string? ProviderDetailsFax { get; set; }
        public string ProviderDetailsProvider { get; set; } = null!;
        public string ProviderDetailsSdlNo { get; set; } = null!;
        public string ProviderDetailsSeta { get; set; } = null!;
        public string ProviderDetailsSic { get; set; } = null!;
        public string? ProviderDetailsTel { get; set; }
        public string ProviderDetailsTradingName { get; set; } = null!;
        public DateTime TerminationDateLearnershipAgreement { get; set; }
        public string? ContractNumberDate { get; set; }
        public DateTime? EmployerDate { get; set; }
        public string FullNameOfApprentice { get; set; } = null!;
        public string GiveFullDetailsRelationshipStaffMember { get; set; } = null!;
        public string HereInAfterReferredToAsThe { get; set; } = null!;
        public string? IdentityNumberDate { get; set; }
        public string InsertInstitution { get; set; } = null!;
        public DateTime? LastWorkingDayOfApprentice { get; set; }
        public DateTime? LastWorkingDayOfLearner { get; set; }
        public DateTime? LearnershipDate { get; set; }
        public string LearnershipNameOfEmployer { get; set; } = null!;
        public DateTime? LegalGuardianDate { get; set; }
        public DateTime? ManagerDate { get; set; }
        public string NameOfRegisteredCompany { get; set; } = null!;
        public string XxxXxx { get; set; } = null!;
        public DateTime AgreementDate { get; set; }
        public string AgreementGuardian { get; set; } = null!;
        public string ApprenticeApprentice { get; set; } = null!;
        public string? ContractNumberApprentice { get; set; }
        public DateTime? DateApprentice { get; set; }
        public string DesignationEmployer { get; set; } = null!;
        public string? EmailAddressEmployer { get; set; }
        public string HaveAppliedForTheTransferApprentice { get; set; } = null!;
        public string? IdentityNumberApprentice { get; set; }
        public string NameOfContactPersonEmployer { get; set; } = null!;
        public DateTime ObjectionDate { get; set; }
        public string TradeApprentice { get; set; } = null!;
        public string ProofOfPayment { get; set; } = null!;
        public string? AnyOtherLoanGrantDetails { get; set; }
        public string? AnyOtherLoanGrantNo { get; set; }
        public string? AnyOtherLoanGrantYes { get; set; }
        public DateTime ApplicationReceived { get; set; }
        public string? AppropriateNo { get; set; }
        public string? AppropriateYes { get; set; }
        public string AsIndicated { get; set; } = null!;
        public string? AwardAmount1 { get; set; }
        public string? AwardAmount2 { get; set; }
        public string? ByWhichCompany { get; set; }
        public string? CellNoEmployer { get; set; }
        public string? CellNoTrainee { get; set; }
        public string Citizenship { get; set; } = null!;
        public string ClientServices { get; set; } = null!;
        public string ClientServicesAdministrator { get; set; } = null!;
        public DateTime CommencementDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public string? ContractNumberLearner { get; set; }
        public string ContractualLearner { get; set; } = null!;
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public DateTime? Date3 { get; set; }
        public DateTime? Date4 { get; set; }
        public DateTime? Date5 { get; set; }
        public DateTime? DateRegisteredCompany { get; set; }
        public string? DesignationTrainee { get; set; }
        public string? DhetLearnershipRegistrationNumber { get; set; }
        public string? DoLiveTheInstitutionResidence { get; set; }
        public string? EmployedNo { get; set; }
        public string? EmployedYes { get; set; }
        public string? EmployerSignature { get; set; }
        public string? EmployerSigniture { get; set; }
        public string? EmployerWitnesses1 { get; set; }
        public string? EmployerWitnesses2 { get; set; }
        public string EmployereWorkplace { get; set; } = null!;
        public DateTime? ExpectedDateCommencementStudy { get; set; }
        public string? FacultyAndCourse { get; set; }
        public string? FaxNoTrainee { get; set; }
        public string? FaxNumberEmployer { get; set; }
        public string? FirstNamesTrainee { get; set; }
        public string? FullNameLearner { get; set; }
        public string? GenderTickWhichever { get; set; }
        public string? GuardianSigniture { get; set; }
        public string? GuardianWitnesses1 { get; set; }
        public string? GuardianWitnesses2 { get; set; }
        public DateTime HerebyTransferredThisDayOf { get; set; }
        public string? HigherNameOfCourse1 { get; set; }
        public string? HigherNameOfCourse2 { get; set; }
        public string? HigherNameOfCourse3 { get; set; }
        public string? HigherNameOfCourse4 { get; set; }
        public string? HigherNameOfUniversity1 { get; set; }
        public string? HigherNameOfUniversity2 { get; set; }
        public string? HigherNameOfUniversity3 { get; set; }
        public string? HigherNameOfUniversity4 { get; set; }
        public DateTime? HigherYearsFrom1 { get; set; }
        public DateTime? HigherYearsFrom2 { get; set; }
        public DateTime? HigherYearsFrom3 { get; set; }
        public DateTime? HigherYearsFrom4 { get; set; }
        public DateTime? HigherYearsTo1 { get; set; }
        public DateTime? HigherYearsTo2 { get; set; }
        public DateTime? HigherYearsTo3 { get; set; }
        public DateTime? HigherYearsTo4 { get; set; }
        public string? HigherResults1 { get; set; }
        public string? HigherResults2 { get; set; }
        public string? HigherResults3 { get; set; }
        public string? HigherResults4 { get; set; }
        public string HighestQualification { get; set; } = null!;
        public string? HomeLanguage { get; set; }
        public string? IdNoRegisteredCompany { get; set; }
        public DateTime? ImmediateRecognitionFrom1 { get; set; }
        public DateTime? ImmediateRecognitionFrom2 { get; set; }
        public DateTime? ImmediateRecognitionFrom3 { get; set; }
        public string? ImmediateRecognitionPosition1 { get; set; }
        public string? ImmediateRecognitionPosition2 { get; set; }
        public string? ImmediateRecognitionPosition3 { get; set; }
        public string? ImmediateRecognitionTasksPerformed1 { get; set; }
        public string? ImmediateRecognitionTasksPerformed2 { get; set; }
        public string? ImmediateRecognitionTasksPerformed3 { get; set; }
        public DateTime? ImmediateRecognitionTo1 { get; set; }
        public DateTime? ImmediateRecognitionTo2 { get; set; }
        public DateTime? ImmediateRecognitionTo3 { get; set; }
        public string? InstitutionPreviouslyNo { get; set; }
        public string? InstitutionPreviouslyYes { get; set; }
        public string? Learner1 { get; set; }
        public string? LearnerCelNo { get; set; }
        public DateTime? LearnerDate { get; set; }
        public string? LearnerRsaIdNumber { get; set; }
        public string? LearnerSigniture { get; set; }
        public string? LearnerTelephone { get; set; }
        public string? LearnerWitnesses1 { get; set; }
        public string? LearnerWitnesses2 { get; set; }
        public string? LearnershipSignature { get; set; }
        public string LegalNameOfEmployer { get; set; } = null!;
        public string? LoansGrantsBursariesNo { get; set; }
        public string? LoansGrantsBursariesYes { get; set; }
        public DateTime? MonthAndYearObtained { get; set; }
        public string? NameCompanyWhereEmployed { get; set; }
        public string? NameOfApplicant { get; set; }
        public string? NameOfAward1 { get; set; }
        public string? NameOfAward2 { get; set; }
        public string? NameOfCertificate { get; set; }
        public string? NameOfCompanyA1 { get; set; }
        public string? NameOfCompanyA2 { get; set; }
        public string? NameOfCompanyA3 { get; set; }
        public string? NameOfContactPersonTrainee { get; set; }
        public string? NameOfCourse { get; set; }
        public string NameOfEmployer { get; set; } = null!;
        public string? NameOfSchool1 { get; set; }
        public string? NameOfSchool2 { get; set; }
        public string? NameOfSchool3 { get; set; }
        public string? NameOfSetaRegisteredAt { get; set; }
        public string NameSkillsProgrammeRegisteredFor { get; set; } = null!;
        public string NameOfTrainingProvider { get; set; } = null!;
        public string? NameOfUniversity { get; set; }
        public string? NameUniversityWhichWillTaken { get; set; }
        public string? NewEmployerSigniture { get; set; }
        public string? NewEmployerWitnesses1 { get; set; }
        public string? NewEmployerWitnesses2 { get; set; }
        public string? NumberSistersCompletingFinancially { get; set; }
        public string? ObjectionPresentEmployer { get; set; }
        public DateTime OfficeThisDayOf { get; set; }
        public string? OtherLanguage1 { get; set; }
        public string? OtherLanguage2 { get; set; }
        public string? PositionHeldA1 { get; set; }
        public string? PositionHeldA2 { get; set; }
        public string? PositionHeldA3 { get; set; }
        public string PreferToBeTested { get; set; } = null!;
        public string ProjectAndCodeLinkedTo { get; set; } = null!;
        public string? ProposedCourseOfStudy { get; set; }
        public DateTime? ProviderDate { get; set; }
        public string? ProviderSignature { get; set; }
        public string? QualificationSaqaId { get; set; }
        public string? RaceTickWhichever { get; set; }
        public string? RegisteredCompanySignature { get; set; }
        public string RegistrationCodeOfSkillsProgrammeRegistered { get; set; } = null!;
        public string? Results1 { get; set; }
        public string? Results2 { get; set; }
        public string? Results3 { get; set; }
        public string? Results4 { get; set; }
        public string? Results5 { get; set; }
        public string SaqaUnitStandardCode { get; set; } = null!;
        public string SaqaUnitStandardCode1 { get; set; } = null!;
        public string SaqaUnitStandardCode2 { get; set; } = null!;
        public string SaqaUnitStandardCode3 { get; set; } = null!;
        public string SaqaUnitStandardCode4 { get; set; } = null!;
        public string SaqaUnitStandardTitle { get; set; } = null!;
        public string SaqaUnitStandardTitle1 { get; set; } = null!;
        public string SaqaUnitStandardTitle2 { get; set; } = null!;
        public string SaqaUnitStandardTitle3 { get; set; } = null!;
        public string SaqaUnitStandardTitle4 { get; set; } = null!;
        public string SarsLevyNoEmployer { get; set; } = null!;
        public string? SarsLevyRegistrationNumber { get; set; }
        public string? SchoolActivities1 { get; set; }
        public string? SchoolActivities2 { get; set; }
        public string? SetaNumberToWhichAffiliated { get; set; }
        public DateTime? StartingDateWithCompany { get; set; }
        public string? GerAddress1 { get; set; }
        public string? GerAddress2 { get; set; }
        public string? GerAddress3 { get; set; }
        public string? GerArea { get; set; }
        public int? GerProvinceId { get; set; }
        public string? GerPostal { get; set; }
        public string? GerTitle { get; set; }
        public string? GerMiddleName { get; set; }
        public string? GerMaiden { get; set; }
        public string? GerPostal1 { get; set; }
        public string? GerPostal2 { get; set; }
        public string? GerPostal3 { get; set; }
        public string? GerPostalcode { get; set; }
        public ulong? GerPostalIsSame { get; set; }
        public string? GerResidency { get; set; }
        public string? GerNextOfKin { get; set; }
        public string? GerNextOfKinPhone { get; set; }

        public virtual DisabilityStatus? DisabilityStatusNavigation { get; set; }
        public virtual YesNoLookup? Disabled { get; set; }
        public virtual Equity? Equity { get; set; }
        public virtual Gender? Gender { get; set; }
        public virtual Municipality? Municipality { get; set; }
        public virtual Nationality? Nationality { get; set; }
        public virtual Address? PostalAddress { get; set; }
        public virtual Address? ResidentialAddress { get; set; }
    }
}

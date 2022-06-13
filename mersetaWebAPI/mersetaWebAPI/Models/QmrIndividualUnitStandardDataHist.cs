using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class QmrIndividualUnitStandardDataHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? ActualStartDateOfTheLearningProgramme { get; set; }
        public int? AgeIndicator { get; set; }
        public int? AgeOfLearner { get; set; }
        public double? AmountSpentPerLearner { get; set; }
        public long? CompanyLearnerFlatLink { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DateRecivedCertificateLearningProgramme { get; set; }
        public DateTime? DateTheLearnerCompletedTheLearningProgramme { get; set; }
        public DateTime? DateTheLearnerEnteredTheLearningProgramme { get; set; }
        public string? Disability { get; set; }
        public ulong? DisabilityIdentified { get; set; }
        public int? EmployedUnEmployed { get; set; }
        public string? EmployerContactDetails { get; set; }
        public string? EmployerRegistartionSdlNumber { get; set; }
        public string? Gender { get; set; }
        public string? IdNumberOfTheLearner { get; set; }
        public string? IsTheLearnerResidentialAreaUrbanRural { get; set; }
        public string? IsTheProgrammeSetaIndustryFunded { get; set; }
        public string? IsTrainingProviderPrivatePublic { get; set; }
        public string? LearnerLocalDistrictMunciplaity { get; set; }
        public string? LearnerProvince { get; set; }
        public string? NameOfTheEmployer { get; set; }
        public string? NameOfTheTraingProvider { get; set; }
        public string? NamesOfTheLearner { get; set; }
        public string? NonRsaCitizen { get; set; }
        public string? NqfLevel { get; set; }
        public string? OfoCode { get; set; }
        public int? QmrEnteredCompleted { get; set; }
        public int? QmrEquity { get; set; }
        public int? QmrGender { get; set; }
        public string? QualificationAsPerOfoCodeDesctiptionOfTheQualification { get; set; }
        public string? Race { get; set; }
        public string? ReportingPeriod { get; set; }
        public ulong? RsaCitizen { get; set; }
        public string? SpecifyLearnerResidentialArea { get; set; }
        public string? SurnameOfTheLearner { get; set; }
        public string? TrainingProviderAccrediciationNumber { get; set; }
        public string? TrainingProviderContactDetails { get; set; }
        public string? TypeOfLearningProgramme { get; set; }
        public string? Youth { get; set; }
        public long? QmrFinYearsId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

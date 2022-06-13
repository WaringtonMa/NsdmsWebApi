using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class QmrUniversityStudentDatum
    {
        public long Id { get; set; }
        public int? AgeIndicator { get; set; }
        public int? AgeOfLearner { get; set; }
        public string? AmountSpentPerLearner { get; set; }
        public long? CompanyLearnerFlatLink { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Disability { get; set; }
        public ulong? DisabilityIdentified { get; set; }
        public string? DurationOfPlacementReflectsStartAndEndDates { get; set; }
        public int? EmployedUnEmployed { get; set; }
        public string? EmployerContactDetails { get; set; }
        public string? EmployerRegistartionSdlNumber { get; set; }
        public string? Gender { get; set; }
        public string? IdNumberOfTheLearner { get; set; }
        public string? IsTheLearnerResidentialAreaUrbanRural { get; set; }
        public string? IsTheProgrammeSetaIndustryFunded { get; set; }
        public string? LearnerLocalDistrictMunciplaity { get; set; }
        public string? LearnerProvince { get; set; }
        public string? NameOfInstetution { get; set; }
        public string? NameOfTheEmployer { get; set; }
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
        public string? Youth { get; set; }
        public long? QmrFinYearsId { get; set; }
        public DateTime? StartDate { get; set; }

        public virtual QmrFinYear? QmrFinYears { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class MandatoryGrantDetailArchive
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Disability { get; set; }
        public int? EmploymentStatus { get; set; }
        public string? EmploymentTypeCode { get; set; }
        public DateTime? EndDate { get; set; }
        public string? EnrolmentStatusCode { get; set; }
        public string? EquityCode { get; set; }
        public double? EstimatedCost { get; set; }
        public string? FirstName { get; set; }
        public string? FundingCode { get; set; }
        public string? GenderCode { get; set; }
        public long IdMandatoryGrantDetail { get; set; }
        public string? IdNumber { get; set; }
        public int? IdType { get; set; }
        public int? IdTypeCode { get; set; }
        public ulong? ImportError { get; set; }
        public string? ImportErrors { get; set; }
        public ulong? Imported { get; set; }
        public string? InterventionTitle { get; set; }
        public string? InterventionTypeCode { get; set; }
        public string? LastName { get; set; }
        public DateTime? MandatoryGrantDetailCreateDate { get; set; }
        public string? NationalityCode { get; set; }
        public string? OfoCode { get; set; }
        public int? PivotNonPivot { get; set; }
        public string? ProviderTypeCode { get; set; }
        public int? QualificationCode { get; set; }
        public string? SkillsProgramCode { get; set; }
        public string? SkillsSetCode { get; set; }
        public string? SpecialisationCode { get; set; }
        public DateTime? StartDate { get; set; }
        public string? TrainingDeliveryMethodCode { get; set; }
        public int? WspReport { get; set; }
        public long? DisabilityId { get; set; }
        public long? EmploymentTypeId { get; set; }
        public long? EnrolmentStatus { get; set; }
        public long? EquityId { get; set; }
        public long? EtqaId { get; set; }
        public long? FundingId { get; set; }
        public long? GenderId { get; set; }
        public long? InterventionLevelId { get; set; }
        public long? InterventionTypeId { get; set; }
        public int? MunicipalityId { get; set; }
        public long? NationalityId { get; set; }
        public long? NonCreditBearingIntervationTitleId { get; set; }
        public long? NqfAlignedId { get; set; }
        public long? NqfLevelsId { get; set; }
        public long? OfoCodeId { get; set; }
        public long? ProviderTypeId { get; set; }
        public long? QualificationId { get; set; }
        public long? SkillsProgramId { get; set; }
        public long? SkillsSetId { get; set; }
        public long? TrainingId { get; set; }
        public long? TrainingDeliveryMethodId { get; set; }
        public long? UnitStandardId { get; set; }
        public long? WspId { get; set; }
        public int? RsaCitizenType { get; set; }
        public string? MunicipalityCode { get; set; }
        public string? NonCreditBearingIntervationTitleCode { get; set; }

        public virtual DisabilityStatus? DisabilityNavigation { get; set; }
        public virtual EmploymentType? EmploymentType { get; set; }
        public virtual EnrolmentStatus? EnrolmentStatusNavigation { get; set; }
        public virtual Equity? Equity { get; set; }
        public virtual Etqa? Etqa { get; set; }
        public virtual Funding? Funding { get; set; }
        public virtual Gender? Gender { get; set; }
        public virtual InterventionLevel? InterventionLevel { get; set; }
        public virtual InterventionType? InterventionType { get; set; }
        public virtual Municipality? Municipality { get; set; }
        public virtual Nationality? Nationality { get; set; }
        public virtual NonCreditBearingIntervationTitle? NonCreditBearingIntervationTitle { get; set; }
        public virtual YesNoLookup? NqfAligned { get; set; }
        public virtual NqfLevel? NqfLevels { get; set; }
        public virtual OfoCode? OfoCodeNavigation { get; set; }
        public virtual ProviderType? ProviderType { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual SkillsProgram? SkillsProgram { get; set; }
        public virtual SkillsSet? SkillsSet { get; set; }
        public virtual training? Training { get; set; }
        public virtual TrainingDeliveryMethod? TrainingDeliveryMethod { get; set; }
        public virtual SaqaUnitstandard? UnitStandard { get; set; }
        public virtual Wsp? Wsp { get; set; }
    }
}

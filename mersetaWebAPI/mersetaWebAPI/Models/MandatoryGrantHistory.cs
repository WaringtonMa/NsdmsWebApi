using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class MandatoryGrantHistory
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public long? AfricanFemale { get; set; }
        public long? AfricanFemaleDisability { get; set; }
        public long? AfricanMale { get; set; }
        public long? AfricanMaleDisability { get; set; }
        public int? Quantity { get; set; }
        public long? ColouredFemale { get; set; }
        public long? ColouredFemaleDisability { get; set; }
        public long? ColouredMale { get; set; }
        public long? ColouredMaleDisability { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? DisabledAmount { get; set; }
        public long? EmployeeAge18 { get; set; }
        public long? EmployeeAge25 { get; set; }
        public long? EmployeeAge35 { get; set; }
        public long? EmployeeAge45 { get; set; }
        public long? EmployeeAge55 { get; set; }
        public long? EmployeeAge65 { get; set; }
        public int? EmploymentStatus { get; set; }
        public int? EmploymentStatusCode { get; set; }
        public DateTime? EndDate { get; set; }
        public double? EstimatedCost { get; set; }
        public string? FundingCode { get; set; }
        public ulong? ImportError { get; set; }
        public string? ImportErrors { get; set; }
        public ulong? Imported { get; set; }
        public long? IndianFemale { get; set; }
        public long? IndianFemaleDisability { get; set; }
        public long? IndianMale { get; set; }
        public long? IndianMaleDisability { get; set; }
        public string? InterventionTitle { get; set; }
        public string? InterventionTypeCode { get; set; }
        public string? OfoCode { get; set; }
        public int? PivotNonPivot { get; set; }
        public string? ProviderTypeCode { get; set; }
        public int? QualificationCode { get; set; }
        public DateTime? StartDate { get; set; }
        public string? TrainingDeliveryMethodCode { get; set; }
        public long? WhiteFemale { get; set; }
        public long? WhiteFemaleDisability { get; set; }
        public long? WhiteMale { get; set; }
        public long? WhiteMaleDisability { get; set; }
        public int? WspReport { get; set; }
        public long? EtqaId { get; set; }
        public long? FundingId { get; set; }
        public long? InterventionLevelId { get; set; }
        public long? InterventionTypeId { get; set; }
        public int? MunicipalityId { get; set; }
        public long? NqfAlignedId { get; set; }
        public long? NqfLevelsId { get; set; }
        public long? OfoCodeId { get; set; }
        public long? ProviderTypeId { get; set; }
        public long? QualificationId { get; set; }
        public long? SkillsProgramId { get; set; }
        public long? SkillsSetId { get; set; }
        public long? TrainingId { get; set; }
        public long? TrainingDeliveryMethodId { get; set; }
        public long? WspId { get; set; }
        public long? NonCreditBearingIntervationTitleId { get; set; }
        public long? UnitStandardId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

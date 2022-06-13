using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class MandatoryGrant
    {
        public MandatoryGrant()
        {
            DgAllocations = new HashSet<DgAllocation>();
            DgVerificationSites = new HashSet<DgVerificationSite>();
            MandatoryGrantRecommendations = new HashSet<MandatoryGrantRecommendation>();
            MandatoryGrantWorkplaces = new HashSet<MandatoryGrantWorkplace>();
            WorkPlaceApprovals = new HashSet<WorkPlaceApproval>();
        }

        public long Id { get; set; }
        public int? AgeGroup { get; set; }
        public int? Quantity { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? PivotNonPivot { get; set; }
        public long? DisabilityStatusId { get; set; }
        public long? EquityId { get; set; }
        public long? GenderId { get; set; }
        public long? OfoCodeId { get; set; }
        public long? WspId { get; set; }
        public long? AfricanFemale { get; set; }
        public long? AfricanFemaleDisability { get; set; }
        public long? AfricanMale { get; set; }
        public long? AfricanMaleDisability { get; set; }
        public long? ColouredFemale { get; set; }
        public long? ColouredFemaleDisability { get; set; }
        public long? ColouredMale { get; set; }
        public long? ColouredMaleDisability { get; set; }
        public long? EmployeeAge18 { get; set; }
        public long? EmployeeAge25 { get; set; }
        public long? EmployeeAge35 { get; set; }
        public long? EmployeeAge45 { get; set; }
        public long? EmployeeAge55 { get; set; }
        public long? EmployeeAge65 { get; set; }
        public long? IndianFemale { get; set; }
        public long? IndianFemaleDisability { get; set; }
        public long? IndianMale { get; set; }
        public long? IndianMaleDisability { get; set; }
        public long? WhiteFemale { get; set; }
        public long? WhiteFemaleDisability { get; set; }
        public long? WhiteMale { get; set; }
        public long? WhiteMaleDisability { get; set; }
        public int? EmploymentStatus { get; set; }
        public DateTime? EndDate { get; set; }
        public double? EstimatedCost { get; set; }
        public string? InterventionTitle { get; set; }
        public DateTime? StartDate { get; set; }
        public int? WspReport { get; set; }
        public long? EtqaId { get; set; }
        public long? FundingId { get; set; }
        public long? InterventionLevelId { get; set; }
        public long? InterventionTypeId { get; set; }
        public int? MunicipalityId { get; set; }
        public long? NqfAlignedId { get; set; }
        public long? NqfLevelsId { get; set; }
        public long? ProviderTypeId { get; set; }
        public long? QualificationId { get; set; }
        public long? TrainingId { get; set; }
        public long? TrainingDeliveryMethodId { get; set; }
        public int? DisabledAmount { get; set; }
        public int? EmploymentStatusCode { get; set; }
        public string? FundingCode { get; set; }
        public ulong? Imported { get; set; }
        public string? InterventionTypeCode { get; set; }
        public string? OfoCode { get; set; }
        public string? ProviderTypeCode { get; set; }
        public int? QualificationCode { get; set; }
        public string? TrainingDeliveryMethodCode { get; set; }
        public ulong? ImportError { get; set; }
        public string? ImportErrors { get; set; }
        public long? SkillsProgramId { get; set; }
        public long? SkillsSetId { get; set; }
        public long? NonCreditBearingIntervationTitleId { get; set; }
        public long? UnitStandardId { get; set; }

        public virtual DisabilityStatus? DisabilityStatus { get; set; }
        public virtual Equity? Equity { get; set; }
        public virtual Etqa? Etqa { get; set; }
        public virtual Funding? Funding { get; set; }
        public virtual Gender? Gender { get; set; }
        public virtual InterventionLevel? InterventionLevel { get; set; }
        public virtual InterventionType? InterventionType { get; set; }
        public virtual Municipality? Municipality { get; set; }
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
        public virtual ICollection<DgAllocation> DgAllocations { get; set; }
        public virtual ICollection<DgVerificationSite> DgVerificationSites { get; set; }
        public virtual ICollection<MandatoryGrantRecommendation> MandatoryGrantRecommendations { get; set; }
        public virtual ICollection<MandatoryGrantWorkplace> MandatoryGrantWorkplaces { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovals { get; set; }
    }
}

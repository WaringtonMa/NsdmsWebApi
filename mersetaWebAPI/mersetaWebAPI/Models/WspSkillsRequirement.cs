using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WspSkillsRequirement
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? JobTitle { get; set; }
        public int? PastFutureEnum { get; set; }
        public long? TotalNeededStaff { get; set; }
        public long? TotalOutsourcedSkills { get; set; }
        public long? TotalVacancies { get; set; }
        public long? InterventionTypeId { get; set; }
        public long? OccupationCategoryId { get; set; }
        public long? OfoCodesId { get; set; }
        public long? ScarcityReasonId { get; set; }
        public long? WspId { get; set; }
        public long? YesNoId { get; set; }
        public long? TotalVacanciesFilled { get; set; }
        public long? NoHardToFillVacanciesId { get; set; }
        public long? QualificationId { get; set; }
        public long? VacancyReasonsId { get; set; }
        public long? HighestQualificationRequiredId { get; set; }

        public virtual HighestQualificationRequired? HighestQualificationRequired { get; set; }
        public virtual InterventionType? InterventionType { get; set; }
        public virtual NoHardToFillVacancy? NoHardToFillVacancies { get; set; }
        public virtual OccupationCategory? OccupationCategory { get; set; }
        public virtual OfoCode? OfoCodes { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual ScarcityReason? ScarcityReason { get; set; }
        public virtual VacancyReason? VacancyReasons { get; set; }
        public virtual Wsp? Wsp { get; set; }
        public virtual YesNoLookup? YesNo { get; set; }
    }
}

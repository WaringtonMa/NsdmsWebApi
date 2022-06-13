using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class MgVerificationDetail
    {
        public long Id { get; set; }
        public string? ActionPlan { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? FinalFin { get; set; }
        public int? NoLearnersCompleted { get; set; }
        public int? NoLearnersStarted { get; set; }
        public int? NoLearnersWithdrawn { get; set; }
        public long? NoPlannedLearners { get; set; }
        public string? Note { get; set; }
        public DateTime? ResetDate { get; set; }
        public long? CompanyId { get; set; }
        public long? DeviationReasonId { get; set; }
        public long? MandatoryGrantDetailId { get; set; }
        public ulong? EvidanceRequired { get; set; }
        public int? Quantity { get; set; }
        public int? DisabledAmount { get; set; }
        public int? EmploymentStatus { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartDate { get; set; }
        public long? EnrolmentStatus { get; set; }
        public long? InterventionLevelId { get; set; }
        public long? InterventionTypeId { get; set; }
        public long? NonCreditBearingIntervationTitleId { get; set; }
        public long? NqfAlignedId { get; set; }
        public long? NqfLevelsId { get; set; }
        public long? OfoCodeId { get; set; }
        public long? ProviderTypeId { get; set; }
        public long? QualificationId { get; set; }
        public long? SkillsProgramId { get; set; }
        public long? SkillsSetId { get; set; }
        public long? UnitStandardId { get; set; }
        public long? WspId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual DeviationReason? DeviationReason { get; set; }
        public virtual EnrolmentStatus? EnrolmentStatusNavigation { get; set; }
        public virtual InterventionLevel? InterventionLevel { get; set; }
        public virtual InterventionType? InterventionType { get; set; }
        public virtual MandatoryGrantDetail? MandatoryGrantDetail { get; set; }
        public virtual NonCreditBearingIntervationTitle? NonCreditBearingIntervationTitle { get; set; }
        public virtual YesNoLookup? NqfAligned { get; set; }
        public virtual NqfLevel? NqfLevels { get; set; }
        public virtual OfoCode? OfoCode { get; set; }
        public virtual ProviderType? ProviderType { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual SkillsProgram? SkillsProgram { get; set; }
        public virtual SkillsSet? SkillsSet { get; set; }
        public virtual SaqaUnitstandard? UnitStandard { get; set; }
        public virtual Wsp? Wsp { get; set; }
    }
}

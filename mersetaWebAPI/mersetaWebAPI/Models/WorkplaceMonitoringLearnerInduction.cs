using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkplaceMonitoringLearnerInduction
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastActionDate { get; set; }
        public int? NumberOfAttendees { get; set; }
        public int? QualificationTypeSelection { get; set; }
        public ulong? SystemGenerated { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? LastActionUser { get; set; }
        public long? LearnershipId { get; set; }
        public long? NonCreditBearingIntervationTitleId { get; set; }
        public long? QualificationId { get; set; }
        public long? SkillsProgramId { get; set; }
        public long? SkillsSetId { get; set; }
        public long? UnitStandardId { get; set; }

        public virtual User? LastActionUserNavigation { get; set; }
        public virtual Learnership? Learnership { get; set; }
        public virtual NonCreditBearingIntervationTitle? NonCreditBearingIntervationTitle { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual SkillsProgram? SkillsProgram { get; set; }
        public virtual SkillsSet? SkillsSet { get; set; }
        public virtual SaqaUnitstandard? UnitStandard { get; set; }
    }
}

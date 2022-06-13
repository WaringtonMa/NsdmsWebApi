using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkplaceMonitoringLearnerInductionHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
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

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

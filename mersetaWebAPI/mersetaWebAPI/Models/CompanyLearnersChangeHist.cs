using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyLearnersChangeHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? CommencmentDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? LearnerChangeTypeEnum { get; set; }
        public int? Status { get; set; }
        public long? CompanyLearnersId { get; set; }
        public long? QualificationId { get; set; }
        public long? SkillsProgramId { get; set; }
        public long? SkillsSetId { get; set; }
        public long? UnitStandardId { get; set; }
        public long? ApprovalUserId { get; set; }
        public long? CreateUserId { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string? NonCredidBearingDescription { get; set; }
        public long? TrainingProviderApplicationId { get; set; }
        public int? LearnerStatus { get; set; }
        public long? LearnershipId { get; set; }
        public int? CreatedByEnum { get; set; }
        public int? SignoffByEnum { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

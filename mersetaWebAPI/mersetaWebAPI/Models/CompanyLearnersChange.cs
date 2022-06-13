using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyLearnersChange
    {
        public long Id { get; set; }
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

        public virtual User? ApprovalUser { get; set; }
        public virtual CompanyLearner? CompanyLearners { get; set; }
        public virtual User? CreateUser { get; set; }
        public virtual Learnership? Learnership { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual SkillsProgram? SkillsProgram { get; set; }
        public virtual SkillsSet? SkillsSet { get; set; }
        public virtual TrainingProviderApplication? TrainingProviderApplication { get; set; }
        public virtual SaqaUnitstandard? UnitStandard { get; set; }
    }
}

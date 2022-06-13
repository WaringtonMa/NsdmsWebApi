using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyProviderApplicationAlterationAudit
    {
        public LegacyProviderApplicationAlterationAudit()
        {
            InverseLegacyProviderApplicationAlterationAuditNavigation = new HashSet<LegacyProviderApplicationAlterationAudit>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? QualificationTypeSelection { get; set; }
        public string? ReasonForAlteration { get; set; }
        public int? RefNumber { get; set; }
        public long? CompanyId { get; set; }
        public long? LearnershipId { get; set; }
        public long? LegacyProviderAccreditationId { get; set; }
        public long? LegacyProviderApplicationAlterationAuditId { get; set; }
        public long? QualificationId { get; set; }
        public long? SkillsProgramId { get; set; }
        public long? SkillsSetId { get; set; }
        public long? TrainingProviderApplicationId { get; set; }
        public long? UnitStandardId { get; set; }
        public long? UserId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual Learnership? Learnership { get; set; }
        public virtual LegacyProviderAccreditation? LegacyProviderAccreditation { get; set; }
        public virtual LegacyProviderApplicationAlterationAudit? LegacyProviderApplicationAlterationAuditNavigation { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual SkillsProgram? SkillsProgram { get; set; }
        public virtual SkillsSet? SkillsSet { get; set; }
        public virtual TrainingProviderApplication? TrainingProviderApplication { get; set; }
        public virtual SaqaUnitstandard? UnitStandard { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<LegacyProviderApplicationAlterationAudit> InverseLegacyProviderApplicationAlterationAuditNavigation { get; set; }
    }
}

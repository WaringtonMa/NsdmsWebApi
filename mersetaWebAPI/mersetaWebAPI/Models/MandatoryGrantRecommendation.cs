using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class MandatoryGrantRecommendation
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Quantity { get; set; }
        public long? MandatoryGrantId { get; set; }
        public long? QualificationId { get; set; }
        public long? RecommendingUserId { get; set; }
        public long? MandatoryGrantDetailId { get; set; }
        public long? RejectReasonsId { get; set; }
        public long? InterventionTypeId { get; set; }
        public long? NonCreditBearingIntervationTitleId { get; set; }
        public long? SkillsProgramId { get; set; }
        public long? SkillsSetId { get; set; }
        public long? UnitStandardsId { get; set; }

        public virtual InterventionType? InterventionType { get; set; }
        public virtual MandatoryGrant? MandatoryGrant { get; set; }
        public virtual MandatoryGrantDetail? MandatoryGrantDetail { get; set; }
        public virtual NonCreditBearingIntervationTitle? NonCreditBearingIntervationTitle { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual User? RecommendingUser { get; set; }
        public virtual RejectReason? RejectReasons { get; set; }
        public virtual SkillsProgram? SkillsProgram { get; set; }
        public virtual SkillsSet? SkillsSet { get; set; }
        public virtual SaqaUnitstandard? UnitStandards { get; set; }
    }
}

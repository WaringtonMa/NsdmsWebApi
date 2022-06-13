using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class MandatoryGrantRecommendationHistory
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Quantity { get; set; }
        public long? InterventionTypeId { get; set; }
        public long? MandatoryGrantId { get; set; }
        public long? QualificationId { get; set; }
        public long? RecommendingUserId { get; set; }
        public long? RejectReasonsId { get; set; }
        public long? NonCreditBearingIntervationTitleId { get; set; }
        public long? SkillsProgramId { get; set; }
        public long? SkillsSetId { get; set; }
        public long? UnitStandardsId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class StakeholderRelation
    {
        public StakeholderRelation()
        {
            StakeholderRelationsSurveys = new HashSet<StakeholderRelationsSurvey>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? AdditionalComment { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public string? Description { get; set; }
        public long? StakeholderRelationsFlatId { get; set; }
        public string? RelationTypeEnum { get; set; }
        public long? UserId { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<StakeholderRelationsSurvey> StakeholderRelationsSurveys { get; set; }
    }
}

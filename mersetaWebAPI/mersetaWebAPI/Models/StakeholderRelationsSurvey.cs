using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class StakeholderRelationsSurvey
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? Description { get; set; }
        public ulong? NotAtAll { get; set; }
        public ulong? NotReally { get; set; }
        public ulong? Nuetral { get; set; }
        public string? RatingEnum { get; set; }
        public ulong? ToaLargeExtent { get; set; }
        public ulong? ToaLimitedExtent { get; set; }
        public long? StakeholderRelationsId { get; set; }
        public long? UserId { get; set; }

        public virtual StakeholderRelation? StakeholderRelations { get; set; }
        public virtual User? User { get; set; }
    }
}

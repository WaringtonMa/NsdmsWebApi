using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class UserQualification
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Note { get; set; }
        public ulong? SoftDelete { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? ForAssessorModeratorApplicationId { get; set; }
        public long? QualificationId { get; set; }
        public long? QualificationTypeId { get; set; }
        public long? UserId { get; set; }
        public ulong? Accept { get; set; }
        public ulong? QualificationUpdated { get; set; }
        public DateTime? ExpirtyDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? UpdateUserId { get; set; }

        public virtual AssessorModeratorApplication? ForAssessorModeratorApplication { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual QualificationType? QualificationType { get; set; }
        public virtual User? UpdateUser { get; set; }
        public virtual User? User { get; set; }
    }
}

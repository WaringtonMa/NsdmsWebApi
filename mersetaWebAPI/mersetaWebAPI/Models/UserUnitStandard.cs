using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class UserUnitStandard
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Note { get; set; }
        public ulong? SoftDelete { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? ForAssessorModeratorApplicationId { get; set; }
        public long? UnitStandardId { get; set; }
        public long? UserId { get; set; }
        public ulong? Accept { get; set; }
        public long? ForQualificationId { get; set; }

        public virtual AssessorModeratorApplication? ForAssessorModeratorApplication { get; set; }
        public virtual SaqaQualification? ForQualification { get; set; }
        public virtual SaqaUnitstandard? UnitStandard { get; set; }
        public virtual User? User { get; set; }
    }
}

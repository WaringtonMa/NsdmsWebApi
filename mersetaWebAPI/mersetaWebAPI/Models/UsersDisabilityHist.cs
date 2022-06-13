using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class UsersDisabilityHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? DisabilityRatingId { get; set; }
        public long? DisabilityStatus { get; set; }
        public long? UpdateUserId { get; set; }
        public long? UserId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

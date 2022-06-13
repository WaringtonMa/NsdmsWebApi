using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class UsersDisability
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? DisabilityRatingId { get; set; }
        public long? DisabilityStatus { get; set; }
        public long? UserId { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? UpdateUserId { get; set; }

        public virtual DisabilityRating? DisabilityRating { get; set; }
        public virtual DisabilityStatus? DisabilityStatusNavigation { get; set; }
        public virtual User? UpdateUser { get; set; }
        public virtual User? User { get; set; }
    }
}

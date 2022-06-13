using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class UserLearnershipHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public ulong? Accept { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Note { get; set; }
        public long? ForAssessorModeratorApplicationId { get; set; }
        public long? LearnershipId { get; set; }
        public long? UserId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

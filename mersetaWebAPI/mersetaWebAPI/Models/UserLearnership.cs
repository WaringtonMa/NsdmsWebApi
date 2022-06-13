using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class UserLearnership
    {
        public long Id { get; set; }
        public ulong? Accept { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Note { get; set; }
        public long? ForAssessorModeratorApplicationId { get; set; }
        public long? LearnershipId { get; set; }
        public long? UserId { get; set; }

        public virtual AssessorModeratorApplication? ForAssessorModeratorApplication { get; set; }
        public virtual Learnership? Learnership { get; set; }
        public virtual User? User { get; set; }
    }
}

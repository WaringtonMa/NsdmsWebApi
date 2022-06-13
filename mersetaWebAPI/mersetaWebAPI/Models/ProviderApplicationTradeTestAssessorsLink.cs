using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ProviderApplicationTradeTestAssessorsLink
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? AssessorModeratorApplicationId { get; set; }
        public long? CreateUserId { get; set; }
        public long? TrainingProviderApplicationId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? UpdateUserId { get; set; }

        public virtual AssessorModeratorApplication? AssessorModeratorApplication { get; set; }
        public virtual User? CreateUser { get; set; }
        public virtual TrainingProviderApplication? TrainingProviderApplication { get; set; }
        public virtual User? UpdateUser { get; set; }
    }
}

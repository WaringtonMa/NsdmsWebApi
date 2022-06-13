using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ProviderApplicationTradeTestAssessorsLinkHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? AssessorModeratorApplicationId { get; set; }
        public long? CreateUserId { get; set; }
        public long? TrainingProviderApplicationId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? UpdateUserId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

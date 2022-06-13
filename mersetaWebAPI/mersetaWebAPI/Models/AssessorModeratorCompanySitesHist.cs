using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class AssessorModeratorCompanySitesHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public int? ApprovalStatus { get; set; }
        public int? AssessorModType { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? AssessorModeratorId { get; set; }
        public long? AssessorModeratorApplicationId { get; set; }
        public long? CompanyId { get; set; }
        public long? CreateUserId { get; set; }
        public long? LastActionUser { get; set; }
        public long? TrainingSiteId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

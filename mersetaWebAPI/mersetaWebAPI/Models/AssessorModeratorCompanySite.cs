using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class AssessorModeratorCompanySite
    {
        public long Id { get; set; }
        public int? ApprovalStatus { get; set; }
        public int? AssessorModType { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? AssessorModeratorId { get; set; }
        public long? AssessorModeratorApplicationId { get; set; }
        public long? CompanyId { get; set; }
        public long? CreateUserId { get; set; }
        public long? LastActionUser { get; set; }
        public long? TrainingSiteId { get; set; }

        public virtual User? AssessorModerator { get; set; }
        public virtual AssessorModeratorApplication? AssessorModeratorApplication { get; set; }
        public virtual Company? Company { get; set; }
        public virtual User? CreateUser { get; set; }
        public virtual User? LastActionUserNavigation { get; set; }
        public virtual TrainingSite? TrainingSite { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class AssessorModeratorCompany
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? AssessorModeratorId { get; set; }
        public long? CompanyId { get; set; }
        public long? ForAssessorModeratorApplicationId { get; set; }

        public virtual User? AssessorModerator { get; set; }
        public virtual Company? Company { get; set; }
        public virtual AssessorModeratorApplication? ForAssessorModeratorApplication { get; set; }
    }
}

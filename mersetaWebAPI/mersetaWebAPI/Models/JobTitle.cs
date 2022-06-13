using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class JobTitle
    {
        public JobTitle()
        {
            AssessorModeratorApplications = new HashSet<AssessorModeratorApplication>();
            HostingCompanyEmployees = new HashSet<HostingCompanyEmployee>();
            ScheduledEventUsers = new HashSet<ScheduledEventUser>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? Description { get; set; }
        public long? RolesId { get; set; }
        public string? SmsCode { get; set; }
        public long? RegionId { get; set; }

        public virtual Region? Region { get; set; }
        public virtual Role? Roles { get; set; }
        public virtual ICollection<AssessorModeratorApplication> AssessorModeratorApplications { get; set; }
        public virtual ICollection<HostingCompanyEmployee> HostingCompanyEmployees { get; set; }
        public virtual ICollection<ScheduledEventUser> ScheduledEventUsers { get; set; }
    }
}

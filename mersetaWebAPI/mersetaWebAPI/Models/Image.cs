using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Image
    {
        public Image()
        {
            HostingCompanies = new HashSet<HostingCompany>();
            Users = new HashSet<User>();
        }

        public long Id { get; set; }
        public ulong? Active { get; set; }
        public string? ContentType { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Extension { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string? NewFname { get; set; }
        public string? OriginalFname { get; set; }
        public byte[]? SecurityPic { get; set; }
        public long? HostingCompanyId { get; set; }
        public long? UserId { get; set; }
        public long? BugReportId { get; set; }

        public virtual BugReport? BugReport { get; set; }
        public virtual HostingCompany? HostingCompany { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<HostingCompany> HostingCompanies { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}

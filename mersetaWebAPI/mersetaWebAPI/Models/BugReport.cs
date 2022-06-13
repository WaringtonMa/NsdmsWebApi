using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class BugReport
    {
        public BugReport()
        {
            Images = new HashSet<Image>();
            MailLogs = new HashSet<MailLog>();
        }

        public long Id { get; set; }
        public string? BugReport1 { get; set; }
        public string? BugTitle { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? UserId { get; set; }
        public ulong? IssueClosed { get; set; }
        public int? ReportType { get; set; }
        public string? Comment { get; set; }
        public long? CompanyUsersId { get; set; }

        public virtual CompanyUser? CompanyUsers { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<MailLog> MailLogs { get; set; }
    }
}

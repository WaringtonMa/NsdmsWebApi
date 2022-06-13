using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class MailLog
    {
        public MailLog()
        {
            Docs = new HashSet<Doc>();
        }

        public long Id { get; set; }
        public string? Body { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Email { get; set; }
        public string? ErrorMsg { get; set; }
        public ulong? Failed { get; set; }
        public DateTime? SendDate { get; set; }
        public string? Subject { get; set; }
        public long? UserId { get; set; }
        public long? BugReportId { get; set; }

        public virtual BugReport? BugReport { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<Doc> Docs { get; set; }
    }
}

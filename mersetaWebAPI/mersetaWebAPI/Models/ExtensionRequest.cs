using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ExtensionRequest
    {
        public ExtensionRequest()
        {
            Docs = new HashSet<Doc>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? FinYear { get; set; }
        public string? ReasonForExtension { get; set; }
        public int? Status { get; set; }
        public long? CompanyId { get; set; }
        public long? UserId { get; set; }
        public long? WspId { get; set; }
        public DateTime? NewSubmissionDate { get; set; }
        public long? ApprovedUserId { get; set; }

        public virtual User? ApprovedUser { get; set; }
        public virtual Company? Company { get; set; }
        public virtual User? User { get; set; }
        public virtual Wsp? Wsp { get; set; }
        public virtual ICollection<Doc> Docs { get; set; }
    }
}

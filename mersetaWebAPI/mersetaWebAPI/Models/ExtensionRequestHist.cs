using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ExtensionRequestHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? FinYear { get; set; }
        public DateTime? NewSubmissionDate { get; set; }
        public string? ReasonForExtension { get; set; }
        public int? Status { get; set; }
        public long? CompanyId { get; set; }
        public long? UserId { get; set; }
        public long? WspId { get; set; }
        public long? ApprovedUserId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

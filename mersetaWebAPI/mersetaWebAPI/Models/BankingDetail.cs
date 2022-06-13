using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class BankingDetail
    {
        public BankingDetail()
        {
            Companies = new HashSet<Company>();
            Docs = new HashSet<Doc>();
            RejectReasonsChildren = new HashSet<RejectReasonsChild>();
            UpdateAuditTrails = new HashSet<UpdateAuditTrail>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string BankAccNumber { get; set; } = null!;
        public string BankHolder { get; set; } = null!;
        public string BranchCode { get; set; } = null!;
        public string? SwiftCode { get; set; }
        public long? BankId { get; set; }
        public long? CompanyId { get; set; }
        public int? Status { get; set; }
        public ulong? AreOriginalRequired { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public ulong? NotificationSentRegardingOriginal { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public long? ApprovalUserId { get; set; }

        public virtual User? ApprovalUser { get; set; }
        public virtual Bank? Bank { get; set; }
        public virtual Company? Company { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Doc> Docs { get; set; }
        public virtual ICollection<RejectReasonsChild> RejectReasonsChildren { get; set; }
        public virtual ICollection<UpdateAuditTrail> UpdateAuditTrails { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class BankingDetailsHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public ulong? AreOriginalRequired { get; set; }
        public string? BankAccNumber { get; set; }
        public string? BankHolder { get; set; }
        public string? BranchCode { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Status { get; set; }
        public string? SwiftCode { get; set; }
        public long? BankId { get; set; }
        public long? CompanyId { get; set; }
        public ulong? NotificationSentRegardingOriginal { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public long? ApprovalUserId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

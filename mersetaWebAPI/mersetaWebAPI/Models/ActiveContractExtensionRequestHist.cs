using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ActiveContractExtensionRequestHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DateUpdatedExtensionDate { get; set; }
        public DateTime? EnteredDate { get; set; }
        public DateTime? ExtenionDate { get; set; }
        public DateTime? OrginalDueDate { get; set; }
        public int? Status { get; set; }
        public ulong? UseSystemGeneratedDate { get; set; }
        public long? ActiveAontractsId { get; set; }
        public long? ApproveUserId { get; set; }
        public long? RequestUserId { get; set; }
        public long? UserUpdatedDateId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

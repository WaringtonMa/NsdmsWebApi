using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ActiveContractTerminationRequestHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DateRequested { get; set; }
        public int? Status { get; set; }
        public ulong? SystemGenerated { get; set; }
        public long? ActiveAontractsId { get; set; }
        public long? ApproveUserId { get; set; }
        public long? RequestUserId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

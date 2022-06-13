using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ActiveContractTerminationRequest
    {
        public long Id { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DateRequested { get; set; }
        public int? Status { get; set; }
        public ulong? SystemGenerated { get; set; }
        public long? ActiveAontractsId { get; set; }
        public long? ApproveUserId { get; set; }
        public long? RequestUserId { get; set; }

        public virtual ActiveContract? ActiveAontracts { get; set; }
        public virtual User? ApproveUser { get; set; }
        public virtual User? RequestUser { get; set; }
    }
}

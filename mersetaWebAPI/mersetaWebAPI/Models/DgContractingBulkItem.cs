using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DgContractingBulkItem
    {
        public long Id { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? BulkApproval { get; set; }
        public DateTime? CreateDate { get; set; }
        public ulong? Processed { get; set; }
        public int? StatusAssigned { get; set; }
        public int? WithdrawalAppealEnum { get; set; }
        public long? ActiveContractsId { get; set; }
        public long? ApprovalUserId { get; set; }
        public long? CreateUserId { get; set; }
        public long? DgContractingBulkEntryId { get; set; }

        public virtual ActiveContract? ActiveContracts { get; set; }
        public virtual User? ApprovalUser { get; set; }
        public virtual User? CreateUser { get; set; }
        public virtual DgContractingBulkEntry? DgContractingBulkEntry { get; set; }
    }
}

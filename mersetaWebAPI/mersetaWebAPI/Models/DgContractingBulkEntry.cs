using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DgContractingBulkEntry
    {
        public DgContractingBulkEntry()
        {
            DgContractingBulkItems = new HashSet<DgContractingBulkItem>();
        }

        public long Id { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? BatchNumber { get; set; }
        public int? BulkApproval { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Status { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public long? ApprovalUserId { get; set; }
        public long? CreateUserId { get; set; }
        public long? SubmissionUser { get; set; }

        public virtual User? ApprovalUser { get; set; }
        public virtual User? CreateUser { get; set; }
        public virtual User? SubmissionUserNavigation { get; set; }
        public virtual ICollection<DgContractingBulkItem> DgContractingBulkItems { get; set; }
    }
}

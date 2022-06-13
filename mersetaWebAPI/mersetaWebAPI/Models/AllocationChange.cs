using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class AllocationChange
    {
        public AllocationChange()
        {
            AllocationChangesReasons = new HashSet<AllocationChangesReason>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? AllocationChangeType { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<AllocationChangesReason> AllocationChangesReasons { get; set; }
    }
}

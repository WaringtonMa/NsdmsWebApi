using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkPlaceApprovalVisitDateLog
    {
        public long Id { get; set; }
        public string? AdditionalInfo { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DateOfVisit { get; set; }
        public ulong? SystemGenerated { get; set; }
        public long? UserId { get; set; }
        public long? WorkPlaceApprovalId { get; set; }

        public virtual User? User { get; set; }
        public virtual WorkPlaceApproval? WorkPlaceApproval { get; set; }
    }
}

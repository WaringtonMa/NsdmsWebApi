using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SmeQualificationsHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Status { get; set; }
        public long? QualificationId { get; set; }
        public long? SitesSmeId { get; set; }
        public ulong? Acepted { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public long? ApproveUserId { get; set; }
        public long? SmeQualificationsParentId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

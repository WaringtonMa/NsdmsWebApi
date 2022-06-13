using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LevyDetailMgPaymentsAlterAudit
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public ulong? MgCanProcess { get; set; }
        public long? SarsFileId { get; set; }
        public long? SarsLevyDetailsId { get; set; }
        public long? UserId { get; set; }

        public virtual SarsFile? SarsFile { get; set; }
        public virtual SarsLevyDetail? SarsLevyDetails { get; set; }
        public virtual User? User { get; set; }
    }
}

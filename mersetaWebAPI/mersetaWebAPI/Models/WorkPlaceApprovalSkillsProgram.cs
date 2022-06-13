using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkPlaceApprovalSkillsProgram
    {
        public long Id { get; set; }
        public ulong? Accept { get; set; }
        public int? AcceptEnum { get; set; }
        public DateTime? CreateDate { get; set; }
        public ulong? SoftDelete { get; set; }
        public long? SkillsProgramId { get; set; }
        public long? WorkPlaceApprovalId { get; set; }

        public virtual SkillsProgram? SkillsProgram { get; set; }
        public virtual WorkPlaceApproval? WorkPlaceApproval { get; set; }
    }
}

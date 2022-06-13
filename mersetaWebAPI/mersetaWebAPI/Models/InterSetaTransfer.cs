using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class InterSetaTransfer
    {
        public long Id { get; set; }
        public DateTime? ActionDate { get; set; }
        public string? AdditionalComment { get; set; }
        public ulong? CoreBusinessChanged { get; set; }
        public DateTime? CreateDate { get; set; }
        public ulong? MoreThanOneSeta { get; set; }
        public ulong? ScopedWithinSeta { get; set; }
        public long? CompanyId { get; set; }
        public long? CurrentEtqaId { get; set; }
        public long? NewEtqaId { get; set; }
        public long? UsersId { get; set; }
        public string? Guid { get; set; }
        public int? ApprovalStatus { get; set; }

        public virtual Company? Company { get; set; }
        public virtual Etqa? CurrentEtqa { get; set; }
        public virtual Etqa? NewEtqa { get; set; }
        public virtual User? Users { get; set; }
    }
}

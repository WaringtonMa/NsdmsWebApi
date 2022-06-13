using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class QdfCompanyUser
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public ulong? SoftDelete { get; set; }
        public long? QdfCompanyId { get; set; }
        public long? UserId { get; set; }

        public virtual QdfCompany? QdfCompany { get; set; }
        public virtual User? User { get; set; }
    }
}

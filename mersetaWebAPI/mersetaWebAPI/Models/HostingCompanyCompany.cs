using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class HostingCompanyCompany
    {
        public long Id { get; set; }
        public ulong? Active { get; set; }
        public DateTime? CreateDate { get; set; }
        public long CompanyId { get; set; }
        public long HostingCompanyId { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual HostingCompany HostingCompany { get; set; } = null!;
    }
}

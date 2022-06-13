using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyHostingCompany
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Note { get; set; }
        public long? CompanyId { get; set; }
        public long? HostingCompanyId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual HostingCompany? HostingCompany { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class UserHostingCompany
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Note { get; set; }
        public long? HostingCompanyId { get; set; }
        public long? UserId { get; set; }

        public virtual HostingCompany? HostingCompany { get; set; }
        public virtual User? User { get; set; }
    }
}

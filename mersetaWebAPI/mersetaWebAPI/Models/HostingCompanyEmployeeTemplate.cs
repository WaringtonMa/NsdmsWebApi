using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class HostingCompanyEmployeeTemplate
    {
        public HostingCompanyEmployeeTemplate()
        {
            InverseOrigTemplate = new HashSet<HostingCompanyEmployeeTemplate>();
            InverseTemplate = new HashSet<HostingCompanyEmployeeTemplate>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? TemplateType { get; set; }
        public string? Title { get; set; }
        public string? UniqueId { get; set; }
        public long HostingCompanyId { get; set; }
        public long? OrigTemplateId { get; set; }
        public long? TemplateId { get; set; }
        public long Uid { get; set; }

        public virtual HostingCompany HostingCompany { get; set; } = null!;
        public virtual HostingCompanyEmployeeTemplate? OrigTemplate { get; set; }
        public virtual HostingCompanyEmployeeTemplate? Template { get; set; }
        public virtual User UidNavigation { get; set; } = null!;
        public virtual ICollection<HostingCompanyEmployeeTemplate> InverseOrigTemplate { get; set; }
        public virtual ICollection<HostingCompanyEmployeeTemplate> InverseTemplate { get; set; }
    }
}

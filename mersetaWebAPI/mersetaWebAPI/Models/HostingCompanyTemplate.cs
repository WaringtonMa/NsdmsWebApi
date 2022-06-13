using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class HostingCompanyTemplate
    {
        public HostingCompanyTemplate()
        {
            Docs = new HashSet<Doc>();
            InverseOrigTemplate = new HashSet<HostingCompanyTemplate>();
            InverseTemplate = new HashSet<HostingCompanyTemplate>();
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
        public virtual HostingCompanyTemplate? OrigTemplate { get; set; }
        public virtual HostingCompanyTemplate? Template { get; set; }
        public virtual User UidNavigation { get; set; } = null!;
        public virtual ICollection<Doc> Docs { get; set; }
        public virtual ICollection<HostingCompanyTemplate> InverseOrigTemplate { get; set; }
        public virtual ICollection<HostingCompanyTemplate> InverseTemplate { get; set; }
    }
}

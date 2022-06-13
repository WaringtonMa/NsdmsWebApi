using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ConfigDoc
    {
        public ConfigDoc()
        {
            Docs = new HashSet<Doc>();
            InverseParentConfigDoc = new HashSet<ConfigDoc>();
        }

        public long Id { get; set; }
        public int? CompanyOrUserDocument { get; set; }
        public int? ConfigDocProcess { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Name { get; set; }
        public ulong? ReqImmediate { get; set; }
        public long? HostingCompanyId { get; set; }
        public long? ParentConfigDocId { get; set; }
        public ulong? OriginalRequired { get; set; }
        public ulong? RequiredDocument { get; set; }
        public int? WspDocRequirements { get; set; }
        public string? JasperReport { get; set; }
        public ulong? RequiredForAppeal { get; set; }
        public ulong? UseAsDownload { get; set; }
        public int? WpaDocRequirements { get; set; }
        public long? ProcessRoles { get; set; }
        public int? CofigCount { get; set; }
        public int? ArplDocRequirements { get; set; }
        public int? TransferDocumentsEnum { get; set; }
        public int? SdfRegistartionDoc { get; set; }
        public int? LearnerDocRequirements { get; set; }

        public virtual HostingCompany? HostingCompany { get; set; }
        public virtual ConfigDoc? ParentConfigDoc { get; set; }
        public virtual ProcessRole? ProcessRolesNavigation { get; set; }
        public virtual ICollection<Doc> Docs { get; set; }
        public virtual ICollection<ConfigDoc> InverseParentConfigDoc { get; set; }
    }
}

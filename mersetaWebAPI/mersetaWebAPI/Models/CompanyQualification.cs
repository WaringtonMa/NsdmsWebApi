using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyQualification
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Note { get; set; }
        public ulong? SoftDelete { get; set; }
        public long? CompanyId { get; set; }
        public long? QualificationId { get; set; }
        public ulong? Accept { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? NonSetaCompanyId { get; set; }
        public long? TrainingProviderDocParentId { get; set; }
        public ulong? ManuallyAdded { get; set; }

        public virtual Company? Company { get; set; }
        public virtual NonSetaCompany? NonSetaCompany { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual TrainingProviderDocParent? TrainingProviderDocParent { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SdfCompanyHistory
    {
        public long Id { get; set; }
        public int? ApprovalStatus { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? CompanyId { get; set; }
        public long? ForSdfCompany { get; set; }
        public long? RelationshipToCompanyId { get; set; }
        public long? ScopeOfResponsibilityId { get; set; }
        public long? SdfId { get; set; }
        public long? SdfTypeId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual SdfCompany? ForSdfCompanyNavigation { get; set; }
        public virtual RelationshipToCompany? RelationshipToCompany { get; set; }
        public virtual ScopeOfResponsibility? ScopeOfResponsibility { get; set; }
        public virtual User? Sdf { get; set; }
        public virtual SdfType? SdfType { get; set; }
    }
}

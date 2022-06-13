using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WspSdfCompanyHistory
    {
        public long Id { get; set; }
        public int? ApprovalStatus { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? OrginalCreateDate { get; set; }
        public long? OrginalSdfCompanyId { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? CompanyId { get; set; }
        public long? RelationshipToCompanyId { get; set; }
        public long? ScopeOfResponsibilityId { get; set; }
        public long? SdfId { get; set; }
        public long? SdfTypeId { get; set; }
        public long? WspCompanyMainHistoryId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual RelationshipToCompany? RelationshipToCompany { get; set; }
        public virtual ScopeOfResponsibility? ScopeOfResponsibility { get; set; }
        public virtual User? Sdf { get; set; }
        public virtual SdfType? SdfType { get; set; }
        public virtual WspCompanyMainHistory? WspCompanyMainHistory { get; set; }
    }
}

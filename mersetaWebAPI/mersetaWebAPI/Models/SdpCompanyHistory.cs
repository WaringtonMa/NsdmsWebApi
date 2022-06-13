using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SdpCompanyHistory
    {
        public long Id { get; set; }
        public int? ApprovalStatus { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? CompanyId { get; set; }
        public long? ForSdpCompany { get; set; }
        public long? RelationshipToCompanyId { get; set; }
        public long? ScopeOfResponsibilityId { get; set; }
        public long? SdpId { get; set; }
        public long? SdpTypeId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual SdpCompany? ForSdpCompanyNavigation { get; set; }
        public virtual RelationshipToCompany? RelationshipToCompany { get; set; }
        public virtual ScopeOfResponsibility? ScopeOfResponsibility { get; set; }
        public virtual User? Sdp { get; set; }
        public virtual SdpType? SdpType { get; set; }
    }
}

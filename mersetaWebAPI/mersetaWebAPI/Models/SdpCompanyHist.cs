using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SdpCompanyHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public int? ApprovalStatus { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? CompanyId { get; set; }
        public long? RelationshipToCompanyId { get; set; }
        public long? ScopeOfResponsibilityId { get; set; }
        public long? SdpId { get; set; }
        public long? SpfTypeId { get; set; }
        public long? TrainingSiteId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

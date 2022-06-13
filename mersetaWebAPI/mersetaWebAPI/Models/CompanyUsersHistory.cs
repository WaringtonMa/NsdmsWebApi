using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyUsersHistory
    {
        public long Id { get; set; }
        public int? ApprovalStatus { get; set; }
        public int? CompanyUserType { get; set; }
        public DateTime? CreateDate { get; set; }
        public long CompanyId { get; set; }
        public long? ForCompanyUser { get; set; }
        public long? PositionId { get; set; }
        public long UserId { get; set; }
        public long? UserResponsibilityId { get; set; }
        public ulong? NoResponsibility { get; set; }
        public long? DesignationId { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual Designation? Designation { get; set; }
        public virtual CompanyUser? ForCompanyUserNavigation { get; set; }
        public virtual CompanyUserPosition? Position { get; set; }
        public virtual User User { get; set; } = null!;
        public virtual UserResponsibility? UserResponsibility { get; set; }
    }
}

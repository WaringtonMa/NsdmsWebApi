using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class NonSetaCompanyUser
    {
        public long Id { get; set; }
        public int? ApprovalStatus { get; set; }
        public int? AssessorModType { get; set; }
        public int? CompanyUserType { get; set; }
        public DateTime? CreateDate { get; set; }
        public ulong? ExistingUser { get; set; }
        public ulong? NoResponsibility { get; set; }
        public int? SmeType { get; set; }
        public long? DesignationId { get; set; }
        public long NonSetaCompanyId { get; set; }
        public long? PositionId { get; set; }
        public long UserId { get; set; }

        public virtual Designation? Designation { get; set; }
        public virtual NonSetaCompany NonSetaCompany { get; set; } = null!;
        public virtual CompanyUserPosition? Position { get; set; }
        public virtual User User { get; set; } = null!;
    }
}

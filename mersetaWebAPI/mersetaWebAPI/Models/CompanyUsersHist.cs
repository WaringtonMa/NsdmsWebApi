using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyUsersHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public int? ApprovalStatus { get; set; }
        public int? AssessorModType { get; set; }
        public int? CompanyUserType { get; set; }
        public DateTime? CreateDate { get; set; }
        public ulong? ExistingUser { get; set; }
        public ulong? NoResponsibility { get; set; }
        public int? SmeType { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? CompanyId { get; set; }
        public long? DesignationId { get; set; }
        public long? PositionId { get; set; }
        public long? UserId { get; set; }
        public long? UserResponsibilityId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

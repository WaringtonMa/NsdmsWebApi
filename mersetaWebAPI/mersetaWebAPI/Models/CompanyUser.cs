using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyUser
    {
        public CompanyUser()
        {
            BugReports = new HashSet<BugReport>();
            CompanyUsersHistories = new HashSet<CompanyUsersHistory>();
            UsersResponsibilities = new HashSet<UsersResponsibility>();
            UsersResponsibilitiesHistories = new HashSet<UsersResponsibilitiesHistory>();
            Wsps = new HashSet<Wsp>();
        }

        public long Id { get; set; }
        public int? CompanyUserType { get; set; }
        public DateTime? CreateDate { get; set; }
        public long CompanyId { get; set; }
        public long? UserId { get; set; }
        public long? PositionId { get; set; }
        public long? UserResponsibilityId { get; set; }
        public int? ApprovalStatus { get; set; }
        public ulong? NoResponsibility { get; set; }
        public long? UserIdHistory { get; set; }
        public ulong? ExistingUser { get; set; }
        public int? SmeType { get; set; }
        public long? DesignationId { get; set; }
        public int? AssessorModType { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual Designation? Designation { get; set; }
        public virtual CompanyUserPosition? Position { get; set; }
        public virtual User? User { get; set; }
        public virtual UserResponsibility? UserResponsibility { get; set; }
        public virtual ICollection<BugReport> BugReports { get; set; }
        public virtual ICollection<CompanyUsersHistory> CompanyUsersHistories { get; set; }
        public virtual ICollection<UsersResponsibility> UsersResponsibilities { get; set; }
        public virtual ICollection<UsersResponsibilitiesHistory> UsersResponsibilitiesHistories { get; set; }
        public virtual ICollection<Wsp> Wsps { get; set; }
    }
}

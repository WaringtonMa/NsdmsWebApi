using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ProcessRole
    {
        public ProcessRole()
        {
            ConfigDocs = new HashSet<ConfigDoc>();
            Tasks = new HashSet<Task>();
            UsersRoles = new HashSet<UsersRole>();
        }

        public long Id { get; set; }
        public int? CompanyUserType { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Note { get; set; }
        public string? RejectMessage { get; set; }
        public int? RoleOrder { get; set; }
        public int? RolePermission { get; set; }
        public long? HostingCompanyProcessId { get; set; }
        public long? RolesId { get; set; }
        public int? NumberOfDays { get; set; }
        public string? TargetClass { get; set; }
        public string? TargetMethod { get; set; }
        public long? NextTaskRole { get; set; }

        public virtual HostingCompanyProcess? HostingCompanyProcess { get; set; }
        public virtual Role? NextTaskRoleNavigation { get; set; }
        public virtual Role? Roles { get; set; }
        public virtual ICollection<ConfigDoc> ConfigDocs { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
        public virtual ICollection<UsersRole> UsersRoles { get; set; }
    }
}

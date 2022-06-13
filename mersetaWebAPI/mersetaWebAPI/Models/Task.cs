using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Task
    {
        public Task()
        {
            CompanyLearnersTerminations = new HashSet<CompanyLearnersTermination>();
            CompanyLearnersTransfers = new HashSet<CompanyLearnersTransfer>();
            InversePreviousTask = new HashSet<Task>();
            RejectReasonsChildren = new HashSet<RejectReasonsChild>();
            TaskUsers = new HashSet<TaskUser>();
            UserBrowserInformations = new HashSet<UserBrowserInformation>();
        }

        public long Id { get; set; }
        public DateTime? ActionDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public string? Guid { get; set; }
        public DateTime? StartDate { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public string? TaskDirectPage { get; set; }
        public int? TaskStatus { get; set; }
        public int? WorkflowProcess { get; set; }
        public long? ActionUserId { get; set; }
        public long? CompanyId { get; set; }
        public long? CreateUserId { get; set; }
        public long? HostingCompanyProcessId { get; set; }
        public long? ProcessRoleId { get; set; }
        public ulong? FirstInProcess { get; set; }
        public long? PreviousTaskId { get; set; }

        public virtual User? ActionUser { get; set; }
        public virtual Company? Company { get; set; }
        public virtual User? CreateUser { get; set; }
        public virtual HostingCompanyProcess? HostingCompanyProcess { get; set; }
        public virtual Task? PreviousTask { get; set; }
        public virtual ProcessRole? ProcessRole { get; set; }
        public virtual ICollection<CompanyLearnersTermination> CompanyLearnersTerminations { get; set; }
        public virtual ICollection<CompanyLearnersTransfer> CompanyLearnersTransfers { get; set; }
        public virtual ICollection<Task> InversePreviousTask { get; set; }
        public virtual ICollection<RejectReasonsChild> RejectReasonsChildren { get; set; }
        public virtual ICollection<TaskUser> TaskUsers { get; set; }
        public virtual ICollection<UserBrowserInformation> UserBrowserInformations { get; set; }
    }
}

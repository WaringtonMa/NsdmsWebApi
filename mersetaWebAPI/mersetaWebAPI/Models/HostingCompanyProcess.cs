using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class HostingCompanyProcess
    {
        public HostingCompanyProcess()
        {
            HostingCompanyDepartmentsProcesses = new HashSet<HostingCompanyDepartmentsProcess>();
            InverseNextProcess = new HashSet<HostingCompanyProcess>();
            ProcessRoles = new HashSet<ProcessRole>();
            Tasks = new HashSet<Task>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Note { get; set; }
        public string? WorkflowProcess { get; set; }
        public long? HostingCompanyId { get; set; }
        public long? NextProcessId { get; set; }

        public virtual HostingCompany? HostingCompany { get; set; }
        public virtual HostingCompanyProcess? NextProcess { get; set; }
        public virtual ICollection<HostingCompanyDepartmentsProcess> HostingCompanyDepartmentsProcesses { get; set; }
        public virtual ICollection<HostingCompanyProcess> InverseNextProcess { get; set; }
        public virtual ICollection<ProcessRole> ProcessRoles { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}

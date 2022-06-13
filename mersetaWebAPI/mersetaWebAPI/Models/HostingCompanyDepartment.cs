using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class HostingCompanyDepartment
    {
        public HostingCompanyDepartment()
        {
            ChatMessages = new HashSet<ChatMessage>();
            HostingCompanyDepartmentsChatEmployees = new HashSet<HostingCompanyDepartmentsChatEmployee>();
            HostingCompanyDepartmentsEmployees = new HashSet<HostingCompanyDepartmentsEmployee>();
            HostingCompanyDepartmentsProcesses = new HashSet<HostingCompanyDepartmentsProcess>();
            InverseHostingCompanyDepartmentParent = new HashSet<HostingCompanyDepartment>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Department { get; set; }
        public long? HostingCompanyId { get; set; }
        public long? HostingCompanyDepartmentParentId { get; set; }

        public virtual HostingCompany? HostingCompany { get; set; }
        public virtual HostingCompanyDepartment? HostingCompanyDepartmentParent { get; set; }
        public virtual ICollection<ChatMessage> ChatMessages { get; set; }
        public virtual ICollection<HostingCompanyDepartmentsChatEmployee> HostingCompanyDepartmentsChatEmployees { get; set; }
        public virtual ICollection<HostingCompanyDepartmentsEmployee> HostingCompanyDepartmentsEmployees { get; set; }
        public virtual ICollection<HostingCompanyDepartmentsProcess> HostingCompanyDepartmentsProcesses { get; set; }
        public virtual ICollection<HostingCompanyDepartment> InverseHostingCompanyDepartmentParent { get; set; }
    }
}

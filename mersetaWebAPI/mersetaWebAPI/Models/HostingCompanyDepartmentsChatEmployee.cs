using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class HostingCompanyDepartmentsChatEmployee
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? HostingCompanyDepartmentId { get; set; }
        public long? HostingCompanyEmployeesId { get; set; }

        public virtual HostingCompanyDepartment? HostingCompanyDepartment { get; set; }
        public virtual HostingCompanyEmployee? HostingCompanyEmployees { get; set; }
    }
}

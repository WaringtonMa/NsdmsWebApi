using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class HostingCompanyDepartmentsProcess
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? HostingCompanyDepartmentId { get; set; }
        public long? HostingCompanyProcessId { get; set; }

        public virtual HostingCompanyDepartment? HostingCompanyDepartment { get; set; }
        public virtual HostingCompanyProcess? HostingCompanyProcess { get; set; }
    }
}

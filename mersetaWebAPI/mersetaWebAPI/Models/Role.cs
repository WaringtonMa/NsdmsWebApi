using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Role
    {
        public Role()
        {
            DgVerificationRejectionInformations = new HashSet<DgVerificationRejectionInformation>();
            HostingCompanyDepartmentsEmployees = new HashSet<HostingCompanyDepartmentsEmployee>();
            JobTitles = new HashSet<JobTitle>();
            ProcessRoleNextTaskRoleNavigations = new HashSet<ProcessRole>();
            ProcessRoleRoles = new HashSet<ProcessRole>();
            Signoffs = new HashSet<Signoff>();
            WspRejectionInformations = new HashSet<WspRejectionInformation>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? Dashboard { get; set; }
        public string? Description { get; set; }
        public string? Code { get; set; }
        public ulong? Companies { get; set; }
        public ulong? DgAllocation { get; set; }
        public ulong? DgVerification { get; set; }
        public ulong? InterSetaTransfer { get; set; }
        public ulong? MgVerification { get; set; }
        public ulong? OrgChart { get; set; }
        public ulong? Sdfs { get; set; }
        public ulong? SiteVisit { get; set; }
        public string? SmsCode { get; set; }
        public ulong? CoursewareDistro { get; set; }
        public ulong? ProviderMonitoring { get; set; }
        public ulong? SiteVisitReport { get; set; }
        public string? DashboardReporting { get; set; }
        public ulong? CoursewareDistroSub { get; set; }
        public ulong? InitiateWorkplaceMonitoring { get; set; }
        public ulong? WorkplaceMonitoringAccess { get; set; }
        public ulong? CloCrmReporting { get; set; }

        public virtual ICollection<DgVerificationRejectionInformation> DgVerificationRejectionInformations { get; set; }
        public virtual ICollection<HostingCompanyDepartmentsEmployee> HostingCompanyDepartmentsEmployees { get; set; }
        public virtual ICollection<JobTitle> JobTitles { get; set; }
        public virtual ICollection<ProcessRole> ProcessRoleNextTaskRoleNavigations { get; set; }
        public virtual ICollection<ProcessRole> ProcessRoleRoles { get; set; }
        public virtual ICollection<Signoff> Signoffs { get; set; }
        public virtual ICollection<WspRejectionInformation> WspRejectionInformations { get; set; }
    }
}

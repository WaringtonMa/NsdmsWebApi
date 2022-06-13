using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class HostingCompanyEmployee
    {
        public HostingCompanyEmployee()
        {
            HostingCompanyDepartmentsChatEmployees = new HashSet<HostingCompanyDepartmentsChatEmployee>();
            HostingCompanyDepartmentsEmployees = new HashSet<HostingCompanyDepartmentsEmployee>();
            RegionTownClos = new HashSet<RegionTown>();
            RegionTownCrms = new HashSet<RegionTown>();
            RegionTownOthers = new HashSet<RegionTown>();
        }

        public long Id { get; set; }
        public ulong? Active { get; set; }
        public ulong? Admin { get; set; }
        public DateTime? CreateDate { get; set; }
        public long HostingCompanyId { get; set; }
        public long UserId { get; set; }
        public long? JobTitleId { get; set; }

        public virtual HostingCompany HostingCompany { get; set; } = null!;
        public virtual JobTitle? JobTitle { get; set; }
        public virtual User User { get; set; } = null!;
        public virtual ICollection<HostingCompanyDepartmentsChatEmployee> HostingCompanyDepartmentsChatEmployees { get; set; }
        public virtual ICollection<HostingCompanyDepartmentsEmployee> HostingCompanyDepartmentsEmployees { get; set; }
        public virtual ICollection<RegionTown> RegionTownClos { get; set; }
        public virtual ICollection<RegionTown> RegionTownCrms { get; set; }
        public virtual ICollection<RegionTown> RegionTownOthers { get; set; }
    }
}

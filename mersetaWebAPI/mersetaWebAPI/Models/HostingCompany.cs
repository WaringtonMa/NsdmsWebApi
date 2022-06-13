using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class HostingCompany
    {
        public HostingCompany()
        {
            AddressChanges = new HashSet<AddressChange>();
            AddressHistories = new HashSet<AddressHistory>();
            Addresses = new HashSet<Address>();
            CompanyHostingCompanies = new HashSet<CompanyHostingCompany>();
            ConfigDocs = new HashSet<ConfigDoc>();
            HostingCompanyCompanies = new HashSet<HostingCompanyCompany>();
            HostingCompanyDepartments = new HashSet<HostingCompanyDepartment>();
            HostingCompanyEmployeeTemplates = new HashSet<HostingCompanyEmployeeTemplate>();
            HostingCompanyEmployees = new HashSet<HostingCompanyEmployee>();
            HostingCompanyProcesses = new HashSet<HostingCompanyProcess>();
            HostingCompanyTemplates = new HashSet<HostingCompanyTemplate>();
            Images = new HashSet<Image>();
            UserHostingCompanies = new HashSet<UserHostingCompany>();
            WspCompanyAddressHistories = new HashSet<WspCompanyAddressHistory>();
        }

        public long Id { get; set; }
        public ulong? ArTakeOn { get; set; }
        public string CompanyName { get; set; } = null!;
        public string CompanyRegNumber { get; set; } = null!;
        public DateTime? CreateDate { get; set; }
        public string? IncomeTaxNumber { get; set; }
        public string? Logo { get; set; }
        public string? Theme { get; set; }
        public string? Title { get; set; }
        public string? VatNumber { get; set; }
        public long? ProfileImageId { get; set; }

        public virtual Image? ProfileImage { get; set; }
        public virtual ICollection<AddressChange> AddressChanges { get; set; }
        public virtual ICollection<AddressHistory> AddressHistories { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<CompanyHostingCompany> CompanyHostingCompanies { get; set; }
        public virtual ICollection<ConfigDoc> ConfigDocs { get; set; }
        public virtual ICollection<HostingCompanyCompany> HostingCompanyCompanies { get; set; }
        public virtual ICollection<HostingCompanyDepartment> HostingCompanyDepartments { get; set; }
        public virtual ICollection<HostingCompanyEmployeeTemplate> HostingCompanyEmployeeTemplates { get; set; }
        public virtual ICollection<HostingCompanyEmployee> HostingCompanyEmployees { get; set; }
        public virtual ICollection<HostingCompanyProcess> HostingCompanyProcesses { get; set; }
        public virtual ICollection<HostingCompanyTemplate> HostingCompanyTemplates { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<UserHostingCompany> UserHostingCompanies { get; set; }
        public virtual ICollection<WspCompanyAddressHistory> WspCompanyAddressHistories { get; set; }
    }
}

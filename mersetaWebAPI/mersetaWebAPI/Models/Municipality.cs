using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Municipality
    {
        public Municipality()
        {
            AddressChanges = new HashSet<AddressChange>();
            AddressHistories = new HashSet<AddressHistory>();
            Addresses = new HashSet<Address>();
            Employees = new HashSet<Employee>();
            EmployeesHistories = new HashSet<EmployeesHistory>();
            InverseIddistrictNavigation = new HashSet<Municipality>();
            Learners = new HashSet<Learner>();
            MandatoryGrantDetailArchives = new HashSet<MandatoryGrantDetailArchive>();
            MandatoryGrantDetails = new HashSet<MandatoryGrantDetail>();
            MandatoryGrants = new HashSet<MandatoryGrant>();
            Users = new HashSet<User>();
            WspCompanyAddressHistories = new HashSet<WspCompanyAddressHistory>();
            WspCompanyEmployeesHistories = new HashSet<WspCompanyEmployeesHistory>();
        }

        public int Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Map { get; set; }
        public string? MunicipalityDesc { get; set; }
        public ulong? NotSumitted { get; set; }
        public int? Iddistrict { get; set; }
        public long? Idmunicipalitytype { get; set; }
        public int ProvincesIdprovinces { get; set; }

        public virtual Municipality? IddistrictNavigation { get; set; }
        public virtual MunicipalityType? IdmunicipalitytypeNavigation { get; set; }
        public virtual Province ProvincesIdprovincesNavigation { get; set; } = null!;
        public virtual ICollection<AddressChange> AddressChanges { get; set; }
        public virtual ICollection<AddressHistory> AddressHistories { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<EmployeesHistory> EmployeesHistories { get; set; }
        public virtual ICollection<Municipality> InverseIddistrictNavigation { get; set; }
        public virtual ICollection<Learner> Learners { get; set; }
        public virtual ICollection<MandatoryGrantDetailArchive> MandatoryGrantDetailArchives { get; set; }
        public virtual ICollection<MandatoryGrantDetail> MandatoryGrantDetails { get; set; }
        public virtual ICollection<MandatoryGrant> MandatoryGrants { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<WspCompanyAddressHistory> WspCompanyAddressHistories { get; set; }
        public virtual ICollection<WspCompanyEmployeesHistory> WspCompanyEmployeesHistories { get; set; }
    }
}

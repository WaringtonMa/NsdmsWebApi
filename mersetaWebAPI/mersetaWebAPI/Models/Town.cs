using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Town
    {
        public Town()
        {
            AddressChanges = new HashSet<AddressChange>();
            AddressHistories = new HashSet<AddressHistory>();
            Addresses = new HashSet<Address>();
            RegionTowns = new HashSet<RegionTown>();
            Users = new HashSet<User>();
            WspCompanyAddressHistories = new HashSet<WspCompanyAddressHistory>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Description { get; set; }
        public string? Code { get; set; }

        public virtual ICollection<AddressChange> AddressChanges { get; set; }
        public virtual ICollection<AddressHistory> AddressHistories { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<RegionTown> RegionTowns { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<WspCompanyAddressHistory> WspCompanyAddressHistories { get; set; }
    }
}

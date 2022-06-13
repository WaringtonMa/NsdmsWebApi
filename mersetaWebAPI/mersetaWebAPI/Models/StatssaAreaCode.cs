using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class StatssaAreaCode
    {
        public StatssaAreaCode()
        {
            AddressChanges = new HashSet<AddressChange>();
            Addresses = new HashSet<Address>();
            CompanyLearners = new HashSet<CompanyLearner>();
            CompanyLearnersDetailsChanges = new HashSet<CompanyLearnersDetailsChange>();
            WspCompanyAddressHistories = new HashSet<WspCompanyAddressHistory>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public string? SmsCode { get; set; }

        public virtual ICollection<AddressChange> AddressChanges { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearners { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChanges { get; set; }
        public virtual ICollection<WspCompanyAddressHistory> WspCompanyAddressHistories { get; set; }
    }
}

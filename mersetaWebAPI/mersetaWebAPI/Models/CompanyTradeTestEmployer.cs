using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyTradeTestEmployer
    {
        public CompanyTradeTestEmployer()
        {
            CompanyLearnersTradeTests = new HashSet<CompanyLearnersTradeTest>();
        }

        public long Id { get; set; }
        public string? CompanyGuid { get; set; }
        public string? CompanyName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Email { get; set; }
        public string? FaxNumber { get; set; }
        public string? TelNumber { get; set; }
        public string? TradingName { get; set; }
        public string? UserCellNumber { get; set; }
        public string? UserEmail { get; set; }
        public string? UserFirstName { get; set; }
        public string? UserLastName { get; set; }
        public string? UserMiddleName { get; set; }
        public string? UserTelNumber { get; set; }
        public long? CompanyId { get; set; }
        public long? PostalAddressId { get; set; }
        public long? RegisteredAddressId { get; set; }
        public long? ResidentialAddressId { get; set; }
        public string? LevyNumber { get; set; }

        public virtual Company? Company { get; set; }
        public virtual Address? PostalAddress { get; set; }
        public virtual Address? RegisteredAddress { get; set; }
        public virtual Address? ResidentialAddress { get; set; }
        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTests { get; set; }
    }
}

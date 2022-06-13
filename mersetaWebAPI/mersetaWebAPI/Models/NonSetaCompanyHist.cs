using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class NonSetaCompanyHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public string? AccreditationNumber { get; set; }
        public int? ApprovalEnum { get; set; }
        public string? CompanyGuid { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyNumber { get; set; }
        public string? CompanyRegistrationNumber { get; set; }
        public int? CompanyStatus { get; set; }
        public int? CompanyType { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Email { get; set; }
        public string? FaxNumber { get; set; }
        public string? LevyNumber { get; set; }
        public string? TelNumber { get; set; }
        public long? PostalAddressId { get; set; }
        public long? RegisteredAddressId { get; set; }
        public long? ResidentialAddressId { get; set; }
        public long? SetaId { get; set; }
        public long? SicCodeId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

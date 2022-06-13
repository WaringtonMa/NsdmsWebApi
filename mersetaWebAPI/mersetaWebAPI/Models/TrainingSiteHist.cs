using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class TrainingSiteHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public int? ApprovalStatus { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastActionUserDate { get; set; }
        public string? SiteGuid { get; set; }
        public string? SiteName { get; set; }
        public long? CompanyId { get; set; }
        public long? LastActionUserId { get; set; }
        public long? PostalAddressId { get; set; }
        public long? ResidentialAddressId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

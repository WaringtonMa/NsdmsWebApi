using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SitesSmeHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public ulong? Active { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public ulong? ExistingUser { get; set; }
        public string? FirstName { get; set; }
        public string? IdentityNumber { get; set; }
        public string? LastName { get; set; }
        public string? NlrdNumber { get; set; }
        public string? PassportNumber { get; set; }
        public string? SmeType { get; set; }
        public ulong? SoftDelete { get; set; }
        public int? Status { get; set; }
        public ulong? UseCompanyAddress { get; set; }
        public long? ApproveUserId { get; set; }
        public long? CompanyId { get; set; }
        public long? DeleteUserId { get; set; }
        public long? QualificationId { get; set; }
        public long? ResidentialAddressId { get; set; }
        public long? SitesId { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public string? Reason { get; set; }
        public ulong? LockSme { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

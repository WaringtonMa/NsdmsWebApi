using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WspCompanyAddressHistory
    {
        public WspCompanyAddressHistory()
        {
            WspCompanyHistoryWspCompanyAddressHistoryPostals = new HashSet<WspCompanyHistory>();
            WspCompanyHistoryWspCompanyAddressHistoryRegistereds = new HashSet<WspCompanyHistory>();
            WspCompanyHistoryWspCompanyAddressHistoryResidentials = new HashSet<WspCompanyHistory>();
        }

        public long Id { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? AddressLine4 { get; set; }
        public DateTime? CreateDate { get; set; }
        public double? Latitude { get; set; }
        public double? LatitudeDegrees { get; set; }
        public double? LatitudeMinutes { get; set; }
        public double? LatitudeSeconds { get; set; }
        public double? Longitude { get; set; }
        public double? LongitudeDegrees { get; set; }
        public double? LongitudeMinutes { get; set; }
        public double? LongitudeSeconds { get; set; }
        public long? OrginalAddressId { get; set; }
        public DateTime? OrginalCreateDate { get; set; }
        public string? Postcode { get; set; }
        public ulong? PrimaryAddr { get; set; }
        public ulong? SameAddress { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? CompanyId { get; set; }
        public long? HostingCompanyId { get; set; }
        public int? MunicipalityId { get; set; }
        public long? SitesId { get; set; }
        public long? StatsSaareaCodeId { get; set; }
        public long? TownId { get; set; }
        public long? UserId { get; set; }
        public long? WspCompanyMainHistoryId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual HostingCompany? HostingCompany { get; set; }
        public virtual Municipality? Municipality { get; set; }
        public virtual Site? Sites { get; set; }
        public virtual StatssaAreaCode? StatsSaareaCode { get; set; }
        public virtual Town? Town { get; set; }
        public virtual User? User { get; set; }
        public virtual WspCompanyMainHistory? WspCompanyMainHistory { get; set; }
        public virtual ICollection<WspCompanyHistory> WspCompanyHistoryWspCompanyAddressHistoryPostals { get; set; }
        public virtual ICollection<WspCompanyHistory> WspCompanyHistoryWspCompanyAddressHistoryRegistereds { get; set; }
        public virtual ICollection<WspCompanyHistory> WspCompanyHistoryWspCompanyAddressHistoryResidentials { get; set; }
    }
}

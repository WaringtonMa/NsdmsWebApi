using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class AddressChangeAud
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public int? AddressEnum { get; set; }
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
        public string? Postcode { get; set; }
        public ulong? PrimaryAddr { get; set; }
        public ulong? SameAddress { get; set; }
        public int? Status { get; set; }
        public long? CompanyId { get; set; }
        public long? PostalAddressId { get; set; }
        public long? ResidentialAddressId { get; set; }
        public long? HostingCompanyId { get; set; }
        public int? MunicipalityId { get; set; }
        public long? SitesId { get; set; }
        public long? StatsSaareaCodeId { get; set; }
        public long? TownId { get; set; }
        public long? UserId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class TempAddress
    {
        public long Id { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? AddressLine4 { get; set; }
        public DateTime? CreateDate { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string? Postcode { get; set; }
        public ulong? PrimaryAddr { get; set; }
        public ulong? SameAddress { get; set; }
        public long? CompanyId { get; set; }
        public long? HostingCompanyId { get; set; }
        public int? MunicipalityId { get; set; }
        public long? UserId { get; set; }
        public long? SitesId { get; set; }
        public long? TownId { get; set; }
        public double? LatitudeDegrees { get; set; }
        public double? LatitudeMinutes { get; set; }
        public double? LatitudeSeconds { get; set; }
        public double? LongitudeDegrees { get; set; }
        public double? LongitudeMinutes { get; set; }
        public double? LongitudeSeconds { get; set; }
        public long? StatsSaareaCodeId { get; set; }
        public ulong? InitialValidation { get; set; }
        public ulong? WorkflowValidation { get; set; }
        public DateTime? ValidiationRanDate { get; set; }
        public long? CreateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? LastUpdateUser { get; set; }
    }
}

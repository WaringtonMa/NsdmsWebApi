using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class NlrdFile21
    {
        public long Id { get; set; }
        public string? CountryCode { get; set; }
        public DateTime? DateStamp { get; set; }
        public string? EtqaDecisionNumber { get; set; }
        public string? EtqaId { get; set; }
        public string? LatitudeDegree { get; set; }
        public string? LatitudeMinutes { get; set; }
        public string? LatitudeSeconds { get; set; }
        public string? LongitudeDegree { get; set; }
        public string? LongitudeMinutes { get; set; }
        public string? LongitudeSeconds { get; set; }
        public DateTime? ProviderAccreditEndDate { get; set; }
        public DateTime? ProviderAccreditStartDate { get; set; }
        public string? ProviderAccreditationNum { get; set; }
        public string? ProviderAddress1 { get; set; }
        public string? ProviderAddress2 { get; set; }
        public string? ProviderAddress3 { get; set; }
        public string? ProviderCode { get; set; }
        public string? ProviderContactCellNumber { get; set; }
        public string? ProviderContactEmailAddress { get; set; }
        public string? ProviderContactName { get; set; }
        public string? ProviderContactPhoneNumber { get; set; }
        public string? ProviderFaxNumber { get; set; }
        public string? ProviderName { get; set; }
        public string? ProviderPhoneNumber { get; set; }
        public string? ProviderPhysAddressPostCode { get; set; }
        public string? ProviderPhysicalAddress1 { get; set; }
        public string? ProviderPhysicalAddress2 { get; set; }
        public string? ProviderPhysicalAddressTown { get; set; }
        public string? ProviderPostalCode { get; set; }
        public string? ProviderSarsNumber { get; set; }
        public string? ProviderTypeId { get; set; }
        public string? ProviderWebAddress { get; set; }
        public string? ProviderEtqaId { get; set; }
        public string? ProvinceCode { get; set; }
        public string? StdIndustryClassCode { get; set; }
        public string? StructureStatusId { get; set; }
    }
}

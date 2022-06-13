using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SetmisFile100
    {
        public long Id { get; set; }
        public string? CountryCode { get; set; }
        public DateTime? DateStamp { get; set; }
        public string? EtqeDecisionNumber { get; set; }
        public string? LatitudeDegree { get; set; }
        public string? LatitudeMinutes { get; set; }
        public string? LatitudeSeconds { get; set; }
        public string? LongitudeDegree { get; set; }
        public string? LongitudeMinutes { get; set; }
        public string? LongitudeSeconds { get; set; }
        public string? ProviderAccreditationNum { get; set; }
        public string? ProviderClassId { get; set; }
        public string? ProviderCode { get; set; }
        public string? ProviderContactCellNumber { get; set; }
        public string? ProviderContactEmailAddress { get; set; }
        public string? ProviderContactName { get; set; }
        public string? ProviderContactPhoneNumber { get; set; }
        public string? ProviderEtqaId { get; set; }
        public DateTime? ProviderEndDate { get; set; }
        public string? ProviderFaxNumber { get; set; }
        public string? ProviderName { get; set; }
        public string? ProviderPhoneNumber { get; set; }
        public string? ProviderPhysicalAddress1 { get; set; }
        public string? ProviderPhysicalAddress2 { get; set; }
        public string? ProviderPhysicalAddress3 { get; set; }
        public string? ProviderPhysicalAddressCode { get; set; }
        public string? ProviderPostalAddress1 { get; set; }
        public string? ProviderPostalAddress2 { get; set; }
        public string? ProviderPostalAddress3 { get; set; }
        public string? ProviderPostalAddressCode { get; set; }
        public string? ProviderSarsNumber { get; set; }
        public DateTime? ProviderStartDate { get; set; }
        public string? ProviderStatusId { get; set; }
        public string? ProviderTypeId { get; set; }
        public string? ProviderWebAddress { get; set; }
        public string? ProvinceCode { get; set; }
        public string? SdlNo { get; set; }
        public string? SicCode { get; set; }
    }
}

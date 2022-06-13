using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SetmisFile200
    {
        public long Id { get; set; }
        public string? CountryCode { get; set; }
        public DateTime? DateStamp { get; set; }
        public DateTime? EmployerApprovalStatusEndDate { get; set; }
        public string? EmployerApprovalStatusId { get; set; }
        public string? EmployerApprovalStatusNum { get; set; }
        public DateTime? EmployerApprovalStatusStartDate { get; set; }
        public string? EmployerCompanyName { get; set; }
        public string? EmployerContactCellNumber { get; set; }
        public string? EmployerContactEmailAddress { get; set; }
        public string? EmployerContactName { get; set; }
        public string? EmployerContactPhoneNumber { get; set; }
        public string? EmployerFaxNumber { get; set; }
        public string? EmployerPhoneNumber { get; set; }
        public string? EmployerPhysicalAddress1 { get; set; }
        public string? EmployerPhysicalAddress2 { get; set; }
        public string? EmployerPhysicalAddress3 { get; set; }
        public string? EmployerPhysicalAddressCode { get; set; }
        public string? EmployerPostalAddress1 { get; set; }
        public string? EmployerPostalAddress2 { get; set; }
        public string? EmployerPostalAddress3 { get; set; }
        public string? EmployerPostalAddressCode { get; set; }
        public string? EmployerRegistrationNumber { get; set; }
        public string? EmployerTradingName { get; set; }
        public string? Filler01 { get; set; }
        public string? Filler02 { get; set; }
        public string? LatitudeDegree { get; set; }
        public string? LatitudeMinutes { get; set; }
        public string? LatitudeSeconds { get; set; }
        public string? LongitudeDegree { get; set; }
        public string? LongitudeMinutes { get; set; }
        public string? LongitudeSeconds { get; set; }
        public string? MainSdlNo { get; set; }
        public string? ProvinceCode { get; set; }
        public string? SdlNo { get; set; }
        public string? SetaId { get; set; }
        public string? SicCode { get; set; }
        public decimal? SiteNo { get; set; }
    }
}

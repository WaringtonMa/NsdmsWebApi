using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class QctoFile01
    {
        public long Id { get; set; }
        public string? AlternativeIdType { get; set; }
        public string? CitizenResidentStatusCode { get; set; }
        public DateTime? DateStamp { get; set; }
        public string? DisabilityRating { get; set; }
        public string? DisabilityStatusCode { get; set; }
        public string? EquityCode { get; set; }
        public string? GenderCode { get; set; }
        public string? HomeLanguageCode { get; set; }
        public string? ImmigrantStatus { get; set; }
        public string? LearnerAlternateId { get; set; }
        public DateTime? LearnerBirthDate { get; set; }
        public string? LearnerCellPhoneNumber { get; set; }
        public string? LearnerEmailAddress { get; set; }
        public string? LearnerFaxNumber { get; set; }
        public string? LearnerFirstName { get; set; }
        public string? LearnerHomeAddress1 { get; set; }
        public string? LearnerHomeAddress2 { get; set; }
        public string? LearnerHomeAddress3 { get; set; }
        public string? LearnerHomeAddressPostCode { get; set; }
        public string? LearnerLastName { get; set; }
        public string? LearnerMiddleName { get; set; }
        public string? LearnerPhoneNumber { get; set; }
        public string? LearnerPostalAddress1 { get; set; }
        public string? LearnerPostalAddress2 { get; set; }
        public string? LearnerPostalAddress3 { get; set; }
        public string? LearnerPostalAddressPostCode { get; set; }
        public string? LearnerTitle { get; set; }
        public string? NationalId { get; set; }
        public string? NationalityCode { get; set; }
        public string? PopiActAgree { get; set; }
        public DateTime? PopiActDate { get; set; }
        public string? ProvinceCode { get; set; }
        public string? SdpCode { get; set; }
        public string? SocioeconomicStatusCode { get; set; }
        public string? StatssaAreaCode { get; set; }
    }
}

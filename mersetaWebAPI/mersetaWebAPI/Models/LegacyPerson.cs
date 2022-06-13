using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyPerson
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? AlternateIdNo { get; set; }
        public string? AlternateIdType { get; set; }
        public string? AlternatePhoneNo { get; set; }
        public string? CellNo { get; set; }
        public string? CitizenStatusDesc { get; set; }
        public string? CommunicatingRatingId { get; set; }
        public string? DateCreated { get; set; }
        public string? DateModified { get; set; }
        public string? DateOfBirth { get; set; }
        public string? DisabilityDesc { get; set; }
        public string? DisabilityStatusOtherDescription { get; set; }
        public string? Email { get; set; }
        public string? EquityDesc { get; set; }
        public string? EthnicGroup { get; set; }
        public string? FaxNo { get; set; }
        public string? FirstName { get; set; }
        public string? GenderDesc { get; set; }
        public string? GeographicAreaDesc { get; set; }
        public string? HearingRatingId { get; set; }
        public string? IdNo { get; set; }
        public string? Initials { get; set; }
        public string? IsDisability { get; set; }
        public string? LangDesc { get; set; }
        public string? LkpHighestEducationDesc { get; set; }
        public string? MagisterialDistrict { get; set; }
        public string? MaidenName { get; set; }
        public string? MaritalStatus { get; set; }
        public string? MiddleNames { get; set; }
        public string? NationalityDesc { get; set; }
        public string? PersonId { get; set; }
        public string? PersonStatusEffectiveDate { get; set; }
        public string? PhoneNoBusiness { get; set; }
        public string? PhoneNoHome { get; set; }
        public string? RememberingRatingId { get; set; }
        public string? SeeingRatingId { get; set; }
        public string? SelfcareRatingId { get; set; }
        public string? SocioEcoStatusDesc { get; set; }
        public string? Surname { get; set; }
        public string? TitleDesc { get; set; }
        public string? WalkingRatingId { get; set; }
        public ulong? ValidAlternateIdNo { get; set; }
        public ulong? ValidIdNumber { get; set; }
        public ulong? AppearsOnHomeAffairsData { get; set; }
        public ulong? Processed { get; set; }
        public ulong? FullNamesMatchesOnHomeAffairsData { get; set; }
    }
}

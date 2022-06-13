using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacySectionTwentyEightTradeTest
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? ContractStatus { get; set; }
        public string? DateApplicationReceived { get; set; }
        public string? DateApplicationSent { get; set; }
        public string? DateCreated { get; set; }
        public string? DateLastChanged { get; set; }
        public string? FirstName { get; set; }
        public string? IdNo { get; set; }
        public string? MinTraining { get; set; }
        public string? N2Exempt { get; set; }
        public string? NumberOfTestAttempts { get; set; }
        public string? OfoCode { get; set; }
        public string? OfoDescription { get; set; }
        public string? OrganisationNameLegal { get; set; }
        public string? OrganisationNameTrade { get; set; }
        public string? SdlNo { get; set; }
        public string? SerialNumber { get; set; }
        public string? Status { get; set; }
        public string? Surname { get; set; }
        public string? TestDateFrom { get; set; }
        public string? TestDateTo { get; set; }
        public string? TradeDescription { get; set; }
        public string? TradeTestId { get; set; }
        public string? TradeTestLevel { get; set; }
        public string? WorkShopNo { get; set; }
        public ulong? AppearsOnHomeAffairsData { get; set; }
        public ulong? LegacyOrganisationSites { get; set; }
        public ulong? ValidRsaIdNumber { get; set; }
        public long? OfoCodesId { get; set; }
        public string? SaqaCode { get; set; }
        public long? QualificationId { get; set; }

        public virtual OfoCode? OfoCodes { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
    }
}

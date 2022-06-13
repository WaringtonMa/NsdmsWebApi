using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyDttcTrade
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? AccreditationEndDate { get; set; }
        public string? AccreditationStartDate { get; set; }
        public string? DttcStatus { get; set; }
        public string? LinkedSdl { get; set; }
        public string? OrganisationNameTrade { get; set; }
        public string? OrganisationNameLegal { get; set; }
        public string? QualificationCode { get; set; }
        public string? SdlNo { get; set; }
        public string? TradeDescription { get; set; }
        public ulong? AppearsOnHomeAffairsData { get; set; }
        public string? CompanyRegistrationNo { get; set; }
        public string? MersetaSkillsProgrammeRegistrationNumber { get; set; }
        public ulong? Processed { get; set; }
        public string? SaqaId { get; set; }
        public string? SicCode { get; set; }
        public string? SicCodeDescription { get; set; }
        public ulong? ValidRsaIdNumber { get; set; }
        public long? QualificationId { get; set; }
        public ulong? LinkedAccreditationNumberOnProviderAccreditation { get; set; }

        public virtual SaqaQualification? Qualification { get; set; }
    }
}

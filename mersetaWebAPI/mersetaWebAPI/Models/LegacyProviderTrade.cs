using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyProviderTrade
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? AccreditationEndDate { get; set; }
        public string? AccreditationNo { get; set; }
        public string? AccreditationStartDate { get; set; }
        public string? EtqaSetaDesc { get; set; }
        public ulong? LinkedAccreditationNumberOnProviderAccreditation { get; set; }
        public string? LinkedSdl { get; set; }
        public string? MersetaSkillsProgrammeRegNo { get; set; }
        public string? OrganisationNameLegal { get; set; }
        public string? OrganisationNameTrade { get; set; }
        public string? ProviderClass { get; set; }
        public string? ProviderIntExt { get; set; }
        public string? ProviderStatus { get; set; }
        public string? ProviderType { get; set; }
        public string? QualificationCode { get; set; }
        public string? SaqaUsId { get; set; }
        public string? SldNo { get; set; }
        public string? TradeDescription { get; set; }
        public long? QualificationId { get; set; }

        public virtual SaqaQualification? Qualification { get; set; }
    }
}

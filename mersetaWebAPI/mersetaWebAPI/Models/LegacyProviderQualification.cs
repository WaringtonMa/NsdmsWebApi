using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyProviderQualification
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
        public string? LinkedSdl { get; set; }
        public string? MersetaSkillsProgrammeRegNo { get; set; }
        public string? OrganisationNameLegal { get; set; }
        public string? OrganisationNameTrade { get; set; }
        public string? ProviderClass { get; set; }
        public string? ProviderIntExt { get; set; }
        public string? ProviderStatus { get; set; }
        public string? ProviderType { get; set; }
        public string? QualCode { get; set; }
        public string? SaqaUsId { get; set; }
        public string? SldNo { get; set; }
        public ulong? ApplicationSubmited { get; set; }
        public string? CompanyRegistrationNo { get; set; }
        public ulong? LinkedSdlNumberOnSarsEmployerFile { get; set; }
        public ulong? Processed { get; set; }
        public string? SicCode { get; set; }
        public string? SicCodeDescription { get; set; }
        public long? CompanyId { get; set; }
        public long? LegacyOrganisationSitesId { get; set; }
        public long? QualificationId { get; set; }
        public ulong? LinkedAccreditationNumberOnProviderAccreditation { get; set; }

        public virtual Company? Company { get; set; }
        public virtual LegacyOrganisationSite? LegacyOrganisationSites { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
    }
}

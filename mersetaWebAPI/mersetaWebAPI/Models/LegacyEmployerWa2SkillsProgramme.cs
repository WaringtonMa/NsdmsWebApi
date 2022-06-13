using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyEmployerWa2SkillsProgramme
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
        public string? ApplicationRecDate { get; set; }
        public string? ChamberDescription { get; set; }
        public string? CompanyRegistrationNo { get; set; }
        public string? DateCreated { get; set; }
        public string? EmailAddress { get; set; }
        public string? Fax { get; set; }
        public string? LinkedSdl { get; set; }
        public string? OfoCode { get; set; }
        public string? OrgCatSize { get; set; }
        public string? OrganisationNameLegal { get; set; }
        public string? OrganisationNameTrade { get; set; }
        public string? Phone { get; set; }
        public string? QualificationId { get; set; }
        public string? SProgrammeCode { get; set; }
        public string? SProgrammeDesc { get; set; }
        public string? SdlNo { get; set; }
        public string? SicCode { get; set; }
        public string? SicCodeDescription { get; set; }
        public string? WaEmployerStatus { get; set; }
        public string? LinkedSdlNumber { get; set; }
        public ulong? Processed { get; set; }
        public long? LegacyOrganisationSitesId { get; set; }
        public ulong? LinkedAccreditationNumberOnProviderAccreditation { get; set; }
        public long? SkillsProgramId { get; set; }
        public ulong? Submitted { get; set; }

        public virtual LegacyOrganisationSite? LegacyOrganisationSites { get; set; }
        public virtual SkillsProgram? SkillsProgram { get; set; }
    }
}

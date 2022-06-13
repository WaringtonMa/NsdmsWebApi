using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyEmployerWa2UnitStandard
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? AccreditationStartDate { get; set; }
        public string? ApplicationRecDate { get; set; }
        public string? ChamberDescription { get; set; }
        public string? CompanyRegistrationNo { get; set; }
        public string? DateCreated { get; set; }
        public string? EmailAddress { get; set; }
        public string? Fax { get; set; }
        public string? LinkedSdl { get; set; }
        public string? OrgCatSize { get; set; }
        public string? OrganisationNameLegal { get; set; }
        public string? OrganisationNameTrade { get; set; }
        public string? Phone { get; set; }
        public ulong? Processed { get; set; }
        public string? SdlNo { get; set; }
        public string? SicCode { get; set; }
        public string? SicCodeDescription { get; set; }
        public ulong? Submitted { get; set; }
        public string? UnitStdCode { get; set; }
        public string? UnitStdDesc { get; set; }
        public string? WaEmployerStatus { get; set; }
        public long? LegacyOrganisationSitesId { get; set; }

        public virtual LegacyOrganisationSite? LegacyOrganisationSites { get; set; }
    }
}

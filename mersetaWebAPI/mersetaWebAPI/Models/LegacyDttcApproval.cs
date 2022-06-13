using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyDttcApproval
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? LinkedSdl { get; set; }
        public string? AccreditationEndDate { get; set; }
        public string? AccreditationStartDate { get; set; }
        public string? ApplicationRecDate { get; set; }
        public string? ApprovalNumber { get; set; }
        public string? DateCreated { get; set; }
        public string? DttcId { get; set; }
        public string? DttcStatus { get; set; }
        public string? LastDateChanged { get; set; }
        public string? NoOfEmployees { get; set; }
        public string? OrganisationNameLegal { get; set; }
        public string? OprganisationNameTrade { get; set; }
        public string? SRefNo { get; set; }
        public string? SdlNo { get; set; }
        public ulong? MainSdlNumberOnSarsEmployerFile { get; set; }
        public ulong? Processed { get; set; }
        public long? CompanyId { get; set; }
        public long? LegacyOrganisationSitesId { get; set; }
        public ulong? CheckCountByRefNumber { get; set; }
        public ulong? LegacyOrganisationNonLevyPaying { get; set; }
        public ulong? LegacyOrganisationSites { get; set; }

        public virtual Company? Company { get; set; }
        public virtual LegacyOrganisationSite? LegacyOrganisationSitesNavigation { get; set; }
    }
}

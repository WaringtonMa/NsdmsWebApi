using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyEmployerWa2Workplace
    {
        public LegacyEmployerWa2Workplace()
        {
            WorkPlaceApprovals = new HashSet<WorkPlaceApproval>();
        }

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
        public string? DateCreated { get; set; }
        public string? LastDateChanged { get; set; }
        public string? LinkedSdl { get; set; }
        public string? OrganisationNameLegal { get; set; }
        public string? OrganisationNameTrade { get; set; }
        public string? SdlNo { get; set; }
        public string? WaEmployerId { get; set; }
        public string? WaEmployerStatus { get; set; }
        public ulong? AppearsOnHomeAffairsData { get; set; }
        public ulong? Processed { get; set; }
        public long? LegacyOrganisationSitesId { get; set; }
        public long? QualificationId { get; set; }
        public ulong? CheckCountByRefNumber { get; set; }
        public ulong? LegacyOrganisationNonLevyPaying { get; set; }
        public ulong? LegacyOrganisationSites { get; set; }
        public ulong? Submitted { get; set; }

        public virtual LegacyOrganisationSite? LegacyOrganisationSitesNavigation { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovals { get; set; }
    }
}

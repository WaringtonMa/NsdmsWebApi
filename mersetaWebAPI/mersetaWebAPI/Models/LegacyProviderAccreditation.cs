using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyProviderAccreditation
    {
        public LegacyProviderAccreditation()
        {
            LegacyProviderApplicationAlterationAudits = new HashSet<LegacyProviderApplicationAlterationAudit>();
            TrainingProviderApplications = new HashSet<TrainingProviderApplication>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? LastDateChanged { get; set; }
        public string? AccreditationEndDate { get; set; }
        public string? AccreditationNo { get; set; }
        public string? AccreditationStartDate { get; set; }
        public string? ApplicationRecDate { get; set; }
        public string? EtqaDecisionNo { get; set; }
        public string? IThisEtqa { get; set; }
        public string? LinkedSdl { get; set; }
        public string? OrganisationNameLegal { get; set; }
        public string? OrganisationNameTrade { get; set; }
        public string? ProviderClass { get; set; }
        public string? ProviderId { get; set; }
        public string? ProviderIntExt { get; set; }
        public string? ProviderStatus { get; set; }
        public string? ProviderStatusEffectiveDate { get; set; }
        public string? ProviderType { get; set; }
        public string? SEtqa { get; set; }
        public string? SSaqaRefNo { get; set; }
        public string? SdlNumber { get; set; }
        public ulong? CheckCountByRefNumber { get; set; }
        public ulong? LegacyOrganisationNonLevyPaying { get; set; }
        public ulong? LegacyOrganisationSites { get; set; }
        public ulong? DuplicateAccNumber { get; set; }
        public ulong? ValidStatus { get; set; }
        public string? LegacyOrganisationSitesLinkedSdl { get; set; }
        public string? LegacyOrganisationSitesMainSdl { get; set; }

        public virtual ICollection<LegacyProviderApplicationAlterationAudit> LegacyProviderApplicationAlterationAudits { get; set; }
        public virtual ICollection<TrainingProviderApplication> TrainingProviderApplications { get; set; }
    }
}

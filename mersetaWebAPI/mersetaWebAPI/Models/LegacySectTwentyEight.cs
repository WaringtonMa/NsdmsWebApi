using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacySectTwentyEight
    {
        public LegacySectTwentyEight()
        {
            CompanyLearnersTradeTests = new HashSet<CompanyLearnersTradeTest>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? AlternateIdNo { get; set; }
        public string? ApprenticeshipEndDate { get; set; }
        public string? ApprenticeshipId { get; set; }
        public string? ApprenticeshipStartDate { get; set; }
        public string? ApprenticeshipStatusEffectiveDate { get; set; }
        public string? CertificateNumber { get; set; }
        public string? ChamberCode { get; set; }
        public string? CurrentPreviousEmp { get; set; }
        public string? DateCertificateCreated { get; set; }
        public string? DateCreated { get; set; }
        public string? DateLastChanged { get; set; }
        public string? Description { get; set; }
        public string? DgTag { get; set; }
        public string? FirstName { get; set; }
        public string? FundingStatus { get; set; }
        public string? IdNo { get; set; }
        public string? LearnerStatusEffectiveDate { get; set; }
        public string? MagisterialDistrict { get; set; }
        public string? MinTraining { get; set; }
        public string? MunicipalityName { get; set; }
        public string? NTwo { get; set; }
        public string? OrganisationNameLegal { get; set; }
        public string? Region { get; set; }
        public string? SdlNo { get; set; }
        public string? SetaRegion { get; set; }
        public string? SocioEcoStatusDesc { get; set; }
        public string? Surname { get; set; }
        public string? TradeDescription { get; set; }
        public string? WaLegalName { get; set; }
        public string? Wasdl { get; set; }
        public ulong? AppearsOnHomeAffairsData { get; set; }
        public ulong? Processed { get; set; }
        public string? SaqaCode { get; set; }
        public ulong? ValidRsaIdNumber { get; set; }
        public long? LegacyOrganisationSitesId { get; set; }
        public long? QualificationId { get; set; }
        public ulong? LegacyOrganisationSites { get; set; }
        public ulong? CreatedCompanyLearner { get; set; }
        public string? DateApplicationSent { get; set; }
        public string? OfoCode { get; set; }
        public string? OfoDescription { get; set; }
        public string? SerialNumber { get; set; }
        public string? TestDateFrom { get; set; }
        public string? TestDateTo { get; set; }
        public string? WorkShopNo { get; set; }
        public long? OfoCodesId { get; set; }
        public long? CompanyId { get; set; }
        public long? EmployerId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual Company? Employer { get; set; }
        public virtual LegacyOrganisationSite? LegacyOrganisationSitesNavigation { get; set; }
        public virtual OfoCode? OfoCodes { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTests { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyApprenticeship
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? AgreementNumber { get; set; }
        public string? AlternateId { get; set; }
        public string? ApprenticeshipType { get; set; }
        public string? CertificateDate { get; set; }
        public string? CertificateNumber { get; set; }
        public string? ContractNumber { get; set; }
        public string? ContractStatus { get; set; }
        public string? DateCreated { get; set; }
        public string? DateLastChanged { get; set; }
        public string? FirstName { get; set; }
        public string? FromDate { get; set; }
        public string? Id2 { get; set; }
        public string? IdNo { get; set; }
        public string? LastDateChanged { get; set; }
        public string? MagisterialDistrict { get; set; }
        public string? MiddleNames { get; set; }
        public string? MinTraining { get; set; }
        public string? N2 { get; set; }
        public string? OfoCode { get; set; }
        public string? OfoDescription { get; set; }
        public string? OrganisationNameLegal { get; set; }
        public string? OrganisationNameTrade { get; set; }
        public string? ProjectType { get; set; }
        public string? Region { get; set; }
        public string? SdlNo { get; set; }
        public string? SetaRegion { get; set; }
        public string? SocioEcoStatusDesc { get; set; }
        public string? StatusDate { get; set; }
        public string? Surname { get; set; }
        public string? ToDate { get; set; }
        public string? TradeDescription { get; set; }
        public string? WaLegalName { get; set; }
        public string? WaeMpSdl { get; set; }
        public string? ApprenticeshipRegisterDate { get; set; }
        public ulong? RsaIdNumberAppearsOnApprenticeshipTradeTest { get; set; }
        public ulong? ValidRsaIdNumber { get; set; }
        public ulong? AppearsOnHomeAffairsData { get; set; }
        public ulong? Processed { get; set; }
        public long? LegacyOrganisationSitesId { get; set; }
        public long? QualificationId { get; set; }
        public ulong? LegacyOrganisationSites { get; set; }
        public string? QualCode { get; set; }
        public long? OfoCodesId { get; set; }
        public ulong? CreatedCompanyLearner { get; set; }
        public long? CompanyId { get; set; }
        public long? EmployerId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual Company? Employer { get; set; }
        public virtual LegacyOrganisationSite? LegacyOrganisationSitesNavigation { get; set; }
        public virtual OfoCode? OfoCodes { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
    }
}

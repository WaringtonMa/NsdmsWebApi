using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyExperiential
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? Amount { get; set; }
        public string? ApplicationDate { get; set; }
        public string? CompletionDate { get; set; }
        public string? DateCreated { get; set; }
        public string? DateUpdated { get; set; }
        public string? DgTag { get; set; }
        public string? EmployerSdl { get; set; }
        public string? EndDate { get; set; }
        public string? FirstName { get; set; }
        public string? FundingStatus { get; set; }
        public string? Id2 { get; set; }
        public string? IdNo { get; set; }
        public string? LearnershipTitle { get; set; }
        public string? LearningAreaOther { get; set; }
        public string? MiddleNames { get; set; }
        public string? NqfLevel { get; set; }
        public string? OfoCode { get; set; }
        public string? OrganisationNameLegal { get; set; }
        public string? OrganisationNameTrade { get; set; }
        public string? OtherProvider { get; set; }
        public string? PartnerLegalName { get; set; }
        public string? PartnerTradeName { get; set; }
        public string? PartnershipSdl { get; set; }
        public string? PracticalTraining { get; set; }
        public string? PracticalTrainingOther { get; set; }
        public string? Provider { get; set; }
        public string? ProviderType { get; set; }
        public string? RegistrationDate { get; set; }
        public string? SkillPriority { get; set; }
        public string? SspNeedsId { get; set; }
        public string? StartDate { get; set; }
        public string? Status { get; set; }
        public string? Surname { get; set; }
        public string? LearningArea { get; set; }
        public ulong? AppearsOnHomeAffairsData { get; set; }
        public ulong? Processed { get; set; }
        public string? SaqaId { get; set; }
        public ulong? ValidRsaIdNumber { get; set; }
        public long? LegacyOrganisationSitesId { get; set; }
        public long? QualificationId { get; set; }
        public ulong? LegacyOrganisationSites { get; set; }
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

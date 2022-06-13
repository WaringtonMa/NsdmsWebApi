using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyLearnership
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? AgreementEndDate { get; set; }
        public string? AgreementId { get; set; }
        public string? AgreementRefNo { get; set; }
        public string? AgreementStartDate { get; set; }
        public string? AgreementStatusDesc { get; set; }
        public string? AgreementStatusEffectiveDate { get; set; }
        public string? AlternateId { get; set; }
        public string? CaptureDate { get; set; }
        public string? Created { get; set; }
        public string? DolOrganisationNameLegal { get; set; }
        public string? DurationLearnerEmployed { get; set; }
        public string? EmployerSdl { get; set; }
        public string? FirstName { get; set; }
        public string? Funded { get; set; }
        public string? IdNo { get; set; }
        public string? LastDateChanged { get; set; }
        public string? LearnerEmployed { get; set; }
        public string? LearnershipCode { get; set; }
        public string? LearnershipTitle { get; set; }
        public string? LShipCode { get; set; }
        public string? MiddleNames { get; set; }
        public string? OrganisationNameLegal { get; set; }
        public string? OrganisationNameTrade { get; set; }
        public string? PrevLearnerhipCode { get; set; }
        public string? PrevLearnershipTitle { get; set; }
        public string? PreviousEmployed { get; set; }
        public string? PreviousLearnership { get; set; }
        public string? ProjectType { get; set; }
        public string? ProviderSdl { get; set; }
        public string? RegistrationDate { get; set; }
        public string? SocioEcoStatusDesc { get; set; }
        public string? Surname { get; set; }
        public ulong? Processed { get; set; }
        public long? LegacyOrganisationSitesId { get; set; }
        public ulong? AppearsOnHomeAffairsData { get; set; }
        public ulong? LegacyOrganisationSites { get; set; }
        public ulong? LegacyProviderExists { get; set; }
        public ulong? ValidRsaIdNumber { get; set; }
        public long? LearnershipId { get; set; }
        public ulong? CreatedCompanyLearner { get; set; }
        public string? AccreditationNumber { get; set; }
        public long? EmployerId { get; set; }
        public long? TrainingProviderApplicationId { get; set; }

        public virtual Company? Employer { get; set; }
        public virtual Learnership? Learnership { get; set; }
        public virtual LegacyOrganisationSite? LegacyOrganisationSitesNavigation { get; set; }
        public virtual TrainingProviderApplication? TrainingProviderApplication { get; set; }
    }
}

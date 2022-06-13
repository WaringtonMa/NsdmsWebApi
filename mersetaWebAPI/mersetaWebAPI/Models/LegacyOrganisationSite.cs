using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyOrganisationSite
    {
        public LegacyOrganisationSite()
        {
            LegacyApprenticeshipTradeTests = new HashSet<LegacyApprenticeshipTradeTest>();
            LegacyApprenticeships = new HashSet<LegacyApprenticeship>();
            LegacyBursaries = new HashSet<LegacyBursary>();
            LegacyDttcApprovals = new HashSet<LegacyDttcApproval>();
            LegacyEmployerWa2Qualifications = new HashSet<LegacyEmployerWa2Qualification>();
            LegacyEmployerWa2SkillsProgrammes = new HashSet<LegacyEmployerWa2SkillsProgramme>();
            LegacyEmployerWa2UnitStandards = new HashSet<LegacyEmployerWa2UnitStandard>();
            LegacyEmployerWa2Workplaces = new HashSet<LegacyEmployerWa2Workplace>();
            LegacyExperientials = new HashSet<LegacyExperiential>();
            LegacyInternships = new HashSet<LegacyInternship>();
            LegacyLearnerships = new HashSet<LegacyLearnership>();
            LegacyProviderQualifications = new HashSet<LegacyProviderQualification>();
            LegacySectTwentyEights = new HashSet<LegacySectTwentyEight>();
            LegacySkillsProgrammeAssessments = new HashSet<LegacySkillsProgrammeAssessment>();
            LegacySkillsProgrammes = new HashSet<LegacySkillsProgramme>();
            Sites = new HashSet<Site>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? SicCode { get; set; }
        public string? AnnualTurnover { get; set; }
        public string? BbbeeFour { get; set; }
        public string? BbbeeOne { get; set; }
        public string? BbbeeThree { get; set; }
        public string? BbbeeTwo { get; set; }
        public string? ChamberDescription { get; set; }
        public string? CollegeId { get; set; }
        public string? CommunicationStatus { get; set; }
        public string? CompRegYear { get; set; }
        public string? CompanyRegistrationNo { get; set; }
        public string? CompanyRegistrationNoTwo { get; set; }
        public string? CompanyYearsTrading { get; set; }
        public string? ConfirmSicCode { get; set; }
        public string? CoreBusiness { get; set; }
        public string? CoreBusinessDesc { get; set; }
        public string? DateCreated { get; set; }
        public string? DeleteStatus { get; set; }
        public string? Description { get; set; }
        public ulong? DuplicateSiteNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? EntityType { get; set; }
        public string? Fax { get; set; }
        public string? FinancialYearEnd { get; set; }
        public string? FinancialYearStart { get; set; }
        public string? GeographicAreaDesc { get; set; }
        public string? Institution { get; set; }
        public string? InterSetaTransfer { get; set; }
        public string? IsBee { get; set; }
        public string? IsCbo { get; set; }
        public string? IsNgo { get; set; }
        public string? IsNew { get; set; }
        public string? IsSTwentyOne { get; set; }
        public string? LastDateChanged { get; set; }
        public string? LegalStatus { get; set; }
        public string? LinkedOrganisationId { get; set; }
        public string? LinkedSdl { get; set; }
        public string? LinkedSdlNumber { get; set; }
        public ulong? LinkedSdlNumberOnSarsEmployerFile { get; set; }
        public string? MagisterialDistrict { get; set; }
        public string? MainBusinessActivity { get; set; }
        public string? MainBusinessActivityTwo { get; set; }
        public string? MainSdl { get; set; }
        public ulong? MainSdlNumberOnSarsEmployerFile { get; set; }
        public string? NonLevyNumber { get; set; }
        public string? NqfLevel { get; set; }
        public string? OrgCatSize { get; set; }
        public string? OrgCategoryDesc { get; set; }
        public string? OrganisationId { get; set; }
        public string? OrganisationNameLegal { get; set; }
        public string? OrganisationNameTrade { get; set; }
        public string? OrganisationStatusEffectiveDate { get; set; }
        public string? PartnershipDesc { get; set; }
        public string? PayeNo { get; set; }
        public string? Payroll { get; set; }
        public string? Phone { get; set; }
        public string? PossibleSdlNo { get; set; }
        public ulong? Processed { get; set; }
        public string? Province { get; set; }
        public string? RegCiproNo { get; set; }
        public string? RegDate { get; set; }
        public string? Region { get; set; }
        public string? RegistrationYear { get; set; }
        public string? SarsRegistrationNo { get; set; }
        public string? SdlNumber { get; set; }
        public ulong? SdlNumberOnSarsEmployerFile { get; set; }
        public string? Sector { get; set; }
        public string? SetaStatus { get; set; }
        public string? SicCodeChamber { get; set; }
        public string? SicCodeDescription { get; set; }
        public string? SmsChamber { get; set; }
        public string? SubSector { get; set; }
        public string? TotalEmployment { get; set; }
        public string? UifNumber { get; set; }
        public string? UnionAgreement { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? YearsTrading { get; set; }
        public long? CompanyId { get; set; }
        public ulong? Submitted { get; set; }

        public virtual Company? Company { get; set; }
        public virtual ICollection<LegacyApprenticeshipTradeTest> LegacyApprenticeshipTradeTests { get; set; }
        public virtual ICollection<LegacyApprenticeship> LegacyApprenticeships { get; set; }
        public virtual ICollection<LegacyBursary> LegacyBursaries { get; set; }
        public virtual ICollection<LegacyDttcApproval> LegacyDttcApprovals { get; set; }
        public virtual ICollection<LegacyEmployerWa2Qualification> LegacyEmployerWa2Qualifications { get; set; }
        public virtual ICollection<LegacyEmployerWa2SkillsProgramme> LegacyEmployerWa2SkillsProgrammes { get; set; }
        public virtual ICollection<LegacyEmployerWa2UnitStandard> LegacyEmployerWa2UnitStandards { get; set; }
        public virtual ICollection<LegacyEmployerWa2Workplace> LegacyEmployerWa2Workplaces { get; set; }
        public virtual ICollection<LegacyExperiential> LegacyExperientials { get; set; }
        public virtual ICollection<LegacyInternship> LegacyInternships { get; set; }
        public virtual ICollection<LegacyLearnership> LegacyLearnerships { get; set; }
        public virtual ICollection<LegacyProviderQualification> LegacyProviderQualifications { get; set; }
        public virtual ICollection<LegacySectTwentyEight> LegacySectTwentyEights { get; set; }
        public virtual ICollection<LegacySkillsProgrammeAssessment> LegacySkillsProgrammeAssessments { get; set; }
        public virtual ICollection<LegacySkillsProgramme> LegacySkillsProgrammes { get; set; }
        public virtual ICollection<Site> Sites { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacySkillsProgrammeAssessment
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? AlternateId { get; set; }
        public string? DtEffectiveDate { get; set; }
        public string? DtEndDate { get; set; }
        public string? DtLastDateChanged { get; set; }
        public string? DtStartDate { get; set; }
        public string? EmployerSdl { get; set; }
        public string? FirstName { get; set; }
        public string? IdNo { get; set; }
        public string? LearnerLpStatusDesc { get; set; }
        public string? MiddleNames { get; set; }
        public string? OrganisationNameLegal { get; set; }
        public string? OrganisationNameTrade { get; set; }
        public string? PkiLearnerLpId { get; set; }
        public string? ProjectType { get; set; }
        public string? ProviderLegalName { get; set; }
        public string? ProviderSdl { get; set; }
        public string? ProviderTradeName { get; set; }
        public string? SProgrammeCode { get; set; }
        public string? SProgrammeDesc { get; set; }
        public string? SRefNo { get; set; }
        public string? SocioEcoStatusDesc { get; set; }
        public string? Surname { get; set; }
        public string? AgreementUnitStdStatusDesc { get; set; }
        public ulong? AppearsOnHomeAffairsData { get; set; }
        public string? AssessorFirstName { get; set; }
        public string? AssessorId { get; set; }
        public string? AssessorRegNo { get; set; }
        public string? AssessorSurname { get; set; }
        public string? DtAssessment { get; set; }
        public string? HologramNumber { get; set; }
        public string? PkiLearnerAssessmentId { get; set; }
        public ulong? Processed { get; set; }
        public string? UnitStdCode { get; set; }
        public string? UnitStdDesc { get; set; }
        public ulong? ValidIdNumber { get; set; }
        public ulong? ValidRsaIdNumber { get; set; }
        public long? LegacyOrganisationSitesId { get; set; }
        public long? QualificationId { get; set; }
        public ulong? AppearsAccreditationData { get; set; }
        public long? SkillsProgramId { get; set; }

        public virtual LegacyOrganisationSite? LegacyOrganisationSites { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual SkillsProgram? SkillsProgram { get; set; }
    }
}

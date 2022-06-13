using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SkillsProgram
    {
        public SkillsProgram()
        {
            CompanyLearners = new HashSet<CompanyLearner>();
            CompanyLearnersChanges = new HashSet<CompanyLearnersChange>();
            CompanyLearnersDetailsChanges = new HashSet<CompanyLearnersDetailsChange>();
            LearnershipDevelopmentRegistrations = new HashSet<LearnershipDevelopmentRegistration>();
            LegacyAssessorSkillsProgrammes = new HashSet<LegacyAssessorSkillsProgramme>();
            LegacyDttcSkillsProgrammes = new HashSet<LegacyDttcSkillsProgramme>();
            LegacyEmployerWa2SkillsProgrammes = new HashSet<LegacyEmployerWa2SkillsProgramme>();
            LegacyModeratorSkillsProgrammes = new HashSet<LegacyModeratorSkillsProgramme>();
            LegacyProviderApplicationAlterationAudits = new HashSet<LegacyProviderApplicationAlterationAudit>();
            LegacyProviderSkillsProgrammes = new HashSet<LegacyProviderSkillsProgramme>();
            LegacySkillsProgrammeAssessments = new HashSet<LegacySkillsProgrammeAssessment>();
            LegacySkillsProgrammes = new HashSet<LegacySkillsProgramme>();
            MandatoryGrantDetailArchives = new HashSet<MandatoryGrantDetailArchive>();
            MandatoryGrantDetails = new HashSet<MandatoryGrantDetail>();
            MandatoryGrantRecommendations = new HashSet<MandatoryGrantRecommendation>();
            MandatoryGrants = new HashSet<MandatoryGrant>();
            MgVerificationDetails = new HashSet<MgVerificationDetail>();
            SdpExtensionOfScopes = new HashSet<SdpExtensionOfScope>();
            SkillsProgramUnitStandards = new HashSet<SkillsProgramUnitStandard>();
            SummativeAssessmentReports = new HashSet<SummativeAssessmentReport>();
            TrainingProviderApplications = new HashSet<TrainingProviderApplication>();
            TrainingProviderSkillsPrograms = new HashSet<TrainingProviderSkillsProgram>();
            UserSkillsProgrammes = new HashSet<UserSkillsProgramme>();
            WorkPlaceApprovalData = new HashSet<WorkPlaceApprovalDatum>();
            WorkPlaceApprovalSkillsPrograms = new HashSet<WorkPlaceApprovalSkillsProgram>();
            WorkPlaceApprovals = new HashSet<WorkPlaceApproval>();
            WorkplaceMonitoringLearnerInductions = new HashSet<WorkplaceMonitoringLearnerInduction>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public int? Credits { get; set; }
        public string? Description { get; set; }
        public int? Duration { get; set; }
        public string? ProgrammeId { get; set; }
        public long? NetqaId { get; set; }
        public long? QualificationId { get; set; }
        public string? SmsCode { get; set; }
        public string? RegistrationNumber { get; set; }

        public virtual Etqa? Netqa { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearners { get; set; }
        public virtual ICollection<CompanyLearnersChange> CompanyLearnersChanges { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChanges { get; set; }
        public virtual ICollection<LearnershipDevelopmentRegistration> LearnershipDevelopmentRegistrations { get; set; }
        public virtual ICollection<LegacyAssessorSkillsProgramme> LegacyAssessorSkillsProgrammes { get; set; }
        public virtual ICollection<LegacyDttcSkillsProgramme> LegacyDttcSkillsProgrammes { get; set; }
        public virtual ICollection<LegacyEmployerWa2SkillsProgramme> LegacyEmployerWa2SkillsProgrammes { get; set; }
        public virtual ICollection<LegacyModeratorSkillsProgramme> LegacyModeratorSkillsProgrammes { get; set; }
        public virtual ICollection<LegacyProviderApplicationAlterationAudit> LegacyProviderApplicationAlterationAudits { get; set; }
        public virtual ICollection<LegacyProviderSkillsProgramme> LegacyProviderSkillsProgrammes { get; set; }
        public virtual ICollection<LegacySkillsProgrammeAssessment> LegacySkillsProgrammeAssessments { get; set; }
        public virtual ICollection<LegacySkillsProgramme> LegacySkillsProgrammes { get; set; }
        public virtual ICollection<MandatoryGrantDetailArchive> MandatoryGrantDetailArchives { get; set; }
        public virtual ICollection<MandatoryGrantDetail> MandatoryGrantDetails { get; set; }
        public virtual ICollection<MandatoryGrantRecommendation> MandatoryGrantRecommendations { get; set; }
        public virtual ICollection<MandatoryGrant> MandatoryGrants { get; set; }
        public virtual ICollection<MgVerificationDetail> MgVerificationDetails { get; set; }
        public virtual ICollection<SdpExtensionOfScope> SdpExtensionOfScopes { get; set; }
        public virtual ICollection<SkillsProgramUnitStandard> SkillsProgramUnitStandards { get; set; }
        public virtual ICollection<SummativeAssessmentReport> SummativeAssessmentReports { get; set; }
        public virtual ICollection<TrainingProviderApplication> TrainingProviderApplications { get; set; }
        public virtual ICollection<TrainingProviderSkillsProgram> TrainingProviderSkillsPrograms { get; set; }
        public virtual ICollection<UserSkillsProgramme> UserSkillsProgrammes { get; set; }
        public virtual ICollection<WorkPlaceApprovalDatum> WorkPlaceApprovalData { get; set; }
        public virtual ICollection<WorkPlaceApprovalSkillsProgram> WorkPlaceApprovalSkillsPrograms { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovals { get; set; }
        public virtual ICollection<WorkplaceMonitoringLearnerInduction> WorkplaceMonitoringLearnerInductions { get; set; }
    }
}

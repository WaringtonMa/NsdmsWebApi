using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SkillsSet
    {
        public SkillsSet()
        {
            CompanyLearners = new HashSet<CompanyLearner>();
            CompanyLearnersChanges = new HashSet<CompanyLearnersChange>();
            CompanyLearnersDetailsChanges = new HashSet<CompanyLearnersDetailsChange>();
            LearnershipDevelopmentRegistrations = new HashSet<LearnershipDevelopmentRegistration>();
            LegacyProviderApplicationAlterationAudits = new HashSet<LegacyProviderApplicationAlterationAudit>();
            LegacyProviderSkillsProgrammes = new HashSet<LegacyProviderSkillsProgramme>();
            LegacySkillsProgrammes = new HashSet<LegacySkillsProgramme>();
            MandatoryGrantDetailArchives = new HashSet<MandatoryGrantDetailArchive>();
            MandatoryGrantDetails = new HashSet<MandatoryGrantDetail>();
            MandatoryGrantRecommendations = new HashSet<MandatoryGrantRecommendation>();
            MandatoryGrants = new HashSet<MandatoryGrant>();
            MgVerificationDetails = new HashSet<MgVerificationDetail>();
            SkillsSetUnitStandards = new HashSet<SkillsSetUnitStandard>();
            SummativeAssessmentReports = new HashSet<SummativeAssessmentReport>();
            TrainingProviderApplications = new HashSet<TrainingProviderApplication>();
            TrainingProviderSkillsSets = new HashSet<TrainingProviderSkillsSet>();
            WorkPlaceApprovalSkillsSets = new HashSet<WorkPlaceApprovalSkillsSet>();
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
        public virtual ICollection<LegacyProviderApplicationAlterationAudit> LegacyProviderApplicationAlterationAudits { get; set; }
        public virtual ICollection<LegacyProviderSkillsProgramme> LegacyProviderSkillsProgrammes { get; set; }
        public virtual ICollection<LegacySkillsProgramme> LegacySkillsProgrammes { get; set; }
        public virtual ICollection<MandatoryGrantDetailArchive> MandatoryGrantDetailArchives { get; set; }
        public virtual ICollection<MandatoryGrantDetail> MandatoryGrantDetails { get; set; }
        public virtual ICollection<MandatoryGrantRecommendation> MandatoryGrantRecommendations { get; set; }
        public virtual ICollection<MandatoryGrant> MandatoryGrants { get; set; }
        public virtual ICollection<MgVerificationDetail> MgVerificationDetails { get; set; }
        public virtual ICollection<SkillsSetUnitStandard> SkillsSetUnitStandards { get; set; }
        public virtual ICollection<SummativeAssessmentReport> SummativeAssessmentReports { get; set; }
        public virtual ICollection<TrainingProviderApplication> TrainingProviderApplications { get; set; }
        public virtual ICollection<TrainingProviderSkillsSet> TrainingProviderSkillsSets { get; set; }
        public virtual ICollection<WorkPlaceApprovalSkillsSet> WorkPlaceApprovalSkillsSets { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovals { get; set; }
        public virtual ICollection<WorkplaceMonitoringLearnerInduction> WorkplaceMonitoringLearnerInductions { get; set; }
    }
}

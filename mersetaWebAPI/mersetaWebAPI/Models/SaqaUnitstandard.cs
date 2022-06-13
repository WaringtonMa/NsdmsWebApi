using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SaqaUnitstandard
    {
        public SaqaUnitstandard()
        {
            CompanyLearners = new HashSet<CompanyLearner>();
            CompanyLearnersChanges = new HashSet<CompanyLearnersChange>();
            CompanyLearnersDetailsChanges = new HashSet<CompanyLearnersDetailsChange>();
            CompanyUnitStandards = new HashSet<CompanyUnitStandard>();
            CoursewareDistibutions = new HashSet<CoursewareDistibution>();
            LearnershipDevelopmentRegistrations = new HashSet<LearnershipDevelopmentRegistration>();
            LearnershipUnitStandards = new HashSet<LearnershipUnitStandard>();
            LegacyAssessorUnitStandards = new HashSet<LegacyAssessorUnitStandard>();
            LegacyDttcUnitStandards = new HashSet<LegacyDttcUnitStandard>();
            LegacyLearnershipAssessment2s = new HashSet<LegacyLearnershipAssessment2>();
            LegacyLearnershipAssessment3s = new HashSet<LegacyLearnershipAssessment3>();
            LegacyModeratorUnitStandards = new HashSet<LegacyModeratorUnitStandard>();
            LegacyProviderApplicationAlterationAudits = new HashSet<LegacyProviderApplicationAlterationAudit>();
            LegacyProviderUnitStandards = new HashSet<LegacyProviderUnitStandard>();
            LegacyUnitStandardAssessments = new HashSet<LegacyUnitStandardAssessment>();
            LegacyUnitStandards = new HashSet<LegacyUnitStandard>();
            MandatoryGrantDetailArchives = new HashSet<MandatoryGrantDetailArchive>();
            MandatoryGrantDetails = new HashSet<MandatoryGrantDetail>();
            MandatoryGrantRecommendations = new HashSet<MandatoryGrantRecommendation>();
            MandatoryGrants = new HashSet<MandatoryGrant>();
            MgVerificationDetails = new HashSet<MgVerificationDetail>();
            ModulesUnitStandards = new HashSet<ModulesUnitStandard>();
            QualificationUnitStandards = new HashSet<QualificationUnitStandard>();
            SaqaSpecificOutcomes = new HashSet<SaqaSpecificOutcome>();
            SkillsProgramUnitStandards = new HashSet<SkillsProgramUnitStandard>();
            SkillsRegistrationQualificationUnitStandards = new HashSet<SkillsRegistrationQualificationUnitStandard>();
            SkillsRegistrationUnitStandards = new HashSet<SkillsRegistrationUnitStandard>();
            SkillsSetUnitStandards = new HashSet<SkillsSetUnitStandard>();
            SummativeAssessmentReportUnitStandards = new HashSet<SummativeAssessmentReportUnitStandard>();
            SummativeAssessmentReports = new HashSet<SummativeAssessmentReport>();
            UserUnitStandards = new HashSet<UserUnitStandard>();
            WorkPlaceApprovalUnitStandards = new HashSet<WorkPlaceApprovalUnitStandard>();
            WorkPlaceApprovals = new HashSet<WorkPlaceApproval>();
            WorkplaceMonitoringLearnerInductions = new HashSet<WorkplaceMonitoringLearnerInduction>();
        }

        public long Id { get; set; }
        public string? Abetbanddescription { get; set; }
        public string? Etqaacronym { get; set; }
        public string? Etqaname { get; set; }
        public string? Field { get; set; }
        public string? Fielddescription { get; set; }
        public string? Nqfleveldescription { get; set; }
        public string? Nqflevelg2Description { get; set; }
        public string? Providercode { get; set; }
        public int? Provideretqaid { get; set; }
        public string? Providername { get; set; }
        public string? Registrationstatusdesc { get; set; }
        public string? Saqadecisionnumber { get; set; }
        public string? Sgbname { get; set; }
        public string? Subfielddescription { get; set; }
        public int? Trainoutperiod { get; set; }
        public int? Transitionperiod { get; set; }
        public int? Unitstandardid { get; set; }
        public string? Unitstdaccreditationoptions { get; set; }
        public string? Unitstdassessorcriteria { get; set; }
        public string? Unitstdccfocollecting { get; set; }
        public string? Unitstdccfocommunicating { get; set; }
        public string? Unitstdccfocontributing { get; set; }
        public string? Unitstdccfodemonstrating { get; set; }
        public string? Unitstdccfoidentifying { get; set; }
        public string? Unitstdccfoorganizing { get; set; }
        public string? Unitstdccfoscience { get; set; }
        public string? Unitstdccfoworking { get; set; }
        public string? Unitstddevelopmentaloutcome { get; set; }
        public string? Unitstdembeddedknowledge { get; set; }
        public string? Unitstdlearningassumptions { get; set; }
        public string? Unitstdlinkages { get; set; }
        public string? Unitstdnotes { get; set; }
        public int? Unitstdnumberofcredits { get; set; }
        public string? Unitstdoutcomeheader { get; set; }
        public string? Unitstdpurpose { get; set; }
        public string? Unitstdrange { get; set; }
        public string? Unitstdtitle { get; set; }
        public string? Unitstdtypedesc { get; set; }
        public DateTime? LastDateForEnrolment { get; set; }
        public DateTime? UsregistrationendDate { get; set; }
        public DateTime? UsregistrationstartDate { get; set; }
        public string? UnitStandardIdString { get; set; }

        public virtual ICollection<CompanyLearner> CompanyLearners { get; set; }
        public virtual ICollection<CompanyLearnersChange> CompanyLearnersChanges { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChanges { get; set; }
        public virtual ICollection<CompanyUnitStandard> CompanyUnitStandards { get; set; }
        public virtual ICollection<CoursewareDistibution> CoursewareDistibutions { get; set; }
        public virtual ICollection<LearnershipDevelopmentRegistration> LearnershipDevelopmentRegistrations { get; set; }
        public virtual ICollection<LearnershipUnitStandard> LearnershipUnitStandards { get; set; }
        public virtual ICollection<LegacyAssessorUnitStandard> LegacyAssessorUnitStandards { get; set; }
        public virtual ICollection<LegacyDttcUnitStandard> LegacyDttcUnitStandards { get; set; }
        public virtual ICollection<LegacyLearnershipAssessment2> LegacyLearnershipAssessment2s { get; set; }
        public virtual ICollection<LegacyLearnershipAssessment3> LegacyLearnershipAssessment3s { get; set; }
        public virtual ICollection<LegacyModeratorUnitStandard> LegacyModeratorUnitStandards { get; set; }
        public virtual ICollection<LegacyProviderApplicationAlterationAudit> LegacyProviderApplicationAlterationAudits { get; set; }
        public virtual ICollection<LegacyProviderUnitStandard> LegacyProviderUnitStandards { get; set; }
        public virtual ICollection<LegacyUnitStandardAssessment> LegacyUnitStandardAssessments { get; set; }
        public virtual ICollection<LegacyUnitStandard> LegacyUnitStandards { get; set; }
        public virtual ICollection<MandatoryGrantDetailArchive> MandatoryGrantDetailArchives { get; set; }
        public virtual ICollection<MandatoryGrantDetail> MandatoryGrantDetails { get; set; }
        public virtual ICollection<MandatoryGrantRecommendation> MandatoryGrantRecommendations { get; set; }
        public virtual ICollection<MandatoryGrant> MandatoryGrants { get; set; }
        public virtual ICollection<MgVerificationDetail> MgVerificationDetails { get; set; }
        public virtual ICollection<ModulesUnitStandard> ModulesUnitStandards { get; set; }
        public virtual ICollection<QualificationUnitStandard> QualificationUnitStandards { get; set; }
        public virtual ICollection<SaqaSpecificOutcome> SaqaSpecificOutcomes { get; set; }
        public virtual ICollection<SkillsProgramUnitStandard> SkillsProgramUnitStandards { get; set; }
        public virtual ICollection<SkillsRegistrationQualificationUnitStandard> SkillsRegistrationQualificationUnitStandards { get; set; }
        public virtual ICollection<SkillsRegistrationUnitStandard> SkillsRegistrationUnitStandards { get; set; }
        public virtual ICollection<SkillsSetUnitStandard> SkillsSetUnitStandards { get; set; }
        public virtual ICollection<SummativeAssessmentReportUnitStandard> SummativeAssessmentReportUnitStandards { get; set; }
        public virtual ICollection<SummativeAssessmentReport> SummativeAssessmentReports { get; set; }
        public virtual ICollection<UserUnitStandard> UserUnitStandards { get; set; }
        public virtual ICollection<WorkPlaceApprovalUnitStandard> WorkPlaceApprovalUnitStandards { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovals { get; set; }
        public virtual ICollection<WorkplaceMonitoringLearnerInduction> WorkplaceMonitoringLearnerInductions { get; set; }
    }
}

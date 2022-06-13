using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SaqaQualification
    {
        public SaqaQualification()
        {
            /*AdministrationOfApqs = new HashSet<AdministrationOfApq>();
            AllocationLists = new HashSet<AllocationList>();
            Appraisals = new HashSet<Appraisal>();
            CompanyLearnerHighestQualifications = new HashSet<CompanyLearner>();
            CompanyLearnerLeaningProgrammes = new HashSet<CompanyLearner>();
            CompanyLearnerQualifications = new HashSet<CompanyLearner>();
            CompanyLearnersChanges = new HashSet<CompanyLearnersChange>();
            CompanyLearnersDetailsChangeHighestQualifications = new HashSet<CompanyLearnersDetailsChange>();
            CompanyLearnersDetailsChangeQualifications = new HashSet<CompanyLearnersDetailsChange>();
            CompanyLearnersTradeTests = new HashSet<CompanyLearnersTradeTest>();
            CompanyQualifications = new HashSet<CompanyQualification>();
            CompanyUnitStandards = new HashSet<CompanyUnitStandard>();
            DesignatedTradeLevels = new HashSet<DesignatedTradeLevel>();
            DgVerificationSites = new HashSet<DgVerificationSite>();
            Employees = new HashSet<Employee>();
            EmployeesHistories = new HashSet<EmployeesHistory>();
            EmployeesTrainings = new HashSet<EmployeesTraining>();
            LearnerInductions = new HashSet<LearnerInduction>();
            LearnershipDevelopmentRegistrations = new HashSet<LearnershipDevelopmentRegistration>();
            LearnershipOrginalQualificationAssigneds = new HashSet<Learnership>();
            LearnershipQualifications = new HashSet<Learnership>();
            LearnershipUnitStandards = new HashSet<LearnershipUnitStandard>();
            LegacyApprenticeshipTradeTests = new HashSet<LegacyApprenticeshipTradeTest>();
            LegacyApprenticeships = new HashSet<LegacyApprenticeship>();
            LegacyAssessorQualifications = new HashSet<LegacyAssessorQualification>();
            LegacyBursaries = new HashSet<LegacyBursary>();
            LegacyDttcQualifications = new HashSet<LegacyDttcQualification>();
            LegacyDttcTrades = new HashSet<LegacyDttcTrade>();
            LegacyEmployerWa2Qualifications = new HashSet<LegacyEmployerWa2Qualification>();
            LegacyEmployerWa2Trades = new HashSet<LegacyEmployerWa2Trade>();
            LegacyEmployerWa2Workplaces = new HashSet<LegacyEmployerWa2Workplace>();
            LegacyExperientials = new HashSet<LegacyExperiential>();
            LegacyInternships = new HashSet<LegacyInternship>();
            LegacyLearnershipAssessment2s = new HashSet<LegacyLearnershipAssessment2>();
            LegacyModeratorLearnerships = new HashSet<LegacyModeratorLearnership>();
            LegacyModeratorQualifications = new HashSet<LegacyModeratorQualification>();
            LegacyProviderApplicationAlterationAudits = new HashSet<LegacyProviderApplicationAlterationAudit>();
            LegacyProviderQualifications = new HashSet<LegacyProviderQualification>();
            LegacyProviderTrades = new HashSet<LegacyProviderTrade>();
            LegacySectTwentyEights = new HashSet<LegacySectTwentyEight>();
            LegacySectionTwentyEightTradeTests = new HashSet<LegacySectionTwentyEightTradeTest>();
            LegacySkillsProgrammeAssessments = new HashSet<LegacySkillsProgrammeAssessment>();
            LegacySkillsProgrammes = new HashSet<LegacySkillsProgramme>();
            LegacyTvets = new HashSet<LegacyTvet>();
            LegacyUnitStandards = new HashSet<LegacyUnitStandard>();
            MandatoryGrantDetailArchives = new HashSet<MandatoryGrantDetailArchive>();
            MandatoryGrantDetails = new HashSet<MandatoryGrantDetail>();
            MandatoryGrantRecommendations = new HashSet<MandatoryGrantRecommendation>();
            MandatoryGrants = new HashSet<MandatoryGrant>();
            MgVerificationDetails = new HashSet<MgVerificationDetail>();
            OfoQualificationLinks = new HashSet<OfoQualificationLink>();
            QualificationMultipleSelections = new HashSet<QualificationMultipleSelection>();
            QualificationTasks = new HashSet<QualificationTask>();
            QualificationToolKits = new HashSet<QualificationToolKit>();
            QualificationToolLists = new HashSet<QualificationToolList>();
            QualificationUnitStandards = new HashSet<QualificationUnitStandard>();
            SaqaUsQualifications = new HashSet<SaqaUsQualification>();
            SiteVisitReportSmes = new HashSet<SiteVisitReportSme>();
            SitesSmes = new HashSet<SitesSme>();
            SkillsProgramUnitStandards = new HashSet<SkillsProgramUnitStandard>();
            SkillsPrograms = new HashSet<SkillsProgram>();
            SkillsRegistrationQualificationUnitStandards = new HashSet<SkillsRegistrationQualificationUnitStandard>();
            SkillsRegistrationUnitStandards = new HashSet<SkillsRegistrationUnitStandard>();
            SkillsRegistrations = new HashSet<SkillsRegistration>();
            SkillsSetUnitStandards = new HashSet<SkillsSetUnitStandard>();
            SkillsSets = new HashSet<SkillsSet>();
            SmeQualifications = new HashSet<SmeQualification>();
            SummativeAssessmentReportUnitStandards = new HashSet<SummativeAssessmentReportUnitStandard>();
            SummativeAssessmentReports = new HashSet<SummativeAssessmentReport>();
            UserQualifications = new HashSet<UserQualification>();
            UserUnitStandards = new HashSet<UserUnitStandard>();
            Users = new HashSet<User>();
            WorkPlaceApprovalData = new HashSet<WorkPlaceApprovalDatum>();
            WorkPlaceApprovalSites = new HashSet<WorkPlaceApprovalSite>();
            WorkPlaceApprovals = new HashSet<WorkPlaceApproval>();
            WorkplaceMonitoringLearnerInductions = new HashSet<WorkplaceMonitoringLearnerInduction>();
            WspCompanyEmployeesHistories = new HashSet<WspCompanyEmployeesHistory>();
            WspSkillsRequirements = new HashSet<WspSkillsRequirement>(); */
        }

        public long Id { get; set; }
        public string? Abetbanddescription { get; set; }
        public string? Eloacqualassessmentcriteria { get; set; }
        public string? Eloacqualificationoutcome { get; set; }
        public string? Etqaacronym { get; set; }
        public string? Etqaname { get; set; }
        public string? Field { get; set; }
        public string? Fielddescription { get; set; }
        public string? Islearningprogramme { get; set; }
        public int? Learningprogrammequal { get; set; }
        public string? Nqfleveldescription { get; set; }
        public string? Nqflevelg2Description { get; set; }
        public string? Providercode { get; set; }
        public int? Provideretqaid { get; set; }
        public string? Providername { get; set; }
        public string? Qualarticulationoptions { get; set; }
        public string? Qualassessorcriteria { get; set; }
        public string? Qualificationclassdesc { get; set; }
        public int? Qualificationid { get; set; }
        public int? Qualificationminimumcredits { get; set; }
        public string? Qualificationnotes { get; set; }
        public string? Qualificationpurpose { get; set; }
        public string? Qualificationtitle { get; set; }
        public string? Qualificationtypedesc { get; set; }
        public string? Qualintlbenchmarkingmemo { get; set; }
        public string? Quallearningassumedinplace { get; set; }
        public string? Qualmoderationoptions { get; set; }
        public string? Qualrulesofcombination { get; set; }
        public string? Recognizeprevlearningflag { get; set; }
        public string? Registrationstatusdesc { get; set; }
        public string? Saqadecisionnumber { get; set; }
        public string? Sgbname { get; set; }
        public string? Subfielddescription { get; set; }
        public int? Trainoutperiod { get; set; }
        public int? Transitionperiod { get; set; }
        public string? Etqaid { get; set; }
        public long? NqfLevelId { get; set; }
        public string? NqflevelId1 { get; set; }
        public string? QualificationidString { get; set; }
        public string? Nqflevelg2Id { get; set; }
        public ulong? WorkplaceApprovalRequired { get; set; }
        public DateTime? LastDateForEnrolment { get; set; }
        public DateTime? Lastdateforenrolment1 { get; set; }
        public DateTime? Lastdateforachievement { get; set; }
        public DateTime? Qualregistrationenddate { get; set; }
        public DateTime? Qualregistrationstartdate { get; set; }
        public long? TrainingProviderDocParentId { get; set; }
        public string? Qualificationtypeid { get; set; }
        public string? Registrationstatuscode { get; set; }
        public long? DesignatedTradeId { get; set; }
        public long? LearnerMentorRatioId { get; set; }
        public int? LevelFour { get; set; }
        public int? LevelOne { get; set; }
        public int? LevelThree { get; set; }
        public int? LevelTwo { get; set; }
        public long? SubFieldId { get; set; }

        public virtual DesignatedTrade? DesignatedTrade { get; set; }
        public virtual LearnerMentorRatio? LearnerMentorRatio { get; set; }
        public virtual NqfLevel? NqfLevel { get; set; }
        public virtual Subfield? SubField { get; set; }
        public virtual TrainingProviderDocParent? TrainingProviderDocParent { get; set; }
        public virtual ICollection<AdministrationOfApq> AdministrationOfApqs { get; set; }
        public virtual ICollection<AllocationList> AllocationLists { get; set; }
        public virtual ICollection<Appraisal> Appraisals { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearnerHighestQualifications { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearnerLeaningProgrammes { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearnerQualifications { get; set; }
        public virtual ICollection<CompanyLearnersChange> CompanyLearnersChanges { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChangeHighestQualifications { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChangeQualifications { get; set; }
        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTests { get; set; }
        public virtual ICollection<CompanyQualification> CompanyQualifications { get; set; }
        public virtual ICollection<CompanyUnitStandard> CompanyUnitStandards { get; set; }
        public virtual ICollection<DesignatedTradeLevel> DesignatedTradeLevels { get; set; }
        public virtual ICollection<DgVerificationSite> DgVerificationSites { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<EmployeesHistory> EmployeesHistories { get; set; }
        public virtual ICollection<EmployeesTraining> EmployeesTrainings { get; set; }
        public virtual ICollection<LearnerInduction> LearnerInductions { get; set; }
        public virtual ICollection<LearnershipDevelopmentRegistration> LearnershipDevelopmentRegistrations { get; set; }
        public virtual ICollection<Learnership> LearnershipOrginalQualificationAssigneds { get; set; }
        public virtual ICollection<Learnership> LearnershipQualifications { get; set; }
        public virtual ICollection<LearnershipUnitStandard> LearnershipUnitStandards { get; set; }
        public virtual ICollection<LegacyApprenticeshipTradeTest> LegacyApprenticeshipTradeTests { get; set; }
        public virtual ICollection<LegacyApprenticeship> LegacyApprenticeships { get; set; }
        public virtual ICollection<LegacyAssessorQualification> LegacyAssessorQualifications { get; set; }
        public virtual ICollection<LegacyBursary> LegacyBursaries { get; set; }
        public virtual ICollection<LegacyDttcQualification> LegacyDttcQualifications { get; set; }
        public virtual ICollection<LegacyDttcTrade> LegacyDttcTrades { get; set; }
        public virtual ICollection<LegacyEmployerWa2Qualification> LegacyEmployerWa2Qualifications { get; set; }
        public virtual ICollection<LegacyEmployerWa2Trade> LegacyEmployerWa2Trades { get; set; }
        public virtual ICollection<LegacyEmployerWa2Workplace> LegacyEmployerWa2Workplaces { get; set; }
        public virtual ICollection<LegacyExperiential> LegacyExperientials { get; set; }
        public virtual ICollection<LegacyInternship> LegacyInternships { get; set; }
        public virtual ICollection<LegacyLearnershipAssessment2> LegacyLearnershipAssessment2s { get; set; }
        public virtual ICollection<LegacyModeratorLearnership> LegacyModeratorLearnerships { get; set; }
        public virtual ICollection<LegacyModeratorQualification> LegacyModeratorQualifications { get; set; }
        public virtual ICollection<LegacyProviderApplicationAlterationAudit> LegacyProviderApplicationAlterationAudits { get; set; }
        public virtual ICollection<LegacyProviderQualification> LegacyProviderQualifications { get; set; }
        public virtual ICollection<LegacyProviderTrade> LegacyProviderTrades { get; set; }
        public virtual ICollection<LegacySectTwentyEight> LegacySectTwentyEights { get; set; }
        public virtual ICollection<LegacySectionTwentyEightTradeTest> LegacySectionTwentyEightTradeTests { get; set; }
        public virtual ICollection<LegacySkillsProgrammeAssessment> LegacySkillsProgrammeAssessments { get; set; }
        public virtual ICollection<LegacySkillsProgramme> LegacySkillsProgrammes { get; set; }
        public virtual ICollection<LegacyTvet> LegacyTvets { get; set; }
        public virtual ICollection<LegacyUnitStandard> LegacyUnitStandards { get; set; }
        public virtual ICollection<MandatoryGrantDetailArchive> MandatoryGrantDetailArchives { get; set; }
        public virtual ICollection<MandatoryGrantDetail> MandatoryGrantDetails { get; set; }
        public virtual ICollection<MandatoryGrantRecommendation> MandatoryGrantRecommendations { get; set; }
        public virtual ICollection<MandatoryGrant> MandatoryGrants { get; set; }
        public virtual ICollection<MgVerificationDetail> MgVerificationDetails { get; set; }
        public virtual ICollection<OfoQualificationLink> OfoQualificationLinks { get; set; }
        public virtual ICollection<QualificationMultipleSelection> QualificationMultipleSelections { get; set; }
        public virtual ICollection<QualificationTask> QualificationTasks { get; set; }
        public virtual ICollection<QualificationToolKit> QualificationToolKits { get; set; }
        public virtual ICollection<QualificationToolList> QualificationToolLists { get; set; }
        public virtual ICollection<QualificationUnitStandard> QualificationUnitStandards { get; set; }
        public virtual ICollection<SaqaUsQualification> SaqaUsQualifications { get; set; }
        public virtual ICollection<SiteVisitReportSme> SiteVisitReportSmes { get; set; }
        public virtual ICollection<SitesSme> SitesSmes { get; set; }
        public virtual ICollection<SkillsProgramUnitStandard> SkillsProgramUnitStandards { get; set; }
        public virtual ICollection<SkillsProgram> SkillsPrograms { get; set; }
        public virtual ICollection<SkillsRegistrationQualificationUnitStandard> SkillsRegistrationQualificationUnitStandards { get; set; }
        public virtual ICollection<SkillsRegistrationUnitStandard> SkillsRegistrationUnitStandards { get; set; }
        public virtual ICollection<SkillsRegistration> SkillsRegistrations { get; set; }
        public virtual ICollection<SkillsSetUnitStandard> SkillsSetUnitStandards { get; set; }
        public virtual ICollection<SkillsSet> SkillsSets { get; set; }
        public virtual ICollection<SmeQualification> SmeQualifications { get; set; }
        public virtual ICollection<SummativeAssessmentReportUnitStandard> SummativeAssessmentReportUnitStandards { get; set; }
        public virtual ICollection<SummativeAssessmentReport> SummativeAssessmentReports { get; set; }
        public virtual ICollection<UserQualification> UserQualifications { get; set; }
        public virtual ICollection<UserUnitStandard> UserUnitStandards { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<WorkPlaceApprovalDatum> WorkPlaceApprovalData { get; set; }
        public virtual ICollection<WorkPlaceApprovalSite> WorkPlaceApprovalSites { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovals { get; set; }
        public virtual ICollection<WorkplaceMonitoringLearnerInduction> WorkplaceMonitoringLearnerInductions { get; set; }
        public virtual ICollection<WspCompanyEmployeesHistory> WspCompanyEmployeesHistories { get; set; }
        public virtual ICollection<WspSkillsRequirement> WspSkillsRequirements { get; set; }
    }
}

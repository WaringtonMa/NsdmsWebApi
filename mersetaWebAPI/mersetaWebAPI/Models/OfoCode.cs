using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class OfoCode
    {
        public OfoCode()
        {
            AllocationLists = new HashSet<AllocationList>();
            Appraisals = new HashSet<Appraisal>();
            AssessorModeratorApplications = new HashSet<AssessorModeratorApplication>();
            CompanyLearners = new HashSet<CompanyLearner>();
            CompanyLearnersDetailsChanges = new HashSet<CompanyLearnersDetailsChange>();
            CompanyLearnersTradeTests = new HashSet<CompanyLearnersTradeTest>();
            Employees = new HashSet<Employee>();
            EmployeesHistories = new HashSet<EmployeesHistory>();
            InverseOfoCodes = new HashSet<OfoCode>();
            LearnershipDevelopmentRegistrations = new HashSet<LearnershipDevelopmentRegistration>();
            Learnerships = new HashSet<Learnership>();
            LegacyApprenticeshipTradeTests = new HashSet<LegacyApprenticeshipTradeTest>();
            LegacyApprenticeships = new HashSet<LegacyApprenticeship>();
            LegacyBursaries = new HashSet<LegacyBursary>();
            LegacyExperientials = new HashSet<LegacyExperiential>();
            LegacyInternships = new HashSet<LegacyInternship>();
            LegacySectTwentyEights = new HashSet<LegacySectTwentyEight>();
            LegacySectionTwentyEightTradeTests = new HashSet<LegacySectionTwentyEightTradeTest>();
            LegacyTvets = new HashSet<LegacyTvet>();
            MandatoryGrantDetailArchives = new HashSet<MandatoryGrantDetailArchive>();
            MandatoryGrantDetails = new HashSet<MandatoryGrantDetail>();
            MandatoryGrants = new HashSet<MandatoryGrant>();
            MgVerificationDetails = new HashSet<MgVerificationDetail>();
            OfoQualificationLinks = new HashSet<OfoQualificationLink>();
            QualificationsCurriculumDevelopments = new HashSet<QualificationsCurriculumDevelopment>();
            SiteVisitReportSmes = new HashSet<SiteVisitReportSme>();
            SkillsRegistrations = new HashSet<SkillsRegistration>();
            Users = new HashSet<User>();
            WorkPlaceApprovalData = new HashSet<WorkPlaceApprovalDatum>();
            WorkPlaceApprovalTrades = new HashSet<WorkPlaceApprovalTrade>();
            WorkPlaceApprovals = new HashSet<WorkPlaceApproval>();
            WspCalculationData = new HashSet<WspCalculationDatum>();
            WspCompanyEmployeesHistories = new HashSet<WspCompanyEmployeesHistory>();
            WspSkillsRequirements = new HashSet<WspSkillsRequirement>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Description { get; set; }
        public string? Fm { get; set; }
        public string? MajorGroup { get; set; }
        public string? MinorGroup { get; set; }
        public string? OfoCode1 { get; set; }
        public string? SubMajorGroup { get; set; }
        public string? UnitGroup { get; set; }
        public long? OccupationCategoryId { get; set; }
        public long? OfoCodesId { get; set; }
        public string? SpecialisationCode { get; set; }
        public ulong? Trade { get; set; }
        public string? TradeType { get; set; }
        public ulong? Active { get; set; }
        public ulong? GreenOccupation { get; set; }
        public ulong? GreenSkill { get; set; }
        public int? Year { get; set; }
        public string? SetmisCode { get; set; }

        public virtual OccupationCategory? OccupationCategory { get; set; }
        public virtual OfoCode? OfoCodes { get; set; }
        public virtual ICollection<AllocationList> AllocationLists { get; set; }
        public virtual ICollection<Appraisal> Appraisals { get; set; }
        public virtual ICollection<AssessorModeratorApplication> AssessorModeratorApplications { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearners { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChanges { get; set; }
        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTests { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<EmployeesHistory> EmployeesHistories { get; set; }
        public virtual ICollection<OfoCode> InverseOfoCodes { get; set; }
        public virtual ICollection<LearnershipDevelopmentRegistration> LearnershipDevelopmentRegistrations { get; set; }
        public virtual ICollection<Learnership> Learnerships { get; set; }
        public virtual ICollection<LegacyApprenticeshipTradeTest> LegacyApprenticeshipTradeTests { get; set; }
        public virtual ICollection<LegacyApprenticeship> LegacyApprenticeships { get; set; }
        public virtual ICollection<LegacyBursary> LegacyBursaries { get; set; }
        public virtual ICollection<LegacyExperiential> LegacyExperientials { get; set; }
        public virtual ICollection<LegacyInternship> LegacyInternships { get; set; }
        public virtual ICollection<LegacySectTwentyEight> LegacySectTwentyEights { get; set; }
        public virtual ICollection<LegacySectionTwentyEightTradeTest> LegacySectionTwentyEightTradeTests { get; set; }
        public virtual ICollection<LegacyTvet> LegacyTvets { get; set; }
        public virtual ICollection<MandatoryGrantDetailArchive> MandatoryGrantDetailArchives { get; set; }
        public virtual ICollection<MandatoryGrantDetail> MandatoryGrantDetails { get; set; }
        public virtual ICollection<MandatoryGrant> MandatoryGrants { get; set; }
        public virtual ICollection<MgVerificationDetail> MgVerificationDetails { get; set; }
        public virtual ICollection<OfoQualificationLink> OfoQualificationLinks { get; set; }
        public virtual ICollection<QualificationsCurriculumDevelopment> QualificationsCurriculumDevelopments { get; set; }
        public virtual ICollection<SiteVisitReportSme> SiteVisitReportSmes { get; set; }
        public virtual ICollection<SkillsRegistration> SkillsRegistrations { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<WorkPlaceApprovalDatum> WorkPlaceApprovalData { get; set; }
        public virtual ICollection<WorkPlaceApprovalTrade> WorkPlaceApprovalTrades { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovals { get; set; }
        public virtual ICollection<WspCalculationDatum> WspCalculationData { get; set; }
        public virtual ICollection<WspCompanyEmployeesHistory> WspCompanyEmployeesHistories { get; set; }
        public virtual ICollection<WspSkillsRequirement> WspSkillsRequirements { get; set; }
    }
}

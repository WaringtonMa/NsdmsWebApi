using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class AssessorModeratorApplication
    {
        public AssessorModeratorApplication()
        {
            AssessorModExtensionOfScopes = new HashSet<AssessorModExtensionOfScope>();
            AssessorModReRegistrations = new HashSet<AssessorModReRegistration>();
            AssessorModeratorCompanies = new HashSet<AssessorModeratorCompany>();
            AssessorModeratorCompanySites = new HashSet<AssessorModeratorCompanySite>();
            CompanyLearnerAssessorApplications = new HashSet<CompanyLearner>();
            CompanyLearnerModeratorApplications = new HashSet<CompanyLearner>();
            CompanyLearnersTradeTestAssessorApplications = new HashSet<CompanyLearnersTradeTest>();
            CompanyLearnersTradeTestModeratorApplications = new HashSet<CompanyLearnersTradeTest>();
            ProviderApplicationTradeTestAssessorsLinks = new HashSet<ProviderApplicationTradeTestAssessorsLink>();
            RejectReasonsChildren = new HashSet<RejectReasonsChild>();
            SummativeAssessmentReportUnitStandardAssessorApplications = new HashSet<SummativeAssessmentReportUnitStandard>();
            SummativeAssessmentReportUnitStandardModeratorApplications = new HashSet<SummativeAssessmentReportUnitStandard>();
            UserLearnerships = new HashSet<UserLearnership>();
            UserQualifications = new HashSet<UserQualification>();
            UserSkillsProgrammes = new HashSet<UserSkillsProgramme>();
            UserUnitStandards = new HashSet<UserUnitStandard>();
        }

        public long Id { get; set; }
        public int? ApplicationType { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string? CertificateNumber { get; set; }
        public DateTime? CodeOfConductAcceptDate { get; set; }
        public ulong? CodeOfConductAccepted { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EndDate { get; set; }
        public ulong? FinalRejected { get; set; }
        public DateTime? StartDate { get; set; }
        public int? Status { get; set; }
        public long? JobTitleId { get; set; }
        public long? OfoCodesId { get; set; }
        public long? ReviewCommitteeMeetingId { get; set; }
        public long? ReviewCommitteeMeetingAgendaId { get; set; }
        public long? UsersId { get; set; }
        public ulong? FinalApproved { get; set; }
        public long? LegacyAssessorAccreditationId { get; set; }
        public long? LegacyModeratorAccreditationId { get; set; }
        public long? EtqaId { get; set; }
        public ulong? DuplicateApplication { get; set; }
        public int? TypeAssessorModerator { get; set; }
        public ulong? TradeTestCenterApplication { get; set; }
        public ulong? AssessorApplication { get; set; }
        public ulong? ModeratorApplication { get; set; }
        public long? CreateUserId { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? LastUpdateUserId { get; set; }
        public ulong? SystemUpdate { get; set; }

        public virtual User? CreateUser { get; set; }
        public virtual Etqa? Etqa { get; set; }
        public virtual JobTitle? JobTitle { get; set; }
        public virtual User? LastUpdateUser { get; set; }
        public virtual LegacyAssessorAccreditation? LegacyAssessorAccreditation { get; set; }
        public virtual LegacyModeratorAccreditation? LegacyModeratorAccreditation { get; set; }
        public virtual OfoCode? OfoCodes { get; set; }
        public virtual ReviewCommitteeMeeting? ReviewCommitteeMeeting { get; set; }
        public virtual ReviewCommitteeMeetingAgendum? ReviewCommitteeMeetingAgenda { get; set; }
        public virtual User? Users { get; set; }
        public virtual ICollection<AssessorModExtensionOfScope> AssessorModExtensionOfScopes { get; set; }
        public virtual ICollection<AssessorModReRegistration> AssessorModReRegistrations { get; set; }
        public virtual ICollection<AssessorModeratorCompany> AssessorModeratorCompanies { get; set; }
        public virtual ICollection<AssessorModeratorCompanySite> AssessorModeratorCompanySites { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearnerAssessorApplications { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearnerModeratorApplications { get; set; }
        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTestAssessorApplications { get; set; }
        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTestModeratorApplications { get; set; }
        public virtual ICollection<ProviderApplicationTradeTestAssessorsLink> ProviderApplicationTradeTestAssessorsLinks { get; set; }
        public virtual ICollection<RejectReasonsChild> RejectReasonsChildren { get; set; }
        public virtual ICollection<SummativeAssessmentReportUnitStandard> SummativeAssessmentReportUnitStandardAssessorApplications { get; set; }
        public virtual ICollection<SummativeAssessmentReportUnitStandard> SummativeAssessmentReportUnitStandardModeratorApplications { get; set; }
        public virtual ICollection<UserLearnership> UserLearnerships { get; set; }
        public virtual ICollection<UserQualification> UserQualifications { get; set; }
        public virtual ICollection<UserSkillsProgramme> UserSkillsProgrammes { get; set; }
        public virtual ICollection<UserUnitStandard> UserUnitStandards { get; set; }
    }
}

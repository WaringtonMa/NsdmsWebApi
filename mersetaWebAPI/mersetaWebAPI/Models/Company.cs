using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Company
    {
        public Company()
        {
            /*ActiveContracts = new HashSet<ActiveContract>();
            AddressChanges = new HashSet<AddressChange>();
            AddressHistories = new HashSet<AddressHistory>();
            Addresses = new HashSet<Address>();
            AdministrationOfApqs = new HashSet<AdministrationOfApq>();
            AssessorModeratorCompanies = new HashSet<AssessorModeratorCompany>();
            AssessorModeratorCompanySites = new HashSet<AssessorModeratorCompanySite>();
            BankingDetails = new HashSet<BankingDetail>();
            CategorizationData = new HashSet<CategorizationDatum>();
            CompanyCommunications = new HashSet<CompanyCommunication>();
            CompanyHistoryCompanies = new HashSet<CompanyHistory>();
            CompanyHistoryForCompanies = new HashSet<CompanyHistory>();
            CompanyHostingCompanies = new HashSet<CompanyHostingCompany>();
            CompanyLearnerCompanies = new HashSet<CompanyLearner>();
            CompanyLearnerEmployers = new HashSet<CompanyLearner>();
            CompanyLearnerHostCompanies = new HashSet<CompanyLearner>();
            CompanyLearnerUsers = new HashSet<CompanyLearnerUser>();
            CompanyLearnersDetailsChangeCompanies = new HashSet<CompanyLearnersDetailsChange>();
            CompanyLearnersDetailsChangeEmployers = new HashSet<CompanyLearnersDetailsChange>();
            CompanyLearnersDetailsChangeHostCompanies = new HashSet<CompanyLearnersDetailsChange>();
            CompanyLearnersTradeTestCompanyEmployerNavigations = new HashSet<CompanyLearnersTradeTest>();
            CompanyLearnersTradeTestCompanyProviders = new HashSet<CompanyLearnersTradeTest>();
            CompanyLearnersTradeTestPreferredTrainingCenters = new HashSet<CompanyLearnersTradeTest>();
            CompanyLearnersTradeTestPreviousTrainingCenters = new HashSet<CompanyLearnersTradeTest>();
            CompanyLearnersTransferCurrentCompanyAssigneds = new HashSet<CompanyLearnersTransfer>();
            CompanyLearnersTransferTransferToCompanies = new HashSet<CompanyLearnersTransfer>();
            CompanyQualifications = new HashSet<CompanyQualification>();
            CompanyTradeTestEmployers = new HashSet<CompanyTradeTestEmployer>();
            CompanyUnitStandards = new HashSet<CompanyUnitStandard>();
            CompanyUsers = new HashSet<CompanyUser>();
            CompanyUsersHistories = new HashSet<CompanyUsersHistory>();
            CompletionLetterCompanies = new HashSet<CompletionLetter>();
            CompletionLetterTrainingProviders = new HashSet<CompletionLetter>();
            CoursewareDistibutions = new HashSet<CoursewareDistibution>();
            Docs = new HashSet<Doc>();
            Employees = new HashSet<Employee>();
            EmployeesHistories = new HashSet<EmployeesHistory>();
            EmployeesImports = new HashSet<EmployeesImport>();
            ExtensionRequests = new HashSet<ExtensionRequest>();
            GpBankAccountAlterAudits = new HashSet<GpBankAccountAlterAudit>();
            HostingCompanyCompanies = new HashSet<HostingCompanyCompany>();
            InterSetaTransfers = new HashSet<InterSetaTransfer>();
            InverseCompanyNavigation = new HashSet<Company>();
            InversePreviousCompany = new HashSet<Company>();
            LearnershipDevelopmentRegistrations = new HashSet<LearnershipDevelopmentRegistration>();
            LegacyApprenticeshipCompanies = new HashSet<LegacyApprenticeship>();
            LegacyApprenticeshipEmployers = new HashSet<LegacyApprenticeship>();
            LegacyBursaryCompanies = new HashSet<LegacyBursary>();
            LegacyBursaryEmployers = new HashSet<LegacyBursary>();
            LegacyDttcApprovals = new HashSet<LegacyDttcApproval>();
            LegacyExperientialCompanies = new HashSet<LegacyExperiential>();
            LegacyExperientialEmployers = new HashSet<LegacyExperiential>();
            LegacyInternshipCompanies = new HashSet<LegacyInternship>();
            LegacyInternshipEmployers = new HashSet<LegacyInternship>();
            LegacyLearnerships = new HashSet<LegacyLearnership>();
            LegacyOrganisationSites = new HashSet<LegacyOrganisationSite>();
            LegacyProviderApplicationAlterationAudits = new HashSet<LegacyProviderApplicationAlterationAudit>();
            LegacyProviderApplicationSiteAllocations = new HashSet<LegacyProviderApplicationSiteAllocation>();
            LegacyProviderQualifications = new HashSet<LegacyProviderQualification>();
            LegacySectTwentyEightCompanies = new HashSet<LegacySectTwentyEight>();
            LegacySectTwentyEightEmployers = new HashSet<LegacySectTwentyEight>();
            LegacySkillsProgrammes = new HashSet<LegacySkillsProgramme>();
            LegacyTvetCompanies = new HashSet<LegacyTvet>();
            LegacyTvetEmployers = new HashSet<LegacyTvet>();
            LegacyUnitStandards = new HashSet<LegacyUnitStandard>();
            MgVerificationCompleteds = new HashSet<MgVerificationCompleted>();
            MgVerificationDetails = new HashSet<MgVerificationDetail>();
            NonSetaQualificationsCompletionCompanies = new HashSet<NonSetaQualificationsCompletion>();
            NonSetaQualificationsCompletionTrainingProviders = new HashSet<NonSetaQualificationsCompletion>();
            PaymentRequests = new HashSet<PaymentRequest>();
            ProjectImplementationPlanLearners = new HashSet<ProjectImplementationPlanLearner>();
            ProjectImplementationPlans = new HashSet<ProjectImplementationPlan>();
            ProviderApplicationSuspensionDeActivateds = new HashSet<ProviderApplicationSuspensionDeActivated>();
            QdfCompanies = new HashSet<QdfCompany>();
            QualificationsCurriculumDevelopments = new HashSet<QualificationsCurriculumDevelopment>();
            RejectReasonsChildren = new HashSet<RejectReasonsChild>();
            ScheduleChangesLogs = new HashSet<ScheduleChangesLog>();
            ScheduledEvents = new HashSet<ScheduledEvent>();
            SdfCompanies = new HashSet<SdfCompany>();
            SdfCompanyHistories = new HashSet<SdfCompanyHistory>();
            SdpCompanies = new HashSet<SdpCompany>();
            SdpCompanyActions = new HashSet<SdpCompanyAction>();
            SdpCompanyHistories = new HashSet<SdpCompanyHistory>();
            SiteVisitReportNews = new HashSet<SiteVisitReportNew>();
            SiteVisits = new HashSet<SiteVisit>();
            Sites = new HashSet<Site>();
            SitesHistories = new HashSet<SitesHistory>();
            SitesSmes = new HashSet<SitesSme>();
            SkillsRegistrations = new HashSet<SkillsRegistration>();
            Tasks = new HashSet<Task>();
            TrainingComitteeHostories = new HashSet<TrainingComitteeHostory>();
            TrainingComittees = new HashSet<TrainingComittee>();
            TrainingProviderApplications = new HashSet<TrainingProviderApplication>();
            TrainingProviderMonitorings = new HashSet<TrainingProviderMonitoring>();
            TrainingProviderVerfications = new HashSet<TrainingProviderVerfication>();
            TrainingSites = new HashSet<TrainingSite>();
            UpdateAuditTrails = new HashSet<UpdateAuditTrail>();
            UsersTrainingProviders = new HashSet<UsersTrainingProvider>();
            WorkPlaceApprovalData = new HashSet<WorkPlaceApprovalDatum>();
            WorkPlaceApprovals = new HashSet<WorkPlaceApproval>();
            WorkplaceMonitoringSiteVisits = new HashSet<WorkplaceMonitoringSiteVisit>();
            WorkplaceMonitorings = new HashSet<WorkplaceMonitoring>();
            WspCalculationData = new HashSet<WspCalculationDatum>();
            WspCompanyAddressHistories = new HashSet<WspCompanyAddressHistory>();
            WspCompanyMainHistories = new HashSet<WspCompanyMainHistory>();
            WspSdfCompanyHistories = new HashSet<WspSdfCompanyHistory>();
            Wsps = new HashSet<Wsp>(); */
        }

        public long Id { get; set; }
        public string? CompanyGuid { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyRegistrationNumber { get; set; }
        public int? CompanyStatus { get; set; }
        public int? CompanyType { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Email { get; set; }
        public string? FaxNumber { get; set; }
        public string? LevyNumber { get; set; }
        public string? LevyNumberAdditional { get; set; }
        public int? NumberOfEmployees { get; set; }
        public string? PayeSdlNumber { get; set; }
        public string? TelNumber { get; set; }
        public string? TradingName { get; set; }
        public long? BankingDetailsId { get; set; }
        public long? ChamberId { get; set; }
        public long? FormUserId { get; set; }
        public long? InstitutionTypeId { get; set; }
        public long? PostalAddressId { get; set; }
        public long? RegisteredAddressId { get; set; }
        public long? ResidentialAddressId { get; set; }
        public long? SicCodeId { get; set; }
        public int? ApprovalEnum { get; set; }
        public string? RejectReason { get; set; }
        public long? CompanyId { get; set; }
        public long? RecognitionAgreementId { get; set; }
        public int? Categorization { get; set; }
        public long? OrganisationTypeId { get; set; }
        public int? NumberOfEmployees1 { get; set; }
        public long? MajorityUnionId { get; set; }
        public ulong? TrainingCommitteeInPlace { get; set; }
        public ulong? NonLevyPaying { get; set; }
        public DateTime? FinancialYearEndDate { get; set; }
        public DateTime? FinancialYearStartDate { get; set; }
        public ulong? Locked { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public string? SarsTradingStatus { get; set; }
        public ulong? OnGp { get; set; }
        public int? FinancialYearEndDay { get; set; }
        public int? FinancialYearEndMonth { get; set; }
        public int? FinancialYearStartDay { get; set; }
        public int? FinancialYearStartMonth { get; set; }
        public string? AccreditationNumber { get; set; }
        public long? EtqaId { get; set; }
        public ulong? NonSetaCompany { get; set; }
        public long? SetaId { get; set; }
        public string? WorkplaceApprovalNumber { get; set; }
        public DateTime? DeregisterDate { get; set; }
        public long? DeregisterUserId { get; set; }
        public long? PreviousCompanyId { get; set; }
        public string? CompanySiteNumber { get; set; }
        public string? CompanyWebsite { get; set; }
        public DateTime? ValidiationRanDate { get; set; }
        public ulong? UseTradingNameSetmis { get; set; }

        public virtual BankingDetail? BankingDetailsNavigation { get; set; }
        public virtual Chamber? Chamber { get; set; }
        public virtual Company? CompanyNavigation { get; set; }
        public virtual User? DeregisterUser { get; set; }
        public virtual Etqa? Etqa { get; set; }
        public virtual User? FormUser { get; set; }
        public virtual InstitutionType? InstitutionType { get; set; }
        public virtual OrganisedLabourUnion? MajorityUnion { get; set; }
        public virtual OrganisationType? OrganisationType { get; set; }
        public virtual Address? PostalAddress { get; set; }
        public virtual Company? PreviousCompany { get; set; }
        public virtual YesNoLookup? RecognitionAgreement { get; set; }
        public virtual Address? RegisteredAddress { get; set; }
        public virtual Address? ResidentialAddress { get; set; }
        public virtual Setum? Seta { get; set; }
        public virtual SicCode? SicCode { get; set; }
        public virtual ICollection<ActiveContract> ActiveContracts { get; set; }
        public virtual ICollection<AddressChange> AddressChanges { get; set; }
        public virtual ICollection<AddressHistory> AddressHistories { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<AdministrationOfApq> AdministrationOfApqs { get; set; }
        public virtual ICollection<AssessorModeratorCompany> AssessorModeratorCompanies { get; set; }
        public virtual ICollection<AssessorModeratorCompanySite> AssessorModeratorCompanySites { get; set; }
        public virtual ICollection<BankingDetail> BankingDetails { get; set; }
        public virtual ICollection<CategorizationDatum> CategorizationData { get; set; }
        public virtual ICollection<CompanyCommunication> CompanyCommunications { get; set; }
        public virtual ICollection<CompanyHistory> CompanyHistoryCompanies { get; set; }
        public virtual ICollection<CompanyHistory> CompanyHistoryForCompanies { get; set; }
        public virtual ICollection<CompanyHostingCompany> CompanyHostingCompanies { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearnerCompanies { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearnerEmployers { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearnerHostCompanies { get; set; }
        public virtual ICollection<CompanyLearnerUser> CompanyLearnerUsers { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChangeCompanies { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChangeEmployers { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChangeHostCompanies { get; set; }
        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTestCompanyEmployerNavigations { get; set; }
        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTestCompanyProviders { get; set; }
        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTestPreferredTrainingCenters { get; set; }
        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTestPreviousTrainingCenters { get; set; }
        public virtual ICollection<CompanyLearnersTransfer> CompanyLearnersTransferCurrentCompanyAssigneds { get; set; }
        public virtual ICollection<CompanyLearnersTransfer> CompanyLearnersTransferTransferToCompanies { get; set; }
        public virtual ICollection<CompanyQualification> CompanyQualifications { get; set; }
        public virtual ICollection<CompanyTradeTestEmployer> CompanyTradeTestEmployers { get; set; }
        public virtual ICollection<CompanyUnitStandard> CompanyUnitStandards { get; set; }
        public virtual ICollection<CompanyUser> CompanyUsers { get; set; }
        public virtual ICollection<CompanyUsersHistory> CompanyUsersHistories { get; set; }
        public virtual ICollection<CompletionLetter> CompletionLetterCompanies { get; set; }
        public virtual ICollection<CompletionLetter> CompletionLetterTrainingProviders { get; set; }
        public virtual ICollection<CoursewareDistibution> CoursewareDistibutions { get; set; }
        public virtual ICollection<Doc> Docs { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<EmployeesHistory> EmployeesHistories { get; set; }
        public virtual ICollection<EmployeesImport> EmployeesImports { get; set; }
        public virtual ICollection<ExtensionRequest> ExtensionRequests { get; set; }
        public virtual ICollection<GpBankAccountAlterAudit> GpBankAccountAlterAudits { get; set; }
        public virtual ICollection<HostingCompanyCompany> HostingCompanyCompanies { get; set; }
        public virtual ICollection<InterSetaTransfer> InterSetaTransfers { get; set; }
        public virtual ICollection<Company> InverseCompanyNavigation { get; set; }
        public virtual ICollection<Company> InversePreviousCompany { get; set; }
        public virtual ICollection<LearnershipDevelopmentRegistration> LearnershipDevelopmentRegistrations { get; set; }
        public virtual ICollection<LegacyApprenticeship> LegacyApprenticeshipCompanies { get; set; }
        public virtual ICollection<LegacyApprenticeship> LegacyApprenticeshipEmployers { get; set; }
        public virtual ICollection<LegacyBursary> LegacyBursaryCompanies { get; set; }
        public virtual ICollection<LegacyBursary> LegacyBursaryEmployers { get; set; }
        public virtual ICollection<LegacyDttcApproval> LegacyDttcApprovals { get; set; }
        public virtual ICollection<LegacyExperiential> LegacyExperientialCompanies { get; set; }
        public virtual ICollection<LegacyExperiential> LegacyExperientialEmployers { get; set; }
        public virtual ICollection<LegacyInternship> LegacyInternshipCompanies { get; set; }
        public virtual ICollection<LegacyInternship> LegacyInternshipEmployers { get; set; }
        public virtual ICollection<LegacyLearnership> LegacyLearnerships { get; set; }
        public virtual ICollection<LegacyOrganisationSite> LegacyOrganisationSites { get; set; }
        public virtual ICollection<LegacyProviderApplicationAlterationAudit> LegacyProviderApplicationAlterationAudits { get; set; }
        public virtual ICollection<LegacyProviderApplicationSiteAllocation> LegacyProviderApplicationSiteAllocations { get; set; }
        public virtual ICollection<LegacyProviderQualification> LegacyProviderQualifications { get; set; }
        public virtual ICollection<LegacySectTwentyEight> LegacySectTwentyEightCompanies { get; set; }
        public virtual ICollection<LegacySectTwentyEight> LegacySectTwentyEightEmployers { get; set; }
        public virtual ICollection<LegacySkillsProgramme> LegacySkillsProgrammes { get; set; }
        public virtual ICollection<LegacyTvet> LegacyTvetCompanies { get; set; }
        public virtual ICollection<LegacyTvet> LegacyTvetEmployers { get; set; }
        public virtual ICollection<LegacyUnitStandard> LegacyUnitStandards { get; set; }
        public virtual ICollection<MgVerificationCompleted> MgVerificationCompleteds { get; set; }
        public virtual ICollection<MgVerificationDetail> MgVerificationDetails { get; set; }
        public virtual ICollection<NonSetaQualificationsCompletion> NonSetaQualificationsCompletionCompanies { get; set; }
        public virtual ICollection<NonSetaQualificationsCompletion> NonSetaQualificationsCompletionTrainingProviders { get; set; }
        public virtual ICollection<PaymentRequest> PaymentRequests { get; set; }
        public virtual ICollection<ProjectImplementationPlanLearner> ProjectImplementationPlanLearners { get; set; }
        public virtual ICollection<ProjectImplementationPlan> ProjectImplementationPlans { get; set; }
        public virtual ICollection<ProviderApplicationSuspensionDeActivated> ProviderApplicationSuspensionDeActivateds { get; set; }
        public virtual ICollection<QdfCompany> QdfCompanies { get; set; }
        public virtual ICollection<QualificationsCurriculumDevelopment> QualificationsCurriculumDevelopments { get; set; }
        public virtual ICollection<RejectReasonsChild> RejectReasonsChildren { get; set; }
        public virtual ICollection<ScheduleChangesLog> ScheduleChangesLogs { get; set; }
        public virtual ICollection<ScheduledEvent> ScheduledEvents { get; set; }
        public virtual ICollection<SdfCompany> SdfCompanies { get; set; }
        public virtual ICollection<SdfCompanyHistory> SdfCompanyHistories { get; set; }
        public virtual ICollection<SdpCompany> SdpCompanies { get; set; }
        public virtual ICollection<SdpCompanyAction> SdpCompanyActions { get; set; }
        public virtual ICollection<SdpCompanyHistory> SdpCompanyHistories { get; set; }
        public virtual ICollection<SiteVisitReportNew> SiteVisitReportNews { get; set; }
        public virtual ICollection<SiteVisit> SiteVisits { get; set; }
        public virtual ICollection<Site> Sites { get; set; }
        public virtual ICollection<SitesHistory> SitesHistories { get; set; }
        public virtual ICollection<SitesSme> SitesSmes { get; set; }
        public virtual ICollection<SkillsRegistration> SkillsRegistrations { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
        public virtual ICollection<TrainingComitteeHostory> TrainingComitteeHostories { get; set; }
        public virtual ICollection<TrainingComittee> TrainingComittees { get; set; }
        public virtual ICollection<TrainingProviderApplication> TrainingProviderApplications { get; set; }
        public virtual ICollection<TrainingProviderMonitoring> TrainingProviderMonitorings { get; set; }
        public virtual ICollection<TrainingProviderVerfication> TrainingProviderVerfications { get; set; }
        public virtual ICollection<TrainingSite> TrainingSites { get; set; }
        public virtual ICollection<UpdateAuditTrail> UpdateAuditTrails { get; set; }
        public virtual ICollection<UsersTrainingProvider> UsersTrainingProviders { get; set; }
        public virtual ICollection<WorkPlaceApprovalDatum> WorkPlaceApprovalData { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovals { get; set; }
        public virtual ICollection<WorkplaceMonitoringSiteVisit> WorkplaceMonitoringSiteVisits { get; set; }
        public virtual ICollection<WorkplaceMonitoring> WorkplaceMonitorings { get; set; }
        public virtual ICollection<WspCalculationDatum> WspCalculationData { get; set; }
        public virtual ICollection<WspCompanyAddressHistory> WspCompanyAddressHistories { get; set; }
        public virtual ICollection<WspCompanyMainHistory> WspCompanyMainHistories { get; set; }
        public virtual ICollection<WspSdfCompanyHistory> WspSdfCompanyHistories { get; set; }
        public virtual ICollection<Wsp> Wsps { get; set; }
    }
}

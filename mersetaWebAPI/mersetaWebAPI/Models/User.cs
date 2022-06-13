using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class User
    {
        public User()
        {
            /*ActiveContractClos = new HashSet<ActiveContract>();
            ActiveContractCrms = new HashSet<ActiveContract>();
            ActiveContractDetails = new HashSet<ActiveContractDetail>();
            ActiveContractExtensionRequestApproveUsers = new HashSet<ActiveContractExtensionRequest>();
            ActiveContractExtensionRequestRequestUsers = new HashSet<ActiveContractExtensionRequest>();
            ActiveContractExtensionRequestUserUpdatedDates = new HashSet<ActiveContractExtensionRequest>();
            ActiveContractRejectionUserNavigations = new HashSet<ActiveContract>();
            ActiveContractSdfs = new HashSet<ActiveContract>();
            ActiveContractTerminationRequestApproveUsers = new HashSet<ActiveContractTerminationRequest>();
            ActiveContractTerminationRequestRequestUsers = new HashSet<ActiveContractTerminationRequest>();
            ActiveContractUserResponsibleMoaSignOffs = new HashSet<ActiveContract>();
            ActiveContractWithdrawnUsers = new HashSet<ActiveContract>();
            AddressChanges = new HashSet<AddressChange>();
            AddressHistories = new HashSet<AddressHistory>();
            Addresses = new HashSet<Address>();
            AdministrationOfApqAssessors = new HashSet<AdministrationOfApq>();
            AdministrationOfApqModerators = new HashSet<AdministrationOfApq>();
            AdministrationOfApqUsers = new HashSet<AdministrationOfApq>();
            AppointmentAppointmentWithUsers = new HashSet<Appointment>();
            AppointmentUsers = new HashSet<Appointment>();
            AssessorModExtensionOfScopes = new HashSet<AssessorModExtensionOfScope>();
            AssessorModReRegistrations = new HashSet<AssessorModReRegistration>();
            AssessorModeratorApplicationCreateUsers = new HashSet<AssessorModeratorApplication>();
            AssessorModeratorApplicationLastUpdateUsers = new HashSet<AssessorModeratorApplication>();
            AssessorModeratorApplicationUsers = new HashSet<AssessorModeratorApplication>();
            AssessorModeratorCompanies = new HashSet<AssessorModeratorCompany>();
            AssessorModeratorCompanySiteAssessorModerators = new HashSet<AssessorModeratorCompanySite>();
            AssessorModeratorCompanySiteCreateUsers = new HashSet<AssessorModeratorCompanySite>();
            AssessorModeratorCompanySiteLastActionUserNavigations = new HashSet<AssessorModeratorCompanySite>();
            BankingDetails = new HashSet<BankingDetail>();
            BugReports = new HashSet<BugReport>();
            ChatMessageAttendToByStaffs = new HashSet<ChatMessage>();
            ChatMessageUsers = new HashSet<ChatMessage>();
            CompanyCommunicationCreateUsers = new HashSet<CompanyCommunication>();
            CompanyCommunicationLastUpdateUsers = new HashSet<CompanyCommunication>();
            CompanyDeregisterUsers = new HashSet<Company>();
            CompanyFormUsers = new HashSet<Company>();
            CompanyHistories = new HashSet<CompanyHistory>();
            CompanyLearnerCreateUsers = new HashSet<CompanyLearner>();
            CompanyLearnerUserCreateUsers = new HashSet<CompanyLearnerUser>();
            CompanyLearnerUserLegalGaurdians = new HashSet<CompanyLearnerUser>();
            CompanyLearnerUserUsers = new HashSet<CompanyLearnerUser>();
            CompanyLearnerUsers = new HashSet<CompanyLearner>();
            CompanyLearnersChangeApprovalUsers = new HashSet<CompanyLearnersChange>();
            CompanyLearnersChangeCreateUsers = new HashSet<CompanyLearnersChange>();
            CompanyLearnersDetailsChangeCreateUsers = new HashSet<CompanyLearnersDetailsChange>();
            CompanyLearnersDetailsChangeUsers = new HashSet<CompanyLearnersDetailsChange>();
            CompanyLearnersLostTimeApprovalUsers = new HashSet<CompanyLearnersLostTime>();
            CompanyLearnersLostTimeCreateUsers = new HashSet<CompanyLearnersLostTime>();
            CompanyLearnersTerminationCreateUsers = new HashSet<CompanyLearnersTermination>();
            CompanyLearnersTerminationInvestigatorUsers = new HashSet<CompanyLearnersTermination>();
            CompanyLearnersTradeTestAdminUsers = new HashSet<CompanyLearnersTradeTest>();
            CompanyLearnersTradeTestApprovedUsers = new HashSet<CompanyLearnersTradeTest>();
            CompanyLearnersTradeTestClientServiceAdminUsers = new HashSet<CompanyLearnersTradeTest>();
            CompanyLearnersTradeTestCoordinatorUsers = new HashSet<CompanyLearnersTradeTest>();
            CompanyLearnersTradeTestCreateUsers = new HashSet<CompanyLearnersTradeTest>();
            CompanyLearnersTradeTestLearners = new HashSet<CompanyLearnersTradeTest>();
            CompanyLearnersTradeTestQualityAssurorUsers = new HashSet<CompanyLearnersTradeTest>();
            CompanyLearnersTradeTestTestCenterUsers = new HashSet<CompanyLearnersTradeTest>();
            CompanyLearnersTransferAdminUsers = new HashSet<CompanyLearnersTransfer>();
            CompanyLearnersTransferApproveUser1s = new HashSet<CompanyLearnersTransfer>();
            CompanyLearnersTransferApproveUserNavigations = new HashSet<CompanyLearnersTransfer>();
            CompanyLearnersTransferCompanySelectedApprovalUserNavigations = new HashSet<CompanyLearnersTransfer>();
            CompanyLearnersTransferCoordinatorUsers = new HashSet<CompanyLearnersTransfer>();
            CompanyLearnersTransferCreateUser1s = new HashSet<CompanyLearnersTransfer>();
            CompanyLearnersTransferCreateUserNavigations = new HashSet<CompanyLearnersTransfer>();
            CompanyLearnersTransferLearnerApprovedNavigations = new HashSet<CompanyLearnersTransfer>();
            CompanyLearnersTransferLearnerUsers = new HashSet<CompanyLearnersTransfer>();
            CompanyLearnersTransferTransferCompanyRepresentativeUsers = new HashSet<CompanyLearnersTransfer>();
            CompanyUsers = new HashSet<CompanyUser>();
            CompanyUsersHistories = new HashSet<CompanyUsersHistory>();
            CompletionLetters = new HashSet<CompletionLetter>();
            CoursewareDistibutions = new HashSet<CoursewareDistibution>();
            DateChangeMultipleSelections = new HashSet<DateChangeMultipleSelection>();
            DgAllocationParentSubmissionUsers = new HashSet<DgAllocationParent>();
            DgAllocationParentUserAppealedNavigations = new HashSet<DgAllocationParent>();
            DgAllocationParentUserApproveRejectedAppealNavigations = new HashSet<DgAllocationParent>();
            DgContractingBulkEntryApprovalUsers = new HashSet<DgContractingBulkEntry>();
            DgContractingBulkEntryCreateUsers = new HashSet<DgContractingBulkEntry>();
            DgContractingBulkEntrySubmissionUserNavigations = new HashSet<DgContractingBulkEntry>();
            DgContractingBulkItemApprovalUsers = new HashSet<DgContractingBulkItem>();
            DgContractingBulkItemCreateUsers = new HashSet<DgContractingBulkItem>();
            DgVerificationCloUsers = new HashSet<DgVerification>();
            DgVerificationCrmUsers = new HashSet<DgVerification>();
            DgVerificationFinalResponseNavigations = new HashSet<DgVerification>();
            DgVerificationRejectionInformations = new HashSet<DgVerificationRejectionInformation>();
            DocForUsers = new HashSet<Doc>();
            DocUsers = new HashSet<Doc>();
            DocumentTrackers = new HashSet<DocumentTracker>();
            ExtensionRequestApprovedUsers = new HashSet<ExtensionRequest>();
            ExtensionRequestUsers = new HashSet<ExtensionRequest>();
            GpBankAccountAlterAudits = new HashSet<GpBankAccountAlterAudit>();
            GpGrantBatchEntries = new HashSet<GpGrantBatchEntry>();
            GpGrantBatchListApproveUsers = new HashSet<GpGrantBatchList>();
            GpGrantBatchListCreateUsers = new HashSet<GpGrantBatchList>();
            HostingCompanyEmployeeTemplates = new HashSet<HostingCompanyEmployeeTemplate>();
            HostingCompanyEmployees = new HashSet<HostingCompanyEmployee>();
            HostingCompanyTemplates = new HashSet<HostingCompanyTemplate>();
            Images = new HashSet<Image>();
            InterSetaTransfers = new HashSet<InterSetaTransfer>();
            InverseLastChgUser = new HashSet<User>();
            InverseLegalGaurdian = new HashSet<User>();
            LearnershipDevelopmentRegistrations = new HashSet<LearnershipDevelopmentRegistration>();
            LegacyProviderApplicationAlterationAudits = new HashSet<LegacyProviderApplicationAlterationAudit>();
            LegacyProviderApplicationSiteAllocations = new HashSet<LegacyProviderApplicationSiteAllocation>();
            LevyDetailMgPaymentsAlterAudits = new HashSet<LevyDetailMgPaymentsAlterAudit>();
            MailLogs = new HashSet<MailLog>();
            MandatoryGrantRecommendations = new HashSet<MandatoryGrantRecommendation>();
            MgVerificationCloGeneratedFors = new HashSet<MgVerification>();
            MgVerificationCrmUserAssigneds = new HashSet<MgVerification>();
            MgVerificationPrimaryUserSignOffs = new HashSet<MgVerification>();
            NambDecisionHistories = new HashSet<NambDecisionHistory>();
            NonSetaCompanyUsers = new HashSet<NonSetaCompanyUser>();
            NonSetaQualificationsCompletions = new HashSet<NonSetaQualificationsCompletion>();
            NsdpQuarterReportings = new HashSet<NsdpQuarterReporting>();
            NsdpReportConfigs = new HashSet<NsdpReportConfig>();
            PaymentRequestApprovalUsers = new HashSet<PaymentRequest>();
            PaymentRequestCreateUsers = new HashSet<PaymentRequest>();
            PaymentRequestRegionalManagerUsers = new HashSet<PaymentRequest>();
            PaymentRequestSloUsers = new HashSet<PaymentRequest>();
            ProviderApplicationSuspensionDeActivateds = new HashSet<ProviderApplicationSuspensionDeActivated>();
            ProviderApplicationTradeTestAssessorsLinkCreateUsers = new HashSet<ProviderApplicationTradeTestAssessorsLink>();
            ProviderApplicationTradeTestAssessorsLinkUpdateUsers = new HashSet<ProviderApplicationTradeTestAssessorsLink>();
            QdfCompanyReviewUsers = new HashSet<QdfCompany>();
            QdfCompanyUsers = new HashSet<QdfCompany>();
            QdfCompanyUsersNavigation = new HashSet<QdfCompanyUser>();
            QualificationMultipleSelections = new HashSet<QualificationMultipleSelection>();
            QualificationsCurriculumDevelopmentApproveUserNavigations = new HashSet<QualificationsCurriculumDevelopment>();
            QualificationsCurriculumDevelopmentCreateUserNavigations = new HashSet<QualificationsCurriculumDevelopment>();
            QualificationsCurriculumDevelopmentSubmitUserNavigations = new HashSet<QualificationsCurriculumDevelopment>();
            QualificationsCurriculumDevelopmentUploadUserNavigations = new HashSet<QualificationsCurriculumDevelopment>();
            RejectReasonMultipleSelectionHists = new HashSet<RejectReasonMultipleSelectionHist>();
            RejectReasonMultipleSelections = new HashSet<RejectReasonMultipleSelection>();
            RejectReasonsChildren = new HashSet<RejectReasonsChild>();
            ReportGenerationProperties = new HashSet<ReportGenerationProperty>();
            ReviewCommitteeMeetingUsers = new HashSet<ReviewCommitteeMeetingUser>();
            ReviewCommitteeMeetings = new HashSet<ReviewCommitteeMeeting>();
            SarsFiles = new HashSet<SarsFile>();
            SarsLevyDetailCalculations = new HashSet<SarsLevyDetailCalculation>();
            SarsLevySchemeYearReturns = new HashSet<SarsLevySchemeYearReturn>();
            ScheduleChangesLogs = new HashSet<ScheduleChangesLog>();
            ScheduledEventUsers = new HashSet<ScheduledEventUser>();
            ScheduledEvents = new HashSet<ScheduledEvent>();
            SdfCompanies = new HashSet<SdfCompany>();
            SdfCompanyHistories = new HashSet<SdfCompanyHistory>();
            SdpCompanies = new HashSet<SdpCompany>();
            SdpCompanyActionApprovalUsers = new HashSet<SdpCompanyAction>();
            SdpCompanyActionCreateUsers = new HashSet<SdpCompanyAction>();
            SdpCompanyActionSdpUsers = new HashSet<SdpCompanyAction>();
            SdpCompanyHistories = new HashSet<SdpCompanyHistory>();
            SdpExtensionOfScopeManagerQaUsers = new HashSet<SdpExtensionOfScope>();
            SdpExtensionOfScopeQualityAssuranceUsers = new HashSet<SdpExtensionOfScope>();
            SdpExtensionOfScopeSenioManagerQaUsers = new HashSet<SdpExtensionOfScope>();
            SdpExtensionOfScopeUsers = new HashSet<SdpExtensionOfScope>();
            SdpReAccreditations = new HashSet<SdpReAccreditation>();
            SignoffChangeUsers = new HashSet<Signoff>();
            SignoffUsers = new HashSet<Signoff>();
            SiteVisitReportDisputes = new HashSet<SiteVisitReportDispute>();
            SiteVisitReportNews = new HashSet<SiteVisitReportNew>();
            SiteVisitReportSmes = new HashSet<SiteVisitReportSme>();
            SiteVisits = new HashSet<SiteVisit>();
            Sites = new HashSet<Site>();
            SitesHistories = new HashSet<SitesHistory>();
            SitesSmeApproveUsers = new HashSet<SitesSme>();
            SitesSmeDeleteUsers = new HashSet<SitesSme>();
            SkillsRegistrations = new HashSet<SkillsRegistration>();
            SmeQualifications = new HashSet<SmeQualification>();
            StakeholderRelations = new HashSet<StakeholderRelation>();
            StakeholderRelationsSurveys = new HashSet<StakeholderRelationsSurvey>();
            StrategicPrioritiesNavigation = new HashSet<StrategicPriority>();
            SummativeAssessmentReportUnitStandardAssessorUsers = new HashSet<SummativeAssessmentReportUnitStandard>();
            SummativeAssessmentReportUnitStandardModeratorUsers = new HashSet<SummativeAssessmentReportUnitStandard>();
            SummativeAssessmentReports = new HashSet<SummativeAssessmentReport>();
            TaskActionUsers = new HashSet<Task>();
            TaskCreateUsers = new HashSet<Task>();
            TaskUsers = new HashSet<TaskUser>();
            TempSignoffs = new HashSet<TempSignoff>();
            TrainingProviderApplicationManagerQaUsers = new HashSet<TrainingProviderApplication>();
            TrainingProviderApplicationQualityAssuranceUsers = new HashSet<TrainingProviderApplication>();
            TrainingProviderApplicationSenioManagerQaUsers = new HashSet<TrainingProviderApplication>();
            TrainingProviderApplicationUsers = new HashSet<TrainingProviderApplication>();
            TrainingProviderMonitoringInitiatingQas = new HashSet<TrainingProviderMonitoring>();
            TrainingProviderMonitoringQaManagers = new HashSet<TrainingProviderMonitoring>();
            TrainingProviderMonitoringSpdUsers = new HashSet<TrainingProviderMonitoring>();
            TrainingProviderMonitoringUsers = new HashSet<TrainingProviderMonitoring>();
            TrainingProviderVerficationCreateUsers = new HashSet<TrainingProviderVerfication>();
            TrainingProviderVerficationReviewUsers = new HashSet<TrainingProviderVerfication>();
            TrainingSites = new HashSet<TrainingSite>();
            TransactionsCompanyValidiations = new HashSet<TransactionsCompanyValidiation>();
            UpdateAuditTrails = new HashSet<UpdateAuditTrail>();
            UserBrowserInformations = new HashSet<UserBrowserInformation>();
            UserChangeRequestLegalGaurdians = new HashSet<UserChangeRequest>();
            UserChangeRequestUsers = new HashSet<UserChangeRequest>();
            UserHostingCompanies = new HashSet<UserHostingCompany>();
            UserLearnerships = new HashSet<UserLearnership>();
            UserPermissions = new HashSet<UserPermission>();
            UserQualificationUpdateUsers = new HashSet<UserQualification>();
            UserQualificationUsers = new HashSet<UserQualification>();
            UserSkillsProgrammes = new HashSet<UserSkillsProgramme>();
            UserUnitStandards = new HashSet<UserUnitStandard>();
            UsersDisabilityUpdateUsers = new HashSet<UsersDisability>();
            UsersDisabilityUsers = new HashSet<UsersDisability>();
            UsersLanguageUpdateUsers = new HashSet<UsersLanguage>();
            UsersLanguageUsers = new HashSet<UsersLanguage>();
            UsersRoles = new HashSet<UsersRole>();
            UsersTrainingProviders = new HashSet<UsersTrainingProvider>();
            UsersTypes = new HashSet<UsersType>();
            WithdrawReasonMultipleSelections = new HashSet<WithdrawReasonMultipleSelection>();
            WorkPlaceApprovalMentors = new HashSet<WorkPlaceApprovalMentor>();
            WorkPlaceApprovalSites = new HashSet<WorkPlaceApprovalSite>();
            WorkPlaceApprovalTrades = new HashSet<WorkPlaceApprovalTrade>();
            WorkPlaceApprovalVisitDateLogs = new HashSet<WorkPlaceApprovalVisitDateLog>();
            WorkPlaceApprovals = new HashSet<WorkPlaceApproval>();
            WorkplaceMonitoringActionPlans = new HashSet<WorkplaceMonitoringActionPlan>();
            WorkplaceMonitoringDgMonitorings = new HashSet<WorkplaceMonitoringDgMonitoring>();
            WorkplaceMonitoringDiscretionaryGrantComplianceSurveys = new HashSet<WorkplaceMonitoringDiscretionaryGrantComplianceSurvey>();
            WorkplaceMonitoringLearnerInductions = new HashSet<WorkplaceMonitoringLearnerInduction>();
            WorkplaceMonitoringLearnerPayments = new HashSet<WorkplaceMonitoringLearnerPayment>();
            WorkplaceMonitoringLearnerSurveyAnswers = new HashSet<WorkplaceMonitoringLearnerSurveyAnswer>();
            WorkplaceMonitoringLearnerSurveys = new HashSet<WorkplaceMonitoringLearnerSurvey>();
            WorkplaceMonitoringMitigationPlanCreateUsers = new HashSet<WorkplaceMonitoringMitigationPlan>();
            WorkplaceMonitoringMitigationPlanLastActionUserNavigations = new HashSet<WorkplaceMonitoringMitigationPlan>();
            WorkplaceMonitoringMitigations = new HashSet<WorkplaceMonitoringMitigation>();
            WorkplaceMonitoringSiteVisitApprovedUsers = new HashSet<WorkplaceMonitoringSiteVisit>();
            WorkplaceMonitoringSiteVisitCloUsers = new HashSet<WorkplaceMonitoringSiteVisit>();
            WorkplaceMonitoringSiteVisitCreateUsers = new HashSet<WorkplaceMonitoringSiteVisit>();
            WorkplaceMonitoringSiteVisitCrmUsers = new HashSet<WorkplaceMonitoringSiteVisit>();
            WorkplaceMonitoringSiteVisitManagerAssignedCloUsers = new HashSet<WorkplaceMonitoringSiteVisit>();
            WorkplaceMonitoringSiteVisitManagerAssignedCrmUsers = new HashSet<WorkplaceMonitoringSiteVisit>();
            WorkplaceMonitoringSiteVisitNonComplianceApprovalUsers = new HashSet<WorkplaceMonitoringSiteVisit>();
            WorkplaceMonitoringSiteVisitNonComplianceSubmittedUserNavigations = new HashSet<WorkplaceMonitoringSiteVisit>();
            WorkplaceMonitorings = new HashSet<WorkplaceMonitoring>();
            WspCompanyAddressHistories = new HashSet<WspCompanyAddressHistory>();
            WspCompanyHistoryDeregisterUsers = new HashSet<WspCompanyHistory>();
            WspCompanyHistoryFormUsers = new HashSet<WspCompanyHistory>();
            WspCreateUsers = new HashSet<Wsp>();
            WspDisputes = new HashSet<WspDispute>();
            WspProjectManagerNavigations = new HashSet<Wsp>();
            WspProjectOwnerNavigations = new HashSet<Wsp>();
            WspRejectionInformations = new HashSet<WspRejectionInformation>();
            WspSdfCompanyHistories = new HashSet<WspSdfCompanyHistory>();
            WspSignoffs = new HashSet<WspSignoff>();
            WspUserReopenedApplicationNavigations = new HashSet<Wsp>();
            WspUserRequestedMancoApprovalNavigations = new HashSet<Wsp>(); */
        }

        public long Id { get; set; }
        public ulong? Active { get; set; }
        public ulong? Admin { get; set; }
        public string? CellNumber { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Email { get; set; }
        public DateTime? EmailConfirmDate { get; set; }
        public string? EmailGuid { get; set; }
        public string? FaxNumber { get; set; }
        public string FirstName { get; set; } = null!;
        public string? IosAndroid { get; set; }
        public DateTime? LastLogin { get; set; }
        public string LastName { get; set; } = null!;
        public string? PassportNumber { get; set; }
        public string Password { get; set; } = null!;
        public string? PhoneId { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string? RsaIdNumber { get; set; }
        public int? Status { get; set; }
        public string? TelNumber { get; set; }
        public string? Username { get; set; }
        public string? WorkContactNumber { get; set; }
        public long? DisabilityStatus { get; set; }
        public long? DisabledId { get; set; }
        public long? GenderId { get; set; }
        public long? LastChgUserId { get; set; }
        public int? MunicipalityId { get; set; }
        public long? NationalityId { get; set; }
        public long? PostalAddressId { get; set; }
        public long? ProfileImageId { get; set; }
        public long? ResidentialAddressId { get; set; }
        public int? ApprovalEnum { get; set; }
        public long? EquityId { get; set; }
        public DateTime? ConfirmExpireDate { get; set; }
        public ulong? RecieveEmailTaskNotification { get; set; }
        public long? OfficeId { get; set; }
        public ulong? SuperAdmin { get; set; }
        public ulong? Finance { get; set; }
        public ulong? Approved { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string? MiddleName { get; set; }
        public ulong? AcceptPopi { get; set; }
        public ulong? ViewBugs { get; set; }
        public ulong? UploadData { get; set; }
        public ulong? ViewUploadData { get; set; }
        public long? TitleId { get; set; }
        public ulong? ViewExtensionRequest { get; set; }
        public long? HomeLanguage { get; set; }
        public int? UndertakenLearningProgramBefore { get; set; }
        public long? LearnershipId { get; set; }
        public long? QualificationId { get; set; }
        public long? LegalGaurdianId { get; set; }
        public ulong? QualWorkplaceAssignment { get; set; }
        public ulong? TempReporting { get; set; }
        public ulong? AlloocateDg { get; set; }
        public int? EmploymentStatus { get; set; }
        public int? IdType { get; set; }
        public int? PartOfUnion { get; set; }
        public ulong? ProcessAssessorModApplication { get; set; }
        public ulong? ReviewCommitteeMember { get; set; }
        public int? UrbanRuralEnum { get; set; }
        public long? OrganisedLabourUnionMembershipId { get; set; }
        public long? UnionMembershipId { get; set; }
        public ulong? MancoMember { get; set; }
        public DateTime? EmploymentStartDate { get; set; }
        public ulong? LearnerReviewMember { get; set; }
        public string? TempRasIdOrPassportNumber { get; set; }
        public long? BirthAddressId { get; set; }
        public int? Maried { get; set; }
        public ulong? ProjectCreation { get; set; }
        public ulong? ProjectTermination { get; set; }
        public long? DisabilityRatingId { get; set; }
        public long? MaritalStatusId { get; set; }
        public long? OfoCodesId { get; set; }
        public ulong? CoursewareDistroSub { get; set; }
        public ulong? MancoGrantApproval { get; set; }
        public DateTime? LastSchoolYear { get; set; }
        public ulong? DgContractingBulkApproval { get; set; }
        public int? Disability { get; set; }
        public ulong? RegisterLearner { get; set; }
        public int? RsaCitizenType { get; set; }
        public ulong? DataExtracts { get; set; }
        public ulong? WspManagment { get; set; }
        public ulong? GpTransactionsManagement { get; set; }
        public DateTime? ValidiationRanDate { get; set; }
        public string? FirstNameAltered { get; set; }
        public string? FirstNameOrginal { get; set; }
        public string? MiddleNameAltered { get; set; }
        public string? MiddleNameOrginal { get; set; }
        public long? BirthTownId { get; set; }
        public ulong? AddAssessment { get; set; }
        public ulong? GenerateCertificates { get; set; }
        public long? PreviousSchools { get; set; }
        public ulong? SarsLevyDetailCalc { get; set; }
        public ulong? SarsLevyMandInvoicesUpdate { get; set; }
        public ulong? GpBankingDetails { get; set; }
        public ulong? LevyDetailMgTransactions { get; set; }
        public ulong? AlterLegacyApplications { get; set; }
        public ulong? QmrAccess { get; set; }
        public ulong? MoaRegisterAccess { get; set; }
        public ulong? CompanyRegisterReport { get; set; }
        public ulong? DgVerificationReport { get; set; }
        public ulong? GrantTrendAnylsis { get; set; }
        public ulong? MgVerificationReport { get; set; }
        public ulong? PrioirtySkillsReport { get; set; }
        public ulong? TaskReporting { get; set; }
        public ulong? NsdpReportConfig { get; set; }
        public ulong? NsdpReportEdit { get; set; }
        public ulong? NsdpReportView { get; set; }
        public string? MaidenName { get; set; }
        public ulong? WithdrawContracts { get; set; }
        public ulong? SspReporting { get; set; }
        public ulong? FundingWindow { get; set; }
        public ulong? HoldingRoom { get; set; }
        public ulong? StrategicPriorities { get; set; }
        public DateTime? AcceptPopiDate { get; set; }
        public long? CreateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? LastUpdateUser { get; set; }
        public string? CitizenResidentStatus { get; set; }
        public string? Province { get; set; }
        public string? NextOfKinName { get; set; }
        public string? NextOfKinTelephone { get; set; }
        public string? PrimaryEmailAddress { get; set; }
        public string? SecondaryEmailAddress { get; set; }
        public DateTime? LearnerSubmissionDate { get; set; }
        public DateTime? DateStamp { get; set; }

        public virtual Address? BirthAddress { get; set; }
        public virtual Town? BirthTown { get; set; }
        public virtual DisabilityRating? DisabilityRating { get; set; }
        public virtual DisabilityStatus? DisabilityStatusNavigation { get; set; }
        public virtual YesNoLookup? Disabled { get; set; }
        public virtual Equity? Equity { get; set; }
        public virtual Gender? Gender { get; set; }
        public virtual Language? HomeLanguageNavigation { get; set; }
        public virtual User? LastChgUser { get; set; }
        public virtual Learnership? Learnership { get; set; }
        public virtual User? LegalGaurdian { get; set; }
        public virtual MaritalStatus? MaritalStatus { get; set; }
        public virtual Municipality? Municipality { get; set; }
        public virtual Nationality? Nationality { get; set; }
        public virtual Office? Office { get; set; }
        public virtual OfoCode? OfoCodes { get; set; }
        public virtual OrganisedLabourUnion? OrganisedLabourUnionMembership { get; set; }
        public virtual Address? PostalAddress { get; set; }
        public virtual PreviousSchool? PreviousSchoolsNavigation { get; set; }
        public virtual Image? ProfileImage { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual Address? ResidentialAddress { get; set; }
        public virtual Title? Title { get; set; }
        public virtual UnionMembership? UnionMembership { get; set; }
        public virtual ICollection<ActiveContract> ActiveContractClos { get; set; }
        public virtual ICollection<ActiveContract> ActiveContractCrms { get; set; }
        public virtual ICollection<ActiveContractDetail> ActiveContractDetails { get; set; }
        public virtual ICollection<ActiveContractExtensionRequest> ActiveContractExtensionRequestApproveUsers { get; set; }
        public virtual ICollection<ActiveContractExtensionRequest> ActiveContractExtensionRequestRequestUsers { get; set; }
        public virtual ICollection<ActiveContractExtensionRequest> ActiveContractExtensionRequestUserUpdatedDates { get; set; }
        public virtual ICollection<ActiveContract> ActiveContractRejectionUserNavigations { get; set; }
        public virtual ICollection<ActiveContract> ActiveContractSdfs { get; set; }
        public virtual ICollection<ActiveContractTerminationRequest> ActiveContractTerminationRequestApproveUsers { get; set; }
        public virtual ICollection<ActiveContractTerminationRequest> ActiveContractTerminationRequestRequestUsers { get; set; }
        public virtual ICollection<ActiveContract> ActiveContractUserResponsibleMoaSignOffs { get; set; }
        public virtual ICollection<ActiveContract> ActiveContractWithdrawnUsers { get; set; }
        public virtual ICollection<AddressChange> AddressChanges { get; set; }
        public virtual ICollection<AddressHistory> AddressHistories { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<AdministrationOfApq> AdministrationOfApqAssessors { get; set; }
        public virtual ICollection<AdministrationOfApq> AdministrationOfApqModerators { get; set; }
        public virtual ICollection<AdministrationOfApq> AdministrationOfApqUsers { get; set; }
        public virtual ICollection<Appointment> AppointmentAppointmentWithUsers { get; set; }
        public virtual ICollection<Appointment> AppointmentUsers { get; set; }
        public virtual ICollection<AssessorModExtensionOfScope> AssessorModExtensionOfScopes { get; set; }
        public virtual ICollection<AssessorModReRegistration> AssessorModReRegistrations { get; set; }
        public virtual ICollection<AssessorModeratorApplication> AssessorModeratorApplicationCreateUsers { get; set; }
        public virtual ICollection<AssessorModeratorApplication> AssessorModeratorApplicationLastUpdateUsers { get; set; }
        public virtual ICollection<AssessorModeratorApplication> AssessorModeratorApplicationUsers { get; set; }
        public virtual ICollection<AssessorModeratorCompany> AssessorModeratorCompanies { get; set; }
        public virtual ICollection<AssessorModeratorCompanySite> AssessorModeratorCompanySiteAssessorModerators { get; set; }
        public virtual ICollection<AssessorModeratorCompanySite> AssessorModeratorCompanySiteCreateUsers { get; set; }
        public virtual ICollection<AssessorModeratorCompanySite> AssessorModeratorCompanySiteLastActionUserNavigations { get; set; }
        public virtual ICollection<BankingDetail> BankingDetails { get; set; }
        public virtual ICollection<BugReport> BugReports { get; set; }
        public virtual ICollection<ChatMessage> ChatMessageAttendToByStaffs { get; set; }
        public virtual ICollection<ChatMessage> ChatMessageUsers { get; set; }
        public virtual ICollection<CompanyCommunication> CompanyCommunicationCreateUsers { get; set; }
        public virtual ICollection<CompanyCommunication> CompanyCommunicationLastUpdateUsers { get; set; }
        public virtual ICollection<Company> CompanyDeregisterUsers { get; set; }
        public virtual ICollection<Company> CompanyFormUsers { get; set; }
        public virtual ICollection<CompanyHistory> CompanyHistories { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearnerCreateUsers { get; set; }
        public virtual ICollection<CompanyLearnerUser> CompanyLearnerUserCreateUsers { get; set; }
        public virtual ICollection<CompanyLearnerUser> CompanyLearnerUserLegalGaurdians { get; set; }
        public virtual ICollection<CompanyLearnerUser> CompanyLearnerUserUsers { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearnerUsers { get; set; }
        public virtual ICollection<CompanyLearnersChange> CompanyLearnersChangeApprovalUsers { get; set; }
        public virtual ICollection<CompanyLearnersChange> CompanyLearnersChangeCreateUsers { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChangeCreateUsers { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChangeUsers { get; set; }
        public virtual ICollection<CompanyLearnersLostTime> CompanyLearnersLostTimeApprovalUsers { get; set; }
        public virtual ICollection<CompanyLearnersLostTime> CompanyLearnersLostTimeCreateUsers { get; set; }
        public virtual ICollection<CompanyLearnersTermination> CompanyLearnersTerminationCreateUsers { get; set; }
        public virtual ICollection<CompanyLearnersTermination> CompanyLearnersTerminationInvestigatorUsers { get; set; }
        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTestAdminUsers { get; set; }
        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTestApprovedUsers { get; set; }
        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTestClientServiceAdminUsers { get; set; }
        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTestCoordinatorUsers { get; set; }
        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTestCreateUsers { get; set; }
        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTestLearners { get; set; }
        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTestQualityAssurorUsers { get; set; }
        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTestTestCenterUsers { get; set; }
        public virtual ICollection<CompanyLearnersTransfer> CompanyLearnersTransferAdminUsers { get; set; }
        public virtual ICollection<CompanyLearnersTransfer> CompanyLearnersTransferApproveUser1s { get; set; }
        public virtual ICollection<CompanyLearnersTransfer> CompanyLearnersTransferApproveUserNavigations { get; set; }
        public virtual ICollection<CompanyLearnersTransfer> CompanyLearnersTransferCompanySelectedApprovalUserNavigations { get; set; }
        public virtual ICollection<CompanyLearnersTransfer> CompanyLearnersTransferCoordinatorUsers { get; set; }
        public virtual ICollection<CompanyLearnersTransfer> CompanyLearnersTransferCreateUser1s { get; set; }
        public virtual ICollection<CompanyLearnersTransfer> CompanyLearnersTransferCreateUserNavigations { get; set; }
        public virtual ICollection<CompanyLearnersTransfer> CompanyLearnersTransferLearnerApprovedNavigations { get; set; }
        public virtual ICollection<CompanyLearnersTransfer> CompanyLearnersTransferLearnerUsers { get; set; }
        public virtual ICollection<CompanyLearnersTransfer> CompanyLearnersTransferTransferCompanyRepresentativeUsers { get; set; }
        public virtual ICollection<CompanyUser> CompanyUsers { get; set; }
        public virtual ICollection<CompanyUsersHistory> CompanyUsersHistories { get; set; }
        public virtual ICollection<CompletionLetter> CompletionLetters { get; set; }
        public virtual ICollection<CoursewareDistibution> CoursewareDistibutions { get; set; }
        public virtual ICollection<DateChangeMultipleSelection> DateChangeMultipleSelections { get; set; }
        public virtual ICollection<DgAllocationParent> DgAllocationParentSubmissionUsers { get; set; }
        public virtual ICollection<DgAllocationParent> DgAllocationParentUserAppealedNavigations { get; set; }
        public virtual ICollection<DgAllocationParent> DgAllocationParentUserApproveRejectedAppealNavigations { get; set; }
        public virtual ICollection<DgContractingBulkEntry> DgContractingBulkEntryApprovalUsers { get; set; }
        public virtual ICollection<DgContractingBulkEntry> DgContractingBulkEntryCreateUsers { get; set; }
        public virtual ICollection<DgContractingBulkEntry> DgContractingBulkEntrySubmissionUserNavigations { get; set; }
        public virtual ICollection<DgContractingBulkItem> DgContractingBulkItemApprovalUsers { get; set; }
        public virtual ICollection<DgContractingBulkItem> DgContractingBulkItemCreateUsers { get; set; }
        public virtual ICollection<DgVerification> DgVerificationCloUsers { get; set; }
        public virtual ICollection<DgVerification> DgVerificationCrmUsers { get; set; }
        public virtual ICollection<DgVerification> DgVerificationFinalResponseNavigations { get; set; }
        public virtual ICollection<DgVerificationRejectionInformation> DgVerificationRejectionInformations { get; set; }
        public virtual ICollection<Doc> DocForUsers { get; set; }
        public virtual ICollection<Doc> DocUsers { get; set; }
        public virtual ICollection<DocumentTracker> DocumentTrackers { get; set; }
        public virtual ICollection<ExtensionRequest> ExtensionRequestApprovedUsers { get; set; }
        public virtual ICollection<ExtensionRequest> ExtensionRequestUsers { get; set; }
        public virtual ICollection<GpBankAccountAlterAudit> GpBankAccountAlterAudits { get; set; }
        public virtual ICollection<GpGrantBatchEntry> GpGrantBatchEntries { get; set; }
        public virtual ICollection<GpGrantBatchList> GpGrantBatchListApproveUsers { get; set; }
        public virtual ICollection<GpGrantBatchList> GpGrantBatchListCreateUsers { get; set; }
        public virtual ICollection<HostingCompanyEmployeeTemplate> HostingCompanyEmployeeTemplates { get; set; }
        public virtual ICollection<HostingCompanyEmployee> HostingCompanyEmployees { get; set; }
        public virtual ICollection<HostingCompanyTemplate> HostingCompanyTemplates { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<InterSetaTransfer> InterSetaTransfers { get; set; }
        public virtual ICollection<User> InverseLastChgUser { get; set; }
        public virtual ICollection<User> InverseLegalGaurdian { get; set; }
        public virtual ICollection<LearnershipDevelopmentRegistration> LearnershipDevelopmentRegistrations { get; set; }
        public virtual ICollection<LegacyProviderApplicationAlterationAudit> LegacyProviderApplicationAlterationAudits { get; set; }
        public virtual ICollection<LegacyProviderApplicationSiteAllocation> LegacyProviderApplicationSiteAllocations { get; set; }
        public virtual ICollection<LevyDetailMgPaymentsAlterAudit> LevyDetailMgPaymentsAlterAudits { get; set; }
        public virtual ICollection<MailLog> MailLogs { get; set; }
        public virtual ICollection<MandatoryGrantRecommendation> MandatoryGrantRecommendations { get; set; }
        public virtual ICollection<MgVerification> MgVerificationCloGeneratedFors { get; set; }
        public virtual ICollection<MgVerification> MgVerificationCrmUserAssigneds { get; set; }
        public virtual ICollection<MgVerification> MgVerificationPrimaryUserSignOffs { get; set; }
        public virtual ICollection<NambDecisionHistory> NambDecisionHistories { get; set; }
        public virtual ICollection<NonSetaCompanyUser> NonSetaCompanyUsers { get; set; }
        public virtual ICollection<NonSetaQualificationsCompletion> NonSetaQualificationsCompletions { get; set; }
        public virtual ICollection<NsdpQuarterReporting> NsdpQuarterReportings { get; set; }
        public virtual ICollection<NsdpReportConfig> NsdpReportConfigs { get; set; }
        public virtual ICollection<PaymentRequest> PaymentRequestApprovalUsers { get; set; }
        public virtual ICollection<PaymentRequest> PaymentRequestCreateUsers { get; set; }
        public virtual ICollection<PaymentRequest> PaymentRequestRegionalManagerUsers { get; set; }
        public virtual ICollection<PaymentRequest> PaymentRequestSloUsers { get; set; }
        public virtual ICollection<ProviderApplicationSuspensionDeActivated> ProviderApplicationSuspensionDeActivateds { get; set; }
        public virtual ICollection<ProviderApplicationTradeTestAssessorsLink> ProviderApplicationTradeTestAssessorsLinkCreateUsers { get; set; }
        public virtual ICollection<ProviderApplicationTradeTestAssessorsLink> ProviderApplicationTradeTestAssessorsLinkUpdateUsers { get; set; }
        public virtual ICollection<QdfCompany> QdfCompanyReviewUsers { get; set; }
        public virtual ICollection<QdfCompany> QdfCompanyUsers { get; set; }
        public virtual ICollection<QdfCompanyUser> QdfCompanyUsersNavigation { get; set; }
        public virtual ICollection<QualificationMultipleSelection> QualificationMultipleSelections { get; set; }
        public virtual ICollection<QualificationsCurriculumDevelopment> QualificationsCurriculumDevelopmentApproveUserNavigations { get; set; }
        public virtual ICollection<QualificationsCurriculumDevelopment> QualificationsCurriculumDevelopmentCreateUserNavigations { get; set; }
        public virtual ICollection<QualificationsCurriculumDevelopment> QualificationsCurriculumDevelopmentSubmitUserNavigations { get; set; }
        public virtual ICollection<QualificationsCurriculumDevelopment> QualificationsCurriculumDevelopmentUploadUserNavigations { get; set; }
        public virtual ICollection<RejectReasonMultipleSelectionHist> RejectReasonMultipleSelectionHists { get; set; }
        public virtual ICollection<RejectReasonMultipleSelection> RejectReasonMultipleSelections { get; set; }
        public virtual ICollection<RejectReasonsChild> RejectReasonsChildren { get; set; }
        public virtual ICollection<ReportGenerationProperty> ReportGenerationProperties { get; set; }
        public virtual ICollection<ReviewCommitteeMeetingUser> ReviewCommitteeMeetingUsers { get; set; }
        public virtual ICollection<ReviewCommitteeMeeting> ReviewCommitteeMeetings { get; set; }
        public virtual ICollection<SarsFile> SarsFiles { get; set; }
        public virtual ICollection<SarsLevyDetailCalculation> SarsLevyDetailCalculations { get; set; }
        public virtual ICollection<SarsLevySchemeYearReturn> SarsLevySchemeYearReturns { get; set; }
        public virtual ICollection<ScheduleChangesLog> ScheduleChangesLogs { get; set; }
        public virtual ICollection<ScheduledEventUser> ScheduledEventUsers { get; set; }
        public virtual ICollection<ScheduledEvent> ScheduledEvents { get; set; }
        public virtual ICollection<SdfCompany> SdfCompanies { get; set; }
        public virtual ICollection<SdfCompanyHistory> SdfCompanyHistories { get; set; }
        public virtual ICollection<SdpCompany> SdpCompanies { get; set; }
        public virtual ICollection<SdpCompanyAction> SdpCompanyActionApprovalUsers { get; set; }
        public virtual ICollection<SdpCompanyAction> SdpCompanyActionCreateUsers { get; set; }
        public virtual ICollection<SdpCompanyAction> SdpCompanyActionSdpUsers { get; set; }
        public virtual ICollection<SdpCompanyHistory> SdpCompanyHistories { get; set; }
        public virtual ICollection<SdpExtensionOfScope> SdpExtensionOfScopeManagerQaUsers { get; set; }
        public virtual ICollection<SdpExtensionOfScope> SdpExtensionOfScopeQualityAssuranceUsers { get; set; }
        public virtual ICollection<SdpExtensionOfScope> SdpExtensionOfScopeSenioManagerQaUsers { get; set; }
        public virtual ICollection<SdpExtensionOfScope> SdpExtensionOfScopeUsers { get; set; }
        public virtual ICollection<SdpReAccreditation> SdpReAccreditations { get; set; }
        public virtual ICollection<Signoff> SignoffChangeUsers { get; set; }
        public virtual ICollection<Signoff> SignoffUsers { get; set; }
        public virtual ICollection<SiteVisitReportDispute> SiteVisitReportDisputes { get; set; }
        public virtual ICollection<SiteVisitReportNew> SiteVisitReportNews { get; set; }
        public virtual ICollection<SiteVisitReportSme> SiteVisitReportSmes { get; set; }
        public virtual ICollection<SiteVisit> SiteVisits { get; set; }
        public virtual ICollection<Site> Sites { get; set; }
        public virtual ICollection<SitesHistory> SitesHistories { get; set; }
        public virtual ICollection<SitesSme> SitesSmeApproveUsers { get; set; }
        public virtual ICollection<SitesSme> SitesSmeDeleteUsers { get; set; }
        public virtual ICollection<SkillsRegistration> SkillsRegistrations { get; set; }
        public virtual ICollection<SmeQualification> SmeQualifications { get; set; }
        public virtual ICollection<StakeholderRelation> StakeholderRelations { get; set; }
        public virtual ICollection<StakeholderRelationsSurvey> StakeholderRelationsSurveys { get; set; }
        public virtual ICollection<StrategicPriority> StrategicPrioritiesNavigation { get; set; }
        public virtual ICollection<SummativeAssessmentReportUnitStandard> SummativeAssessmentReportUnitStandardAssessorUsers { get; set; }
        public virtual ICollection<SummativeAssessmentReportUnitStandard> SummativeAssessmentReportUnitStandardModeratorUsers { get; set; }
        public virtual ICollection<SummativeAssessmentReport> SummativeAssessmentReports { get; set; }
        public virtual ICollection<Task> TaskActionUsers { get; set; }
        public virtual ICollection<Task> TaskCreateUsers { get; set; }
        public virtual ICollection<TaskUser> TaskUsers { get; set; }
        public virtual ICollection<TempSignoff> TempSignoffs { get; set; }
        public virtual ICollection<TrainingProviderApplication> TrainingProviderApplicationManagerQaUsers { get; set; }
        public virtual ICollection<TrainingProviderApplication> TrainingProviderApplicationQualityAssuranceUsers { get; set; }
        public virtual ICollection<TrainingProviderApplication> TrainingProviderApplicationSenioManagerQaUsers { get; set; }
        public virtual ICollection<TrainingProviderApplication> TrainingProviderApplicationUsers { get; set; }
        public virtual ICollection<TrainingProviderMonitoring> TrainingProviderMonitoringInitiatingQas { get; set; }
        public virtual ICollection<TrainingProviderMonitoring> TrainingProviderMonitoringQaManagers { get; set; }
        public virtual ICollection<TrainingProviderMonitoring> TrainingProviderMonitoringSpdUsers { get; set; }
        public virtual ICollection<TrainingProviderMonitoring> TrainingProviderMonitoringUsers { get; set; }
        public virtual ICollection<TrainingProviderVerfication> TrainingProviderVerficationCreateUsers { get; set; }
        public virtual ICollection<TrainingProviderVerfication> TrainingProviderVerficationReviewUsers { get; set; }
        public virtual ICollection<TrainingSite> TrainingSites { get; set; }
        public virtual ICollection<TransactionsCompanyValidiation> TransactionsCompanyValidiations { get; set; }
        public virtual ICollection<UpdateAuditTrail> UpdateAuditTrails { get; set; }
        public virtual ICollection<UserBrowserInformation> UserBrowserInformations { get; set; }
        public virtual ICollection<UserChangeRequest> UserChangeRequestLegalGaurdians { get; set; }
        public virtual ICollection<UserChangeRequest> UserChangeRequestUsers { get; set; }
        public virtual ICollection<UserHostingCompany> UserHostingCompanies { get; set; }
        public virtual ICollection<UserLearnership> UserLearnerships { get; set; }
        public virtual ICollection<UserPermission> UserPermissions { get; set; }
        public virtual ICollection<UserQualification> UserQualificationUpdateUsers { get; set; }
        public virtual ICollection<UserQualification> UserQualificationUsers { get; set; }
        public virtual ICollection<UserSkillsProgramme> UserSkillsProgrammes { get; set; }
        public virtual ICollection<UserUnitStandard> UserUnitStandards { get; set; }
        public virtual ICollection<UsersDisability> UsersDisabilityUpdateUsers { get; set; }
        public virtual ICollection<UsersDisability> UsersDisabilityUsers { get; set; }
        public virtual ICollection<UsersLanguage> UsersLanguageUpdateUsers { get; set; }
        public virtual ICollection<UsersLanguage> UsersLanguageUsers { get; set; }
        public virtual ICollection<UsersRole> UsersRoles { get; set; }
        public virtual ICollection<UsersTrainingProvider> UsersTrainingProviders { get; set; }
        public virtual ICollection<UsersType> UsersTypes { get; set; }
        public virtual ICollection<WithdrawReasonMultipleSelection> WithdrawReasonMultipleSelections { get; set; }
        public virtual ICollection<WorkPlaceApprovalMentor> WorkPlaceApprovalMentors { get; set; }
        public virtual ICollection<WorkPlaceApprovalSite> WorkPlaceApprovalSites { get; set; }
        public virtual ICollection<WorkPlaceApprovalTrade> WorkPlaceApprovalTrades { get; set; }
        public virtual ICollection<WorkPlaceApprovalVisitDateLog> WorkPlaceApprovalVisitDateLogs { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovals { get; set; }
        public virtual ICollection<WorkplaceMonitoringActionPlan> WorkplaceMonitoringActionPlans { get; set; }
        public virtual ICollection<WorkplaceMonitoringDgMonitoring> WorkplaceMonitoringDgMonitorings { get; set; }
        public virtual ICollection<WorkplaceMonitoringDiscretionaryGrantComplianceSurvey> WorkplaceMonitoringDiscretionaryGrantComplianceSurveys { get; set; }
        public virtual ICollection<WorkplaceMonitoringLearnerInduction> WorkplaceMonitoringLearnerInductions { get; set; }
        public virtual ICollection<WorkplaceMonitoringLearnerPayment> WorkplaceMonitoringLearnerPayments { get; set; }
        public virtual ICollection<WorkplaceMonitoringLearnerSurveyAnswer> WorkplaceMonitoringLearnerSurveyAnswers { get; set; }
        public virtual ICollection<WorkplaceMonitoringLearnerSurvey> WorkplaceMonitoringLearnerSurveys { get; set; }
        public virtual ICollection<WorkplaceMonitoringMitigationPlan> WorkplaceMonitoringMitigationPlanCreateUsers { get; set; }
        public virtual ICollection<WorkplaceMonitoringMitigationPlan> WorkplaceMonitoringMitigationPlanLastActionUserNavigations { get; set; }
        public virtual ICollection<WorkplaceMonitoringMitigation> WorkplaceMonitoringMitigations { get; set; }
        public virtual ICollection<WorkplaceMonitoringSiteVisit> WorkplaceMonitoringSiteVisitApprovedUsers { get; set; }
        public virtual ICollection<WorkplaceMonitoringSiteVisit> WorkplaceMonitoringSiteVisitCloUsers { get; set; }
        public virtual ICollection<WorkplaceMonitoringSiteVisit> WorkplaceMonitoringSiteVisitCreateUsers { get; set; }
        public virtual ICollection<WorkplaceMonitoringSiteVisit> WorkplaceMonitoringSiteVisitCrmUsers { get; set; }
        public virtual ICollection<WorkplaceMonitoringSiteVisit> WorkplaceMonitoringSiteVisitManagerAssignedCloUsers { get; set; }
        public virtual ICollection<WorkplaceMonitoringSiteVisit> WorkplaceMonitoringSiteVisitManagerAssignedCrmUsers { get; set; }
        public virtual ICollection<WorkplaceMonitoringSiteVisit> WorkplaceMonitoringSiteVisitNonComplianceApprovalUsers { get; set; }
        public virtual ICollection<WorkplaceMonitoringSiteVisit> WorkplaceMonitoringSiteVisitNonComplianceSubmittedUserNavigations { get; set; }
        public virtual ICollection<WorkplaceMonitoring> WorkplaceMonitorings { get; set; }
        public virtual ICollection<WspCompanyAddressHistory> WspCompanyAddressHistories { get; set; }
        public virtual ICollection<WspCompanyHistory> WspCompanyHistoryDeregisterUsers { get; set; }
        public virtual ICollection<WspCompanyHistory> WspCompanyHistoryFormUsers { get; set; }
        public virtual ICollection<Wsp> WspCreateUsers { get; set; }
        public virtual ICollection<WspDispute> WspDisputes { get; set; }
        public virtual ICollection<Wsp> WspProjectManagerNavigations { get; set; }
        public virtual ICollection<Wsp> WspProjectOwnerNavigations { get; set; }
        public virtual ICollection<WspRejectionInformation> WspRejectionInformations { get; set; }
        public virtual ICollection<WspSdfCompanyHistory> WspSdfCompanyHistories { get; set; }
        public virtual ICollection<WspSignoff> WspSignoffs { get; set; }
        public virtual ICollection<Wsp> WspUserReopenedApplicationNavigations { get; set; }
        public virtual ICollection<Wsp> WspUserRequestedMancoApprovalNavigations { get; set; }
    }
}

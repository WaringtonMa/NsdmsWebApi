using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Revinfo
    {
        public Revinfo()
        {
            ActiveContractDetailHists = new HashSet<ActiveContractDetailHist>();
            ActiveContractExtensionRequestHists = new HashSet<ActiveContractExtensionRequestHist>();
            ActiveContractTerminationRequestHists = new HashSet<ActiveContractTerminationRequestHist>();
            ActiveContractsHists = new HashSet<ActiveContractsHist>();
            AddressChangeAuds = new HashSet<AddressChangeAud>();
            AddressHists = new HashSet<AddressHist>();
            AdministrationOfApqHists = new HashSet<AdministrationOfApqHist>();
            AdministrationOfApqLearnersHists = new HashSet<AdministrationOfApqLearnersHist>();
            AllocationChangeHists = new HashSet<AllocationChangeHist>();
            AllocationChangesReasonsHists = new HashSet<AllocationChangesReasonsHist>();
            AssessorModeratorApplicationHists = new HashSet<AssessorModeratorApplicationHist>();
            AssessorModeratorCompanySitesHists = new HashSet<AssessorModeratorCompanySitesHist>();
            BankingDetailsHists = new HashSet<BankingDetailsHist>();
            ClQualificationAchievementHists = new HashSet<ClQualificationAchievementHist>();
            CompanyHistoryAuds = new HashSet<CompanyHistoryAud>();
            CompanyHists = new HashSet<CompanyHist>();
            CompanyLearnersAchievementStatusEisaHists = new HashSet<CompanyLearnersAchievementStatusEisaHist>();
            CompanyLearnersChangeHists = new HashSet<CompanyLearnersChangeHist>();
            CompanyLearnersDetailsChangeAuds = new HashSet<CompanyLearnersDetailsChangeAud>();
            CompanyLearnersHists = new HashSet<CompanyLearnersHist>();
            CompanyLearnersLostTimeHists = new HashSet<CompanyLearnersLostTimeHist>();
            CompanyLearnersProgressHists = new HashSet<CompanyLearnersProgressHist>();
            CompanyLearnersTradeTestHists = new HashSet<CompanyLearnersTradeTestHist>();
            CompanyLearnersTransferHists = new HashSet<CompanyLearnersTransferHist>();
            CompanyQualificationsHists = new HashSet<CompanyQualificationsHist>();
            CompanyTradeTestEmployerAuds = new HashSet<CompanyTradeTestEmployerAud>();
            CompanyUnitStandardHists = new HashSet<CompanyUnitStandardHist>();
            CompanyUsersHistoryAuds = new HashSet<CompanyUsersHistoryAud>();
            CompanyUsersHists = new HashSet<CompanyUsersHist>();
            DateChangeMultipleSelectionHists = new HashSet<DateChangeMultipleSelectionHist>();
            DesignatedTradeHists = new HashSet<DesignatedTradeHist>();
            DesignatedTradeLevelHists = new HashSet<DesignatedTradeLevelHist>();
            DesignatedTradeLevelItemsHists = new HashSet<DesignatedTradeLevelItemsHist>();
            DgAllocationHists = new HashSet<DgAllocationHist>();
            DgAllocationParentHists = new HashSet<DgAllocationParentHist>();
            DgLegacyPaymentsHists = new HashSet<DgLegacyPaymentsHist>();
            DgProjectTypeHists = new HashSet<DgProjectTypeHist>();
            DgVerificationHistories = new HashSet<DgVerificationHistory>();
            DgYearAuds = new HashSet<DgYearAud>();
            DisabilityRatingAuds = new HashSet<DisabilityRatingAud>();
            EmployeesHists = new HashSet<EmployeesHist>();
            ExceptionsTableHists = new HashSet<ExceptionsTableHist>();
            ExtensionRequestHists = new HashSet<ExtensionRequestHist>();
            FinYearQuartersLookUpHists = new HashSet<FinYearQuartersLookUpHist>();
            FinancialYearsHists = new HashSet<FinancialYearsHist>();
            GpGrantBatchEntryHists = new HashSet<GpGrantBatchEntryHist>();
            GpGrantBatchListHists = new HashSet<GpGrantBatchListHist>();
            HostingCompanyAuds = new HashSet<HostingCompanyAud>();
            InterventionLevelHists = new HashSet<InterventionLevelHist>();
            InterventionTypeHists = new HashSet<InterventionTypeHist>();
            LearnershipHists = new HashSet<LearnershipHist>();
            MandatoryGrantHistories = new HashSet<MandatoryGrantHistory>();
            MandatoryGrantRecommendationHistories = new HashSet<MandatoryGrantRecommendationHistory>();
            MgVerificationDetailsAuds = new HashSet<MgVerificationDetailsAud>();
            NonCreditBearingIntervationTitleHists = new HashSet<NonCreditBearingIntervationTitleHist>();
            NonSetaCompanyHists = new HashSet<NonSetaCompanyHist>();
            NqfLevelsHists = new HashSet<NqfLevelsHist>();
            NsdpQuarterReportingsHists = new HashSet<NsdpQuarterReportingsHist>();
            NsdpReportConfigHists = new HashSet<NsdpReportConfigHist>();
            OccupationCategoryHists = new HashSet<OccupationCategoryHist>();
            OfoCodesHists = new HashSet<OfoCodesHist>();
            PostCodeLinkHists = new HashSet<PostCodeLinkHist>();
            PreviousSchoolsHists = new HashSet<PreviousSchoolsHist>();
            ProjectImplementationPlanLearnersHists = new HashSet<ProjectImplementationPlanLearnersHist>();
            ProviderApplicationTradeTestAssessorsLinkHists = new HashSet<ProviderApplicationTradeTestAssessorsLinkHist>();
            PurposeOfSiteVisitAuds = new HashSet<PurposeOfSiteVisitAud>();
            QmrAetProgrammeDataHists = new HashSet<QmrAetProgrammeDataHist>();
            QmrArtisanDataHists = new HashSet<QmrArtisanDataHist>();
            QmrBursaryDataHists = new HashSet<QmrBursaryDataHist>();
            QmrCandidacyProgrammeDataHists = new HashSet<QmrCandidacyProgrammeDataHist>();
            QmrFinYearsHists = new HashSet<QmrFinYearsHist>();
            QmrIndividualUnitStandardDataHists = new HashSet<QmrIndividualUnitStandardDataHist>();
            QmrInternshipDataHists = new HashSet<QmrInternshipDataHist>();
            QmrLearnershipDataHists = new HashSet<QmrLearnershipDataHist>();
            QmrLecturerDevelopmentDataHists = new HashSet<QmrLecturerDevelopmentDataHist>();
            QmrRplDataHists = new HashSet<QmrRplDataHist>();
            QmrSkillsProgrammeDataHists = new HashSet<QmrSkillsProgrammeDataHist>();
            QmrTvetDataHists = new HashSet<QmrTvetDataHist>();
            QmrUniversityStudentDataHists = new HashSet<QmrUniversityStudentDataHist>();
            QualificationMultipleSelectionHists = new HashSet<QualificationMultipleSelectionHist>();
            RejectReasonMultipleSelectionHistAuds = new HashSet<RejectReasonMultipleSelectionHistAud>();
            RejectReasonMultipleSelectionHists = new HashSet<RejectReasonMultipleSelectionHist>();
            ReportGenerationPropertiesHists = new HashSet<ReportGenerationPropertiesHist>();
            SaqaQualificationAuds = new HashSet<SaqaQualificationAud>();
            SaqaQualificationHists = new HashSet<SaqaQualificationHist>();
            SaqaQualificationTempAuds = new HashSet<SaqaQualificationTempAud>();
            SaqaUnitstandardHists = new HashSet<SaqaUnitstandardHist>();
            SarsLevyDetailCalculationHists = new HashSet<SarsLevyDetailCalculationHist>();
            SarsLevySchemeYearReturnsHists = new HashSet<SarsLevySchemeYearReturnsHist>();
            SdpCompanyActionsHists = new HashSet<SdpCompanyActionsHist>();
            SdpCompanyHists = new HashSet<SdpCompanyHist>();
            SdpExtensionOfScopeHists = new HashSet<SdpExtensionOfScopeHist>();
            SdpReAccreditationHists = new HashSet<SdpReAccreditationHist>();
            SdpTypeHists = new HashSet<SdpTypeHist>();
            SignoffHists = new HashSet<SignoffHist>();
            SitesHists = new HashSet<SitesHist>();
            SitesSmeHists = new HashSet<SitesSmeHist>();
            SkillsGapTrackLookUpHists = new HashSet<SkillsGapTrackLookUpHist>();
            SkillsProgramHists = new HashSet<SkillsProgramHist>();
            SkillsRegistrationAuds = new HashSet<SkillsRegistrationAud>();
            SkillsSetHists = new HashSet<SkillsSetHist>();
            SmeQualificationsHists = new HashSet<SmeQualificationsHist>();
            TradeAppraisalsChecklistAuds = new HashSet<TradeAppraisalsChecklistAud>();
            TrainingProviderApplicationHists = new HashSet<TrainingProviderApplicationHist>();
            TrainingProviderLearnerships = new HashSet<TrainingProviderLearnership>();
            TrainingProviderSkillsProgramHists = new HashSet<TrainingProviderSkillsProgramHist>();
            TrainingProviderSkillsSetHists = new HashSet<TrainingProviderSkillsSetHist>();
            TrainingProviderVerficationHists = new HashSet<TrainingProviderVerficationHist>();
            TrainingProviderVerficationLearnersHists = new HashSet<TrainingProviderVerficationLearnersHist>();
            TrainingReportedAtrPtrHists = new HashSet<TrainingReportedAtrPtrHist>();
            TrainingSiteHists = new HashSet<TrainingSiteHist>();
            TransactionsCompanyValidiationHists = new HashSet<TransactionsCompanyValidiationHist>();
            UserChangeRequestAuds = new HashSet<UserChangeRequestAud>();
            UserLearnershipHists = new HashSet<UserLearnershipHist>();
            UserQualificationsHists = new HashSet<UserQualificationsHist>();
            UserSkillsProgrammeHists = new HashSet<UserSkillsProgrammeHist>();
            UserUnitStandardHists = new HashSet<UserUnitStandardHist>();
            UsersDisabilityAuds = new HashSet<UsersDisabilityAud>();
            UsersDisabilityHists = new HashSet<UsersDisabilityHist>();
            UsersHists = new HashSet<UsersHist>();
            UsersLanguageHists = new HashSet<UsersLanguageHist>();
            WithdrawReasonMultipleSelectionHists = new HashSet<WithdrawReasonMultipleSelectionHist>();
            WorkPlaceApprovalSitesHists = new HashSet<WorkPlaceApprovalSitesHist>();
            WorkPlaceApprovalSkillsSetAuds = new HashSet<WorkPlaceApprovalSkillsSetAud>();
            WorkPlaceApprovalTradesHists = new HashSet<WorkPlaceApprovalTradesHist>();
            WorkPlaceApprovalUnitStandardsAuds = new HashSet<WorkPlaceApprovalUnitStandardsAud>();
            WorkplaceMonitoringActionPlanHists = new HashSet<WorkplaceMonitoringActionPlanHist>();
            WorkplaceMonitoringDgMonitoringHists = new HashSet<WorkplaceMonitoringDgMonitoringHist>();
            WorkplaceMonitoringDiscretionaryGrantComplianceSurveyHists = new HashSet<WorkplaceMonitoringDiscretionaryGrantComplianceSurveyHist>();
            WorkplaceMonitoringLearnerInductionHists = new HashSet<WorkplaceMonitoringLearnerInductionHist>();
            WorkplaceMonitoringLearnerPaymentsHists = new HashSet<WorkplaceMonitoringLearnerPaymentsHist>();
            WorkplaceMonitoringLearnerSurveyAnswersHists = new HashSet<WorkplaceMonitoringLearnerSurveyAnswersHist>();
            WorkplaceMonitoringLearnerSurveyHists = new HashSet<WorkplaceMonitoringLearnerSurveyHist>();
            WorkplaceMonitoringMitigationPlanHists = new HashSet<WorkplaceMonitoringMitigationPlanHist>();
            WorkplaceMonitoringSiteVisitHists = new HashSet<WorkplaceMonitoringSiteVisitHist>();
            WspChecklistAuds = new HashSet<WspChecklistAud>();
            WspHists = new HashSet<WspHist>();
            WspSignoffHists = new HashSet<WspSignoffHist>();
            YesNoLookupHists = new HashSet<YesNoLookupHist>();
        }

        public int Rev { get; set; }
        public long? Revtstmp { get; set; }

        public virtual ICollection<ActiveContractDetailHist> ActiveContractDetailHists { get; set; }
        public virtual ICollection<ActiveContractExtensionRequestHist> ActiveContractExtensionRequestHists { get; set; }
        public virtual ICollection<ActiveContractTerminationRequestHist> ActiveContractTerminationRequestHists { get; set; }
        public virtual ICollection<ActiveContractsHist> ActiveContractsHists { get; set; }
        public virtual ICollection<AddressChangeAud> AddressChangeAuds { get; set; }
        public virtual ICollection<AddressHist> AddressHists { get; set; }
        public virtual ICollection<AdministrationOfApqHist> AdministrationOfApqHists { get; set; }
        public virtual ICollection<AdministrationOfApqLearnersHist> AdministrationOfApqLearnersHists { get; set; }
        public virtual ICollection<AllocationChangeHist> AllocationChangeHists { get; set; }
        public virtual ICollection<AllocationChangesReasonsHist> AllocationChangesReasonsHists { get; set; }
        public virtual ICollection<AssessorModeratorApplicationHist> AssessorModeratorApplicationHists { get; set; }
        public virtual ICollection<AssessorModeratorCompanySitesHist> AssessorModeratorCompanySitesHists { get; set; }
        public virtual ICollection<BankingDetailsHist> BankingDetailsHists { get; set; }
        public virtual ICollection<ClQualificationAchievementHist> ClQualificationAchievementHists { get; set; }
        public virtual ICollection<CompanyHistoryAud> CompanyHistoryAuds { get; set; }
        public virtual ICollection<CompanyHist> CompanyHists { get; set; }
        public virtual ICollection<CompanyLearnersAchievementStatusEisaHist> CompanyLearnersAchievementStatusEisaHists { get; set; }
        public virtual ICollection<CompanyLearnersChangeHist> CompanyLearnersChangeHists { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChangeAud> CompanyLearnersDetailsChangeAuds { get; set; }
        public virtual ICollection<CompanyLearnersHist> CompanyLearnersHists { get; set; }
        public virtual ICollection<CompanyLearnersLostTimeHist> CompanyLearnersLostTimeHists { get; set; }
        public virtual ICollection<CompanyLearnersProgressHist> CompanyLearnersProgressHists { get; set; }
        public virtual ICollection<CompanyLearnersTradeTestHist> CompanyLearnersTradeTestHists { get; set; }
        public virtual ICollection<CompanyLearnersTransferHist> CompanyLearnersTransferHists { get; set; }
        public virtual ICollection<CompanyQualificationsHist> CompanyQualificationsHists { get; set; }
        public virtual ICollection<CompanyTradeTestEmployerAud> CompanyTradeTestEmployerAuds { get; set; }
        public virtual ICollection<CompanyUnitStandardHist> CompanyUnitStandardHists { get; set; }
        public virtual ICollection<CompanyUsersHistoryAud> CompanyUsersHistoryAuds { get; set; }
        public virtual ICollection<CompanyUsersHist> CompanyUsersHists { get; set; }
        public virtual ICollection<DateChangeMultipleSelectionHist> DateChangeMultipleSelectionHists { get; set; }
        public virtual ICollection<DesignatedTradeHist> DesignatedTradeHists { get; set; }
        public virtual ICollection<DesignatedTradeLevelHist> DesignatedTradeLevelHists { get; set; }
        public virtual ICollection<DesignatedTradeLevelItemsHist> DesignatedTradeLevelItemsHists { get; set; }
        public virtual ICollection<DgAllocationHist> DgAllocationHists { get; set; }
        public virtual ICollection<DgAllocationParentHist> DgAllocationParentHists { get; set; }
        public virtual ICollection<DgLegacyPaymentsHist> DgLegacyPaymentsHists { get; set; }
        public virtual ICollection<DgProjectTypeHist> DgProjectTypeHists { get; set; }
        public virtual ICollection<DgVerificationHistory> DgVerificationHistories { get; set; }
        public virtual ICollection<DgYearAud> DgYearAuds { get; set; }
        public virtual ICollection<DisabilityRatingAud> DisabilityRatingAuds { get; set; }
        public virtual ICollection<EmployeesHist> EmployeesHists { get; set; }
        public virtual ICollection<ExceptionsTableHist> ExceptionsTableHists { get; set; }
        public virtual ICollection<ExtensionRequestHist> ExtensionRequestHists { get; set; }
        public virtual ICollection<FinYearQuartersLookUpHist> FinYearQuartersLookUpHists { get; set; }
        public virtual ICollection<FinancialYearsHist> FinancialYearsHists { get; set; }
        public virtual ICollection<GpGrantBatchEntryHist> GpGrantBatchEntryHists { get; set; }
        public virtual ICollection<GpGrantBatchListHist> GpGrantBatchListHists { get; set; }
        public virtual ICollection<HostingCompanyAud> HostingCompanyAuds { get; set; }
        public virtual ICollection<InterventionLevelHist> InterventionLevelHists { get; set; }
        public virtual ICollection<InterventionTypeHist> InterventionTypeHists { get; set; }
        public virtual ICollection<LearnershipHist> LearnershipHists { get; set; }
        public virtual ICollection<MandatoryGrantHistory> MandatoryGrantHistories { get; set; }
        public virtual ICollection<MandatoryGrantRecommendationHistory> MandatoryGrantRecommendationHistories { get; set; }
        public virtual ICollection<MgVerificationDetailsAud> MgVerificationDetailsAuds { get; set; }
        public virtual ICollection<NonCreditBearingIntervationTitleHist> NonCreditBearingIntervationTitleHists { get; set; }
        public virtual ICollection<NonSetaCompanyHist> NonSetaCompanyHists { get; set; }
        public virtual ICollection<NqfLevelsHist> NqfLevelsHists { get; set; }
        public virtual ICollection<NsdpQuarterReportingsHist> NsdpQuarterReportingsHists { get; set; }
        public virtual ICollection<NsdpReportConfigHist> NsdpReportConfigHists { get; set; }
        public virtual ICollection<OccupationCategoryHist> OccupationCategoryHists { get; set; }
        public virtual ICollection<OfoCodesHist> OfoCodesHists { get; set; }
        public virtual ICollection<PostCodeLinkHist> PostCodeLinkHists { get; set; }
        public virtual ICollection<PreviousSchoolsHist> PreviousSchoolsHists { get; set; }
        public virtual ICollection<ProjectImplementationPlanLearnersHist> ProjectImplementationPlanLearnersHists { get; set; }
        public virtual ICollection<ProviderApplicationTradeTestAssessorsLinkHist> ProviderApplicationTradeTestAssessorsLinkHists { get; set; }
        public virtual ICollection<PurposeOfSiteVisitAud> PurposeOfSiteVisitAuds { get; set; }
        public virtual ICollection<QmrAetProgrammeDataHist> QmrAetProgrammeDataHists { get; set; }
        public virtual ICollection<QmrArtisanDataHist> QmrArtisanDataHists { get; set; }
        public virtual ICollection<QmrBursaryDataHist> QmrBursaryDataHists { get; set; }
        public virtual ICollection<QmrCandidacyProgrammeDataHist> QmrCandidacyProgrammeDataHists { get; set; }
        public virtual ICollection<QmrFinYearsHist> QmrFinYearsHists { get; set; }
        public virtual ICollection<QmrIndividualUnitStandardDataHist> QmrIndividualUnitStandardDataHists { get; set; }
        public virtual ICollection<QmrInternshipDataHist> QmrInternshipDataHists { get; set; }
        public virtual ICollection<QmrLearnershipDataHist> QmrLearnershipDataHists { get; set; }
        public virtual ICollection<QmrLecturerDevelopmentDataHist> QmrLecturerDevelopmentDataHists { get; set; }
        public virtual ICollection<QmrRplDataHist> QmrRplDataHists { get; set; }
        public virtual ICollection<QmrSkillsProgrammeDataHist> QmrSkillsProgrammeDataHists { get; set; }
        public virtual ICollection<QmrTvetDataHist> QmrTvetDataHists { get; set; }
        public virtual ICollection<QmrUniversityStudentDataHist> QmrUniversityStudentDataHists { get; set; }
        public virtual ICollection<QualificationMultipleSelectionHist> QualificationMultipleSelectionHists { get; set; }
        public virtual ICollection<RejectReasonMultipleSelectionHistAud> RejectReasonMultipleSelectionHistAuds { get; set; }
        public virtual ICollection<RejectReasonMultipleSelectionHist> RejectReasonMultipleSelectionHists { get; set; }
        public virtual ICollection<ReportGenerationPropertiesHist> ReportGenerationPropertiesHists { get; set; }
        public virtual ICollection<SaqaQualificationAud> SaqaQualificationAuds { get; set; }
        public virtual ICollection<SaqaQualificationHist> SaqaQualificationHists { get; set; }
        public virtual ICollection<SaqaQualificationTempAud> SaqaQualificationTempAuds { get; set; }
        public virtual ICollection<SaqaUnitstandardHist> SaqaUnitstandardHists { get; set; }
        public virtual ICollection<SarsLevyDetailCalculationHist> SarsLevyDetailCalculationHists { get; set; }
        public virtual ICollection<SarsLevySchemeYearReturnsHist> SarsLevySchemeYearReturnsHists { get; set; }
        public virtual ICollection<SdpCompanyActionsHist> SdpCompanyActionsHists { get; set; }
        public virtual ICollection<SdpCompanyHist> SdpCompanyHists { get; set; }
        public virtual ICollection<SdpExtensionOfScopeHist> SdpExtensionOfScopeHists { get; set; }
        public virtual ICollection<SdpReAccreditationHist> SdpReAccreditationHists { get; set; }
        public virtual ICollection<SdpTypeHist> SdpTypeHists { get; set; }
        public virtual ICollection<SignoffHist> SignoffHists { get; set; }
        public virtual ICollection<SitesHist> SitesHists { get; set; }
        public virtual ICollection<SitesSmeHist> SitesSmeHists { get; set; }
        public virtual ICollection<SkillsGapTrackLookUpHist> SkillsGapTrackLookUpHists { get; set; }
        public virtual ICollection<SkillsProgramHist> SkillsProgramHists { get; set; }
        public virtual ICollection<SkillsRegistrationAud> SkillsRegistrationAuds { get; set; }
        public virtual ICollection<SkillsSetHist> SkillsSetHists { get; set; }
        public virtual ICollection<SmeQualificationsHist> SmeQualificationsHists { get; set; }
        public virtual ICollection<TradeAppraisalsChecklistAud> TradeAppraisalsChecklistAuds { get; set; }
        public virtual ICollection<TrainingProviderApplicationHist> TrainingProviderApplicationHists { get; set; }
        public virtual ICollection<TrainingProviderLearnership> TrainingProviderLearnerships { get; set; }
        public virtual ICollection<TrainingProviderSkillsProgramHist> TrainingProviderSkillsProgramHists { get; set; }
        public virtual ICollection<TrainingProviderSkillsSetHist> TrainingProviderSkillsSetHists { get; set; }
        public virtual ICollection<TrainingProviderVerficationHist> TrainingProviderVerficationHists { get; set; }
        public virtual ICollection<TrainingProviderVerficationLearnersHist> TrainingProviderVerficationLearnersHists { get; set; }
        public virtual ICollection<TrainingReportedAtrPtrHist> TrainingReportedAtrPtrHists { get; set; }
        public virtual ICollection<TrainingSiteHist> TrainingSiteHists { get; set; }
        public virtual ICollection<TransactionsCompanyValidiationHist> TransactionsCompanyValidiationHists { get; set; }
        public virtual ICollection<UserChangeRequestAud> UserChangeRequestAuds { get; set; }
        public virtual ICollection<UserLearnershipHist> UserLearnershipHists { get; set; }
        public virtual ICollection<UserQualificationsHist> UserQualificationsHists { get; set; }
        public virtual ICollection<UserSkillsProgrammeHist> UserSkillsProgrammeHists { get; set; }
        public virtual ICollection<UserUnitStandardHist> UserUnitStandardHists { get; set; }
        public virtual ICollection<UsersDisabilityAud> UsersDisabilityAuds { get; set; }
        public virtual ICollection<UsersDisabilityHist> UsersDisabilityHists { get; set; }
        public virtual ICollection<UsersHist> UsersHists { get; set; }
        public virtual ICollection<UsersLanguageHist> UsersLanguageHists { get; set; }
        public virtual ICollection<WithdrawReasonMultipleSelectionHist> WithdrawReasonMultipleSelectionHists { get; set; }
        public virtual ICollection<WorkPlaceApprovalSitesHist> WorkPlaceApprovalSitesHists { get; set; }
        public virtual ICollection<WorkPlaceApprovalSkillsSetAud> WorkPlaceApprovalSkillsSetAuds { get; set; }
        public virtual ICollection<WorkPlaceApprovalTradesHist> WorkPlaceApprovalTradesHists { get; set; }
        public virtual ICollection<WorkPlaceApprovalUnitStandardsAud> WorkPlaceApprovalUnitStandardsAuds { get; set; }
        public virtual ICollection<WorkplaceMonitoringActionPlanHist> WorkplaceMonitoringActionPlanHists { get; set; }
        public virtual ICollection<WorkplaceMonitoringDgMonitoringHist> WorkplaceMonitoringDgMonitoringHists { get; set; }
        public virtual ICollection<WorkplaceMonitoringDiscretionaryGrantComplianceSurveyHist> WorkplaceMonitoringDiscretionaryGrantComplianceSurveyHists { get; set; }
        public virtual ICollection<WorkplaceMonitoringLearnerInductionHist> WorkplaceMonitoringLearnerInductionHists { get; set; }
        public virtual ICollection<WorkplaceMonitoringLearnerPaymentsHist> WorkplaceMonitoringLearnerPaymentsHists { get; set; }
        public virtual ICollection<WorkplaceMonitoringLearnerSurveyAnswersHist> WorkplaceMonitoringLearnerSurveyAnswersHists { get; set; }
        public virtual ICollection<WorkplaceMonitoringLearnerSurveyHist> WorkplaceMonitoringLearnerSurveyHists { get; set; }
        public virtual ICollection<WorkplaceMonitoringMitigationPlanHist> WorkplaceMonitoringMitigationPlanHists { get; set; }
        public virtual ICollection<WorkplaceMonitoringSiteVisitHist> WorkplaceMonitoringSiteVisitHists { get; set; }
        public virtual ICollection<WspChecklistAud> WspChecklistAuds { get; set; }
        public virtual ICollection<WspHist> WspHists { get; set; }
        public virtual ICollection<WspSignoffHist> WspSignoffHists { get; set; }
        public virtual ICollection<YesNoLookupHist> YesNoLookupHists { get; set; }
    }
}

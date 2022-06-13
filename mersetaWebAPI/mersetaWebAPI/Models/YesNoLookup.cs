using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class YesNoLookup
    {
        public YesNoLookup()
        {
            Companies = new HashSet<Company>();
            CompanyHistories = new HashSet<CompanyHistory>();
            CompanyLearners = new HashSet<CompanyLearner>();
            CompanyLearnersDetailsChanges = new HashSet<CompanyLearnersDetailsChange>();
            DgVerificationAccessCoverNavigations = new HashSet<DgVerification>();
            DgVerificationAccessMaterialConsumableNavigations = new HashSet<DgVerification>();
            DgVerificationAsPerSkillsAreaNavigations = new HashSet<DgVerification>();
            DgVerificationEffectiveRecordNavigations = new HashSet<DgVerification>();
            DgVerificationExtensionOfScopeNavigations = new HashSet<DgVerification>();
            DgVerificationHealthSafetyOfficerNavigations = new HashSet<DgVerification>();
            DgVerificationNewApplicationNavigations = new HashSet<DgVerification>();
            DgVerificationPretectiveWearNavigations = new HashSet<DgVerification>();
            DgVerificationPreviouslyApprovedNavigations = new HashSet<DgVerification>();
            DgVerificationRelevantCoreWorkNavigations = new HashSet<DgVerification>();
            DgVerificationRelevantLearnerRatioNavigations = new HashSet<DgVerification>();
            DgVerificationSuitableQualifiedMentorNavigations = new HashSet<DgVerification>();
            DgVerificationWorkplaceLayoutNavigations = new HashSet<DgVerification>();
            Learners = new HashSet<Learner>();
            LearnershipDevelopmentRegistrations = new HashSet<LearnershipDevelopmentRegistration>();
            MandatoryGrantDetailArchives = new HashSet<MandatoryGrantDetailArchive>();
            MandatoryGrantDetails = new HashSet<MandatoryGrantDetail>();
            MandatoryGrants = new HashSet<MandatoryGrant>();
            MgVerificationAtrSubmittedNavigations = new HashSet<MgVerification>();
            MgVerificationCompleteInYearNavigations = new HashSet<MgVerification>();
            MgVerificationDetails = new HashSet<MgVerificationDetail>();
            MgVerificationEmployerAttendMeetingsNavigations = new HashSet<MgVerification>();
            MgVerificationLabourAttendMeetingsNavigations = new HashSet<MgVerification>();
            MgVerificationMgSignedOffNavigations = new HashSet<MgVerification>();
            MgVerificationOrganisedLabourUnionNavigations = new HashSet<MgVerification>();
            MgVerificationProofTrainingVerifiedNavigations = new HashSet<MgVerification>();
            MgVerificationTrainingComitteeMinutesNavigations = new HashSet<MgVerification>();
            MgVerificationTrainingCommencedNavigations = new HashSet<MgVerification>();
            MgVerificationTrainingCompletedAsPreviousNavigations = new HashSet<MgVerification>();
            MgVerificationWspSubmittedNavigations = new HashSet<MgVerification>();
            SdfTypes = new HashSet<SdfType>();
            SiteVisitReportNewEquipmentYesNoFiveNavigations = new HashSet<SiteVisitReportNew>();
            SiteVisitReportNewEquipmentYesNoFourNavigations = new HashSet<SiteVisitReportNew>();
            SiteVisitReportNewEquipmentYesNoOneNavigations = new HashSet<SiteVisitReportNew>();
            SiteVisitReportNewEquipmentYesNoThreeNavigations = new HashSet<SiteVisitReportNew>();
            SiteVisitReportNewEquipmentYesNoTwoNavigations = new HashSet<SiteVisitReportNew>();
            SiteVisitReportNewRecordYesNoOneNavigations = new HashSet<SiteVisitReportNew>();
            SiteVisitReportNewRecordYesNoTwoNavigations = new HashSet<SiteVisitReportNew>();
            SiteVisitReportNewSafetyYesNoOneNavigations = new HashSet<SiteVisitReportNew>();
            SiteVisitReportNewSafetyYesNoThreeNavigations = new HashSet<SiteVisitReportNew>();
            SiteVisitReportNewSafetyYesNoTwoNavigations = new HashSet<SiteVisitReportNew>();
            SummativeAssessmentReports = new HashSet<SummativeAssessmentReport>();
            TradeAppraisalsChecklists = new HashSet<TradeAppraisalsChecklist>();
            Users = new HashSet<User>();
            UsersLanguageReads = new HashSet<UsersLanguage>();
            UsersLanguageSpearks = new HashSet<UsersLanguage>();
            UsersLanguageWrites = new HashSet<UsersLanguage>();
            WorkPlaceApprovalAbilityToCoverEntireScopeNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalAccessCoverNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalAccessMaterialConsumableNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalAccessToMaterialNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalAccessToMaterialSdfNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalAllToolsAvailableNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalAllToolsAvailableSdfNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalAsPerSkillsAreaNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalCommittedOhsaOrMhsaCompliantNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalCommittedOhsaOrMhsaCompliantSdfNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalCommittedtoBecompliantRelevantLegislationApplicableNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalCommittedtoBecompliantRelevantLegislationApplicableSdfNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalCopyOfSelfEvaluationNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalDeclarationFromEmployerNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalDeclarationIndicationCommitmentNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalEffectiveRecordNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalEvidenceAttachedOfPreviosNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalExtensionOfScopeNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalFormalAgreementAprrovedWorkpalcesNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalFormalAgreementWithOtherNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalFormalAgreementWithOtherSdfNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalHealthSafetyOfficerNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalIdentifiedCommittedStaffNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalIdentifiedCommittedStaffSdfNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalLayoutEnvironmentSafeNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalLayoutEnvironmentSafeSdfNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalLetterOfCommitmentNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalMentorArtisanRationAcceptableNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalMentorArtisanRationAcceptableSdfNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalNewApplicationNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalOhsaMhsaCompliantNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalPretectiveWearNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalPretectiveWearSdfNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalPreviouslyApprovedNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalQualifiedMentorsForTradeNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalQualifiedMentorsForTradeSdfNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalRecordKeepingSystemNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalRecordKeepingSystemSdfNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalRelevantCoreWorkNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalRelevantLearnerRatioNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalStructuredImplementationPlanNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalStructuredImplementationPlanSdfNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalSuitableQualifiedMentorNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalSuitableQualifiedMentorsNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalTaxClearanceCertificateNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalWorkplaceAbleToCoverScopeNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalWorkplaceCoverTradeOrQualificationNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalWorkplaceCoverTradeOrQualificationSdfNavigations = new HashSet<WorkPlaceApproval>();
            WorkPlaceApprovalWorkplaceLayoutNavigations = new HashSet<WorkPlaceApproval>();
            WorkplaceMonitoringDiscretionaryGrantComplianceSurveys = new HashSet<WorkplaceMonitoringDiscretionaryGrantComplianceSurvey>();
            WspChecklistAtrImplementedPercentNavigations = new HashSet<WspChecklist>();
            WspChecklistAtrSubmittedNavigations = new HashSet<WspChecklist>();
            WspChecklistBankingDetailsCheckedNavigations = new HashSet<WspChecklist>();
            WspChecklistDeviationMotivationNavigations = new HashSet<WspChecklist>();
            WspChecklistEmployerRepresentativePartTrainingCommitteeNavigations = new HashSet<WspChecklist>();
            WspChecklistExtensionGrantedNavigations = new HashSet<WspChecklist>();
            WspChecklistMinutesUplaodedNavigations = new HashSet<WspChecklist>();
            WspChecklistNonNqfMotivationNavigations = new HashSet<WspChecklist>();
            WspChecklistNonNqfTrainingMotivationApprovedNavigations = new HashSet<WspChecklist>();
            WspChecklistOtherSdfSignedNavigations = new HashSet<WspChecklist>();
            WspChecklistPivitolPlanSubmittedNavigations = new HashSet<WspChecklist>();
            WspChecklistSignOffCompleteNavigations = new HashSet<WspChecklist>();
            WspChecklistSignedRecognitionAgreementNavigations = new HashSet<WspChecklist>();
            WspChecklistTradePartOfTrainingCommitteeNavigations = new HashSet<WspChecklist>();
            WspChecklistTrainingCommitteeMinutesApprovedNavigations = new HashSet<WspChecklist>();
            WspChecklistTrainingDeviationMotivationApprovedNavigations = new HashSet<WspChecklist>();
            WspChecklistWorkplaceSkillsPlanSubmittedNavigations = new HashSet<WspChecklist>();
            WspChecklistWspY18SubmittedNavigations = new HashSet<WspChecklist>();
            WspCoFundingPartnershipNavigations = new HashSet<Wsp>();
            WspCompanyHistories = new HashSet<WspCompanyHistory>();
            WspCompletedTrainingNavigations = new HashSet<Wsp>();
            WspDeviatedWorkplaceSkillsPlanNavigations = new HashSet<Wsp>();
            WspEmploymentEquityPlanInlineNavigations = new HashSet<Wsp>();
            WspMajorityUnions = new HashSet<Wsp>();
            WspRecognitionAgreements = new HashSet<Wsp>();
            WspSkillsRequirements = new HashSet<WspSkillsRequirement>();
            WspTrackSkillsGapNavigations = new HashSet<Wsp>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? YesNoName { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<CompanyHistory> CompanyHistories { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearners { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChanges { get; set; }
        public virtual ICollection<DgVerification> DgVerificationAccessCoverNavigations { get; set; }
        public virtual ICollection<DgVerification> DgVerificationAccessMaterialConsumableNavigations { get; set; }
        public virtual ICollection<DgVerification> DgVerificationAsPerSkillsAreaNavigations { get; set; }
        public virtual ICollection<DgVerification> DgVerificationEffectiveRecordNavigations { get; set; }
        public virtual ICollection<DgVerification> DgVerificationExtensionOfScopeNavigations { get; set; }
        public virtual ICollection<DgVerification> DgVerificationHealthSafetyOfficerNavigations { get; set; }
        public virtual ICollection<DgVerification> DgVerificationNewApplicationNavigations { get; set; }
        public virtual ICollection<DgVerification> DgVerificationPretectiveWearNavigations { get; set; }
        public virtual ICollection<DgVerification> DgVerificationPreviouslyApprovedNavigations { get; set; }
        public virtual ICollection<DgVerification> DgVerificationRelevantCoreWorkNavigations { get; set; }
        public virtual ICollection<DgVerification> DgVerificationRelevantLearnerRatioNavigations { get; set; }
        public virtual ICollection<DgVerification> DgVerificationSuitableQualifiedMentorNavigations { get; set; }
        public virtual ICollection<DgVerification> DgVerificationWorkplaceLayoutNavigations { get; set; }
        public virtual ICollection<Learner> Learners { get; set; }
        public virtual ICollection<LearnershipDevelopmentRegistration> LearnershipDevelopmentRegistrations { get; set; }
        public virtual ICollection<MandatoryGrantDetailArchive> MandatoryGrantDetailArchives { get; set; }
        public virtual ICollection<MandatoryGrantDetail> MandatoryGrantDetails { get; set; }
        public virtual ICollection<MandatoryGrant> MandatoryGrants { get; set; }
        public virtual ICollection<MgVerification> MgVerificationAtrSubmittedNavigations { get; set; }
        public virtual ICollection<MgVerification> MgVerificationCompleteInYearNavigations { get; set; }
        public virtual ICollection<MgVerificationDetail> MgVerificationDetails { get; set; }
        public virtual ICollection<MgVerification> MgVerificationEmployerAttendMeetingsNavigations { get; set; }
        public virtual ICollection<MgVerification> MgVerificationLabourAttendMeetingsNavigations { get; set; }
        public virtual ICollection<MgVerification> MgVerificationMgSignedOffNavigations { get; set; }
        public virtual ICollection<MgVerification> MgVerificationOrganisedLabourUnionNavigations { get; set; }
        public virtual ICollection<MgVerification> MgVerificationProofTrainingVerifiedNavigations { get; set; }
        public virtual ICollection<MgVerification> MgVerificationTrainingComitteeMinutesNavigations { get; set; }
        public virtual ICollection<MgVerification> MgVerificationTrainingCommencedNavigations { get; set; }
        public virtual ICollection<MgVerification> MgVerificationTrainingCompletedAsPreviousNavigations { get; set; }
        public virtual ICollection<MgVerification> MgVerificationWspSubmittedNavigations { get; set; }
        public virtual ICollection<SdfType> SdfTypes { get; set; }
        public virtual ICollection<SiteVisitReportNew> SiteVisitReportNewEquipmentYesNoFiveNavigations { get; set; }
        public virtual ICollection<SiteVisitReportNew> SiteVisitReportNewEquipmentYesNoFourNavigations { get; set; }
        public virtual ICollection<SiteVisitReportNew> SiteVisitReportNewEquipmentYesNoOneNavigations { get; set; }
        public virtual ICollection<SiteVisitReportNew> SiteVisitReportNewEquipmentYesNoThreeNavigations { get; set; }
        public virtual ICollection<SiteVisitReportNew> SiteVisitReportNewEquipmentYesNoTwoNavigations { get; set; }
        public virtual ICollection<SiteVisitReportNew> SiteVisitReportNewRecordYesNoOneNavigations { get; set; }
        public virtual ICollection<SiteVisitReportNew> SiteVisitReportNewRecordYesNoTwoNavigations { get; set; }
        public virtual ICollection<SiteVisitReportNew> SiteVisitReportNewSafetyYesNoOneNavigations { get; set; }
        public virtual ICollection<SiteVisitReportNew> SiteVisitReportNewSafetyYesNoThreeNavigations { get; set; }
        public virtual ICollection<SiteVisitReportNew> SiteVisitReportNewSafetyYesNoTwoNavigations { get; set; }
        public virtual ICollection<SummativeAssessmentReport> SummativeAssessmentReports { get; set; }
        public virtual ICollection<TradeAppraisalsChecklist> TradeAppraisalsChecklists { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<UsersLanguage> UsersLanguageReads { get; set; }
        public virtual ICollection<UsersLanguage> UsersLanguageSpearks { get; set; }
        public virtual ICollection<UsersLanguage> UsersLanguageWrites { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalAbilityToCoverEntireScopeNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalAccessCoverNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalAccessMaterialConsumableNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalAccessToMaterialNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalAccessToMaterialSdfNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalAllToolsAvailableNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalAllToolsAvailableSdfNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalAsPerSkillsAreaNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalCommittedOhsaOrMhsaCompliantNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalCommittedOhsaOrMhsaCompliantSdfNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalCommittedtoBecompliantRelevantLegislationApplicableNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalCommittedtoBecompliantRelevantLegislationApplicableSdfNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalCopyOfSelfEvaluationNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalDeclarationFromEmployerNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalDeclarationIndicationCommitmentNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalEffectiveRecordNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalEvidenceAttachedOfPreviosNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalExtensionOfScopeNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalFormalAgreementAprrovedWorkpalcesNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalFormalAgreementWithOtherNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalFormalAgreementWithOtherSdfNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalHealthSafetyOfficerNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalIdentifiedCommittedStaffNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalIdentifiedCommittedStaffSdfNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalLayoutEnvironmentSafeNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalLayoutEnvironmentSafeSdfNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalLetterOfCommitmentNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalMentorArtisanRationAcceptableNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalMentorArtisanRationAcceptableSdfNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalNewApplicationNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalOhsaMhsaCompliantNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalPretectiveWearNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalPretectiveWearSdfNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalPreviouslyApprovedNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalQualifiedMentorsForTradeNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalQualifiedMentorsForTradeSdfNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalRecordKeepingSystemNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalRecordKeepingSystemSdfNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalRelevantCoreWorkNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalRelevantLearnerRatioNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalStructuredImplementationPlanNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalStructuredImplementationPlanSdfNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalSuitableQualifiedMentorNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalSuitableQualifiedMentorsNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalTaxClearanceCertificateNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalWorkplaceAbleToCoverScopeNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalWorkplaceCoverTradeOrQualificationNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalWorkplaceCoverTradeOrQualificationSdfNavigations { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovalWorkplaceLayoutNavigations { get; set; }
        public virtual ICollection<WorkplaceMonitoringDiscretionaryGrantComplianceSurvey> WorkplaceMonitoringDiscretionaryGrantComplianceSurveys { get; set; }
        public virtual ICollection<WspChecklist> WspChecklistAtrImplementedPercentNavigations { get; set; }
        public virtual ICollection<WspChecklist> WspChecklistAtrSubmittedNavigations { get; set; }
        public virtual ICollection<WspChecklist> WspChecklistBankingDetailsCheckedNavigations { get; set; }
        public virtual ICollection<WspChecklist> WspChecklistDeviationMotivationNavigations { get; set; }
        public virtual ICollection<WspChecklist> WspChecklistEmployerRepresentativePartTrainingCommitteeNavigations { get; set; }
        public virtual ICollection<WspChecklist> WspChecklistExtensionGrantedNavigations { get; set; }
        public virtual ICollection<WspChecklist> WspChecklistMinutesUplaodedNavigations { get; set; }
        public virtual ICollection<WspChecklist> WspChecklistNonNqfMotivationNavigations { get; set; }
        public virtual ICollection<WspChecklist> WspChecklistNonNqfTrainingMotivationApprovedNavigations { get; set; }
        public virtual ICollection<WspChecklist> WspChecklistOtherSdfSignedNavigations { get; set; }
        public virtual ICollection<WspChecklist> WspChecklistPivitolPlanSubmittedNavigations { get; set; }
        public virtual ICollection<WspChecklist> WspChecklistSignOffCompleteNavigations { get; set; }
        public virtual ICollection<WspChecklist> WspChecklistSignedRecognitionAgreementNavigations { get; set; }
        public virtual ICollection<WspChecklist> WspChecklistTradePartOfTrainingCommitteeNavigations { get; set; }
        public virtual ICollection<WspChecklist> WspChecklistTrainingCommitteeMinutesApprovedNavigations { get; set; }
        public virtual ICollection<WspChecklist> WspChecklistTrainingDeviationMotivationApprovedNavigations { get; set; }
        public virtual ICollection<WspChecklist> WspChecklistWorkplaceSkillsPlanSubmittedNavigations { get; set; }
        public virtual ICollection<WspChecklist> WspChecklistWspY18SubmittedNavigations { get; set; }
        public virtual ICollection<Wsp> WspCoFundingPartnershipNavigations { get; set; }
        public virtual ICollection<WspCompanyHistory> WspCompanyHistories { get; set; }
        public virtual ICollection<Wsp> WspCompletedTrainingNavigations { get; set; }
        public virtual ICollection<Wsp> WspDeviatedWorkplaceSkillsPlanNavigations { get; set; }
        public virtual ICollection<Wsp> WspEmploymentEquityPlanInlineNavigations { get; set; }
        public virtual ICollection<Wsp> WspMajorityUnions { get; set; }
        public virtual ICollection<Wsp> WspRecognitionAgreements { get; set; }
        public virtual ICollection<WspSkillsRequirement> WspSkillsRequirements { get; set; }
        public virtual ICollection<Wsp> WspTrackSkillsGapNavigations { get; set; }
    }
}

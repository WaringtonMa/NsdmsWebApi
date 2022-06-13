using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkPlaceApproval
    {
        public WorkPlaceApproval()
        {
            TradeAppraisalsChecklists = new HashSet<TradeAppraisalsChecklist>();
            WorkPlaceApprovalMentors = new HashSet<WorkPlaceApprovalMentor>();
            WorkPlaceApprovalSites = new HashSet<WorkPlaceApprovalSite>();
            WorkPlaceApprovalSkillsPrograms = new HashSet<WorkPlaceApprovalSkillsProgram>();
            WorkPlaceApprovalSkillsSets = new HashSet<WorkPlaceApprovalSkillsSet>();
            WorkPlaceApprovalToolLists = new HashSet<WorkPlaceApprovalToolList>();
            WorkPlaceApprovalTrades = new HashSet<WorkPlaceApprovalTrade>();
            WorkPlaceApprovalUnitStandards = new HashSet<WorkPlaceApprovalUnitStandard>();
            WorkPlaceApprovalVisitDateLogs = new HashSet<WorkPlaceApprovalVisitDateLog>();
        }

        public long Id { get; set; }
        public ulong? AmendmentsRequired { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public string? ApprovalEnum { get; set; }
        public int? CloRecommendation { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DateCaptured { get; set; }
        public ulong? DateForVisitProvided { get; set; }
        public DateTime? EndDate { get; set; }
        public string? EnsureExplanation { get; set; }
        public DateTime? ReviewDate { get; set; }
        public ulong? WithClientCompany { get; set; }
        public string? WpaNumber { get; set; }
        public ulong? WpaAppealed { get; set; }
        public long? AbilityToCoverEntireScope { get; set; }
        public long? AccessCover { get; set; }
        public long? AccessMaterialConsumable { get; set; }
        public long? AccessToMaterial { get; set; }
        public long? AccessToMaterialSdf { get; set; }
        public long? AllToolsAvailable { get; set; }
        public long? AllToolsAvailableSdf { get; set; }
        public long? ApprovedBySeta { get; set; }
        public long? AsPerSkillsArea { get; set; }
        public long? CommittedOhsaOrMhsaCompliant { get; set; }
        public long? CommittedOhsaOrMhsaCompliantSdf { get; set; }
        public long? CommittedtoBecompliantRelevantLegislationApplicable { get; set; }
        public long? CommittedtoBecompliantRelevantLegislationApplicableSdf { get; set; }
        public long? CompanyId { get; set; }
        public long? CopyOfSelfEvaluation { get; set; }
        public long? DeclarationFromEmployer { get; set; }
        public long? DeclarationIndicationCommitment { get; set; }
        public long? EffectiveRecord { get; set; }
        public long? EvidenceAttachedOfPrevios { get; set; }
        public long? ExtensionOfScope { get; set; }
        public long? FormalAgreementAprrovedWorkpalces { get; set; }
        public long? FormalAgreementWithOther { get; set; }
        public long? FormalAgreementWithOtherSdf { get; set; }
        public long? HealthSafetyOfficer { get; set; }
        public long? IdentifiedCommittedStaff { get; set; }
        public long? IdentifiedCommittedStaffSdf { get; set; }
        public long? LayoutEnvironmentSafe { get; set; }
        public long? LayoutEnvironmentSafeSdf { get; set; }
        public long? LetterOfCommitment { get; set; }
        public long? MandatoryGrantId { get; set; }
        public long? MentorArtisanRationAcceptable { get; set; }
        public long? MentorArtisanRationAcceptableSdf { get; set; }
        public long? NewApplication { get; set; }
        public long? OfoCodesId { get; set; }
        public long? OhsaMhsaCompliant { get; set; }
        public long? PretectiveWear { get; set; }
        public long? PretectiveWearSdf { get; set; }
        public long? PreviouslyApproved { get; set; }
        public long? QualificationId { get; set; }
        public long? QualifiedMentorsForTrade { get; set; }
        public long? QualifiedMentorsForTradeSdf { get; set; }
        public long? RecordKeepingSystem { get; set; }
        public long? RecordKeepingSystemSdf { get; set; }
        public long? RelevantCoreWork { get; set; }
        public long? RelevantLearnerRatio { get; set; }
        public long? ReviewUserId { get; set; }
        public long? SitesId { get; set; }
        public long? StructuredImplementationPlan { get; set; }
        public long? StructuredImplementationPlanSdf { get; set; }
        public long? SuitableQualifiedMentor { get; set; }
        public long? SuitableQualifiedMentors { get; set; }
        public long? TaxClearanceCertificate { get; set; }
        public long? WorkplaceAbleToCoverScope { get; set; }
        public long? WorkplaceCoverTradeOrQualification { get; set; }
        public long? WorkplaceCoverTradeOrQualificationSdf { get; set; }
        public long? WorkplaceLayout { get; set; }
        public DateTime? ApprovalReviewDate { get; set; }
        public ulong? WithManager { get; set; }
        public string? RejectMessage { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public int? WorkplaceApprovalTypeEnum { get; set; }
        public long? LearnershipId { get; set; }
        public long? LegacyEmployerWa2WorkplaceId { get; set; }
        public long? SkillsProgramId { get; set; }
        public long? SkillsSetId { get; set; }
        public long? UnitstandardId { get; set; }
        public string? OrigionalApprovalEnum { get; set; }

        public virtual YesNoLookup? AbilityToCoverEntireScopeNavigation { get; set; }
        public virtual YesNoLookup? AccessCoverNavigation { get; set; }
        public virtual YesNoLookup? AccessMaterialConsumableNavigation { get; set; }
        public virtual YesNoLookup? AccessToMaterialNavigation { get; set; }
        public virtual YesNoLookup? AccessToMaterialSdfNavigation { get; set; }
        public virtual YesNoLookup? AllToolsAvailableNavigation { get; set; }
        public virtual YesNoLookup? AllToolsAvailableSdfNavigation { get; set; }
        public virtual Etqa? ApprovedBySetaNavigation { get; set; }
        public virtual YesNoLookup? AsPerSkillsAreaNavigation { get; set; }
        public virtual YesNoLookup? CommittedOhsaOrMhsaCompliantNavigation { get; set; }
        public virtual YesNoLookup? CommittedOhsaOrMhsaCompliantSdfNavigation { get; set; }
        public virtual YesNoLookup? CommittedtoBecompliantRelevantLegislationApplicableNavigation { get; set; }
        public virtual YesNoLookup? CommittedtoBecompliantRelevantLegislationApplicableSdfNavigation { get; set; }
        public virtual Company? Company { get; set; }
        public virtual YesNoLookup? CopyOfSelfEvaluationNavigation { get; set; }
        public virtual YesNoLookup? DeclarationFromEmployerNavigation { get; set; }
        public virtual YesNoLookup? DeclarationIndicationCommitmentNavigation { get; set; }
        public virtual YesNoLookup? EffectiveRecordNavigation { get; set; }
        public virtual YesNoLookup? EvidenceAttachedOfPreviosNavigation { get; set; }
        public virtual YesNoLookup? ExtensionOfScopeNavigation { get; set; }
        public virtual YesNoLookup? FormalAgreementAprrovedWorkpalcesNavigation { get; set; }
        public virtual YesNoLookup? FormalAgreementWithOtherNavigation { get; set; }
        public virtual YesNoLookup? FormalAgreementWithOtherSdfNavigation { get; set; }
        public virtual YesNoLookup? HealthSafetyOfficerNavigation { get; set; }
        public virtual YesNoLookup? IdentifiedCommittedStaffNavigation { get; set; }
        public virtual YesNoLookup? IdentifiedCommittedStaffSdfNavigation { get; set; }
        public virtual YesNoLookup? LayoutEnvironmentSafeNavigation { get; set; }
        public virtual YesNoLookup? LayoutEnvironmentSafeSdfNavigation { get; set; }
        public virtual Learnership? Learnership { get; set; }
        public virtual LegacyEmployerWa2Workplace? LegacyEmployerWa2Workplace { get; set; }
        public virtual YesNoLookup? LetterOfCommitmentNavigation { get; set; }
        public virtual MandatoryGrant? MandatoryGrant { get; set; }
        public virtual YesNoLookup? MentorArtisanRationAcceptableNavigation { get; set; }
        public virtual YesNoLookup? MentorArtisanRationAcceptableSdfNavigation { get; set; }
        public virtual YesNoLookup? NewApplicationNavigation { get; set; }
        public virtual OfoCode? OfoCodes { get; set; }
        public virtual YesNoLookup? OhsaMhsaCompliantNavigation { get; set; }
        public virtual YesNoLookup? PretectiveWearNavigation { get; set; }
        public virtual YesNoLookup? PretectiveWearSdfNavigation { get; set; }
        public virtual YesNoLookup? PreviouslyApprovedNavigation { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual YesNoLookup? QualifiedMentorsForTradeNavigation { get; set; }
        public virtual YesNoLookup? QualifiedMentorsForTradeSdfNavigation { get; set; }
        public virtual YesNoLookup? RecordKeepingSystemNavigation { get; set; }
        public virtual YesNoLookup? RecordKeepingSystemSdfNavigation { get; set; }
        public virtual YesNoLookup? RelevantCoreWorkNavigation { get; set; }
        public virtual YesNoLookup? RelevantLearnerRatioNavigation { get; set; }
        public virtual User? ReviewUser { get; set; }
        public virtual Site? Sites { get; set; }
        public virtual SkillsProgram? SkillsProgram { get; set; }
        public virtual SkillsSet? SkillsSet { get; set; }
        public virtual YesNoLookup? StructuredImplementationPlanNavigation { get; set; }
        public virtual YesNoLookup? StructuredImplementationPlanSdfNavigation { get; set; }
        public virtual YesNoLookup? SuitableQualifiedMentorNavigation { get; set; }
        public virtual YesNoLookup? SuitableQualifiedMentorsNavigation { get; set; }
        public virtual YesNoLookup? TaxClearanceCertificateNavigation { get; set; }
        public virtual SaqaUnitstandard? Unitstandard { get; set; }
        public virtual YesNoLookup? WorkplaceAbleToCoverScopeNavigation { get; set; }
        public virtual YesNoLookup? WorkplaceCoverTradeOrQualificationNavigation { get; set; }
        public virtual YesNoLookup? WorkplaceCoverTradeOrQualificationSdfNavigation { get; set; }
        public virtual YesNoLookup? WorkplaceLayoutNavigation { get; set; }
        public virtual ICollection<TradeAppraisalsChecklist> TradeAppraisalsChecklists { get; set; }
        public virtual ICollection<WorkPlaceApprovalMentor> WorkPlaceApprovalMentors { get; set; }
        public virtual ICollection<WorkPlaceApprovalSite> WorkPlaceApprovalSites { get; set; }
        public virtual ICollection<WorkPlaceApprovalSkillsProgram> WorkPlaceApprovalSkillsPrograms { get; set; }
        public virtual ICollection<WorkPlaceApprovalSkillsSet> WorkPlaceApprovalSkillsSets { get; set; }
        public virtual ICollection<WorkPlaceApprovalToolList> WorkPlaceApprovalToolLists { get; set; }
        public virtual ICollection<WorkPlaceApprovalTrade> WorkPlaceApprovalTrades { get; set; }
        public virtual ICollection<WorkPlaceApprovalUnitStandard> WorkPlaceApprovalUnitStandards { get; set; }
        public virtual ICollection<WorkPlaceApprovalVisitDateLog> WorkPlaceApprovalVisitDateLogs { get; set; }
    }
}

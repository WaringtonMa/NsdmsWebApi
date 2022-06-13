using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WspChecklist
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? AtrImplementedPercent { get; set; }
        public long? AtrSubmitted { get; set; }
        public long? BankingDetailsChecked { get; set; }
        public long? DeviationMotivation { get; set; }
        public long? ExtensionGranted { get; set; }
        public long? MinutesUplaoded { get; set; }
        public long? NonNqfMotivation { get; set; }
        public long? OtherSdfSigned { get; set; }
        public long? PivitolPlanSubmitted { get; set; }
        public long? SignOffComplete { get; set; }
        public long? SignedRecognitionAgreement { get; set; }
        public long? WspId { get; set; }
        public long? WspY18Submitted { get; set; }
        public decimal? PercentageCalculated { get; set; }
        public long? EmployerRepresentativePartTrainingCommittee { get; set; }
        public long? MajorityUnionId { get; set; }
        public long? NonNqfTrainingMotivationApproved { get; set; }
        public long? TradePartOfTrainingCommittee { get; set; }
        public long? TrainingCommitteeMinutesApproved { get; set; }
        public long? TrainingDeviationMotivationApproved { get; set; }
        public long? WorkplaceSkillsPlanSubmitted { get; set; }
        public ulong? GrantDeviated { get; set; }

        public virtual YesNoLookup? AtrImplementedPercentNavigation { get; set; }
        public virtual YesNoLookup? AtrSubmittedNavigation { get; set; }
        public virtual YesNoLookup? BankingDetailsCheckedNavigation { get; set; }
        public virtual YesNoLookup? DeviationMotivationNavigation { get; set; }
        public virtual YesNoLookup? EmployerRepresentativePartTrainingCommitteeNavigation { get; set; }
        public virtual YesNoLookup? ExtensionGrantedNavigation { get; set; }
        public virtual OrganisedLabourUnion? MajorityUnion { get; set; }
        public virtual YesNoLookup? MinutesUplaodedNavigation { get; set; }
        public virtual YesNoLookup? NonNqfMotivationNavigation { get; set; }
        public virtual YesNoLookup? NonNqfTrainingMotivationApprovedNavigation { get; set; }
        public virtual YesNoLookup? OtherSdfSignedNavigation { get; set; }
        public virtual YesNoLookup? PivitolPlanSubmittedNavigation { get; set; }
        public virtual YesNoLookup? SignOffCompleteNavigation { get; set; }
        public virtual YesNoLookup? SignedRecognitionAgreementNavigation { get; set; }
        public virtual YesNoLookup? TradePartOfTrainingCommitteeNavigation { get; set; }
        public virtual YesNoLookup? TrainingCommitteeMinutesApprovedNavigation { get; set; }
        public virtual YesNoLookup? TrainingDeviationMotivationApprovedNavigation { get; set; }
        public virtual YesNoLookup? WorkplaceSkillsPlanSubmittedNavigation { get; set; }
        public virtual Wsp? Wsp { get; set; }
        public virtual YesNoLookup? WspY18SubmittedNavigation { get; set; }
    }
}

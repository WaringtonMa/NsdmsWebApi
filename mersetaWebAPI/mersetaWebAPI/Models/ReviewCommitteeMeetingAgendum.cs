using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ReviewCommitteeMeetingAgendum
    {
        public ReviewCommitteeMeetingAgendum()
        {
            AssessorModExtensionOfScopePreviousReviewCommitteeMeetingAgenda = new HashSet<AssessorModExtensionOfScope>();
            AssessorModExtensionOfScopeReviewCommitteeMeetingAgenda = new HashSet<AssessorModExtensionOfScope>();
            AssessorModReRegistrationPreviousReviewCommitteeMeetingAgenda = new HashSet<AssessorModReRegistration>();
            AssessorModReRegistrationReviewCommitteeMeetingAgenda = new HashSet<AssessorModReRegistration>();
            AssessorModeratorApplications = new HashSet<AssessorModeratorApplication>();
            CompanyLearnersTerminations = new HashSet<CompanyLearnersTermination>();
            SdpExtensionOfScopes = new HashSet<SdpExtensionOfScope>();
            TrainingProviderApplications = new HashSet<TrainingProviderApplication>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? DecisionNumber { get; set; }
        public long? MeetingAgendaId { get; set; }
        public long? ReviewCommitteeMeetingId { get; set; }
        public ulong? Deleted { get; set; }

        public virtual MeetingAgendum? MeetingAgenda { get; set; }
        public virtual ReviewCommitteeMeeting? ReviewCommitteeMeeting { get; set; }
        public virtual ICollection<AssessorModExtensionOfScope> AssessorModExtensionOfScopePreviousReviewCommitteeMeetingAgenda { get; set; }
        public virtual ICollection<AssessorModExtensionOfScope> AssessorModExtensionOfScopeReviewCommitteeMeetingAgenda { get; set; }
        public virtual ICollection<AssessorModReRegistration> AssessorModReRegistrationPreviousReviewCommitteeMeetingAgenda { get; set; }
        public virtual ICollection<AssessorModReRegistration> AssessorModReRegistrationReviewCommitteeMeetingAgenda { get; set; }
        public virtual ICollection<AssessorModeratorApplication> AssessorModeratorApplications { get; set; }
        public virtual ICollection<CompanyLearnersTermination> CompanyLearnersTerminations { get; set; }
        public virtual ICollection<SdpExtensionOfScope> SdpExtensionOfScopes { get; set; }
        public virtual ICollection<TrainingProviderApplication> TrainingProviderApplications { get; set; }
    }
}

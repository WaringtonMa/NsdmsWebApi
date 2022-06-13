using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ReviewCommitteeMeeting
    {
        public ReviewCommitteeMeeting()
        {
            AssessorModExtensionOfScopePreviousReviewCommitteeMeetings = new HashSet<AssessorModExtensionOfScope>();
            AssessorModExtensionOfScopeReviewCommitteeMeetings = new HashSet<AssessorModExtensionOfScope>();
            AssessorModReRegistrationPreviousReviewCommitteeMeetings = new HashSet<AssessorModReRegistration>();
            AssessorModReRegistrationReviewCommitteeMeetings = new HashSet<AssessorModReRegistration>();
            AssessorModeratorApplications = new HashSet<AssessorModeratorApplication>();
            CompanyLearners = new HashSet<CompanyLearner>();
            CompanyLearnersDetailsChanges = new HashSet<CompanyLearnersDetailsChange>();
            CompanyLearnersTerminations = new HashSet<CompanyLearnersTermination>();
            ReviewCommitteeMeetingAgenda = new HashSet<ReviewCommitteeMeetingAgendum>();
            ReviewCommitteeMeetingUsers = new HashSet<ReviewCommitteeMeetingUser>();
            ScheduledEvents = new HashSet<ScheduledEvent>();
            SdpExtensionOfScopes = new HashSet<SdpExtensionOfScope>();
            SdpReAccreditations = new HashSet<SdpReAccreditation>();
            SkillsRegistrations = new HashSet<SkillsRegistration>();
            TrainingProviderApplications = new HashSet<TrainingProviderApplication>();
        }

        public long Id { get; set; }
        public string? AdditionalInfo { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? FromDateTime { get; set; }
        public long? MeetingNumber { get; set; }
        public int? Status { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public string? Title { get; set; }
        public DateTime? ToDateTime { get; set; }
        public string? Venue { get; set; }
        public long UserId { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<AssessorModExtensionOfScope> AssessorModExtensionOfScopePreviousReviewCommitteeMeetings { get; set; }
        public virtual ICollection<AssessorModExtensionOfScope> AssessorModExtensionOfScopeReviewCommitteeMeetings { get; set; }
        public virtual ICollection<AssessorModReRegistration> AssessorModReRegistrationPreviousReviewCommitteeMeetings { get; set; }
        public virtual ICollection<AssessorModReRegistration> AssessorModReRegistrationReviewCommitteeMeetings { get; set; }
        public virtual ICollection<AssessorModeratorApplication> AssessorModeratorApplications { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearners { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChanges { get; set; }
        public virtual ICollection<CompanyLearnersTermination> CompanyLearnersTerminations { get; set; }
        public virtual ICollection<ReviewCommitteeMeetingAgendum> ReviewCommitteeMeetingAgenda { get; set; }
        public virtual ICollection<ReviewCommitteeMeetingUser> ReviewCommitteeMeetingUsers { get; set; }
        public virtual ICollection<ScheduledEvent> ScheduledEvents { get; set; }
        public virtual ICollection<SdpExtensionOfScope> SdpExtensionOfScopes { get; set; }
        public virtual ICollection<SdpReAccreditation> SdpReAccreditations { get; set; }
        public virtual ICollection<SkillsRegistration> SkillsRegistrations { get; set; }
        public virtual ICollection<TrainingProviderApplication> TrainingProviderApplications { get; set; }
    }
}

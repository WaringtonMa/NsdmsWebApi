using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ScheduledEvent
    {
        public ScheduledEvent()
        {
            CompanyLearners = new HashSet<CompanyLearner>();
            CompanyLearnersDetailsChanges = new HashSet<CompanyLearnersDetailsChange>();
            ScheduledEventUsers = new HashSet<ScheduledEventUser>();
            TrainingProviderVerfications = new HashSet<TrainingProviderVerfication>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? FromDateTime { get; set; }
        public int? Status { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public string? Title { get; set; }
        public DateTime? ToDateTime { get; set; }
        public long? ReviewCommitteeMeetingId { get; set; }
        public long UserId { get; set; }
        public long? CompanyId { get; set; }
        public string? Appeals { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? CollectionType { get; set; }
        public ulong? CompanyModerationDone { get; set; }
        public string? Concistency { get; set; }
        public string? InternalModeration { get; set; }
        public int? ModerationEnum { get; set; }
        public int? PercentageEnum { get; set; }
        public string? Recomendations { get; set; }
        public string? Support { get; set; }
        public string? Behavior { get; set; }
        public string? CollectionInformation { get; set; }
        public DateTime? DateOfCollection { get; set; }
        public string? Decision { get; set; }
        public string? Documentation { get; set; }
        public ulong? LearnersSetForModeration { get; set; }
        public string? Plan { get; set; }
        public int? QualificationTypeSelectionEnum { get; set; }
        public DateTime? SignoffDate { get; set; }

        public virtual Company? Company { get; set; }
        public virtual ReviewCommitteeMeeting? ReviewCommitteeMeeting { get; set; }
        public virtual User User { get; set; } = null!;
        public virtual ICollection<CompanyLearner> CompanyLearners { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChanges { get; set; }
        public virtual ICollection<ScheduledEventUser> ScheduledEventUsers { get; set; }
        public virtual ICollection<TrainingProviderVerfication> TrainingProviderVerfications { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class AssessorModExtensionOfScope
    {
        public long Id { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public ulong? CodeOfConductAccepted { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? PreviousApplicationType { get; set; }
        public DateTime? PreviousCodeOfConductAcceptDate { get; set; }
        public int? Status { get; set; }
        public long? AssessorModeratorApplicationId { get; set; }
        public long? CreateUsersId { get; set; }
        public long? PreviousReviewCommitteeMeetingId { get; set; }
        public long? PreviousReviewCommitteeMeetingAgendaId { get; set; }
        public long? ReviewCommitteeMeetingId { get; set; }
        public long? ReviewCommitteeMeetingAgendaId { get; set; }

        public virtual AssessorModeratorApplication? AssessorModeratorApplication { get; set; }
        public virtual User? CreateUsers { get; set; }
        public virtual ReviewCommitteeMeeting? PreviousReviewCommitteeMeeting { get; set; }
        public virtual ReviewCommitteeMeetingAgendum? PreviousReviewCommitteeMeetingAgenda { get; set; }
        public virtual ReviewCommitteeMeeting? ReviewCommitteeMeeting { get; set; }
        public virtual ReviewCommitteeMeetingAgendum? ReviewCommitteeMeetingAgenda { get; set; }
    }
}

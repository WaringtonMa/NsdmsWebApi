using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SdpReAccreditation
    {
        public long Id { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? PrevioursAccreditationApplicationType { get; set; }
        public string? PrevioursSiteVisitComment { get; set; }
        public DateTime? PrevioursSiteVisitDate { get; set; }
        public DateTime? PrevioursSiteVisitReportDate { get; set; }
        public int? Status { get; set; }
        public long? ReviewCommitteeMeetingId { get; set; }
        public long? TrainingProviderApplicationId { get; set; }
        public long? UsersId { get; set; }

        public virtual ReviewCommitteeMeeting? ReviewCommitteeMeeting { get; set; }
        public virtual TrainingProviderApplication? TrainingProviderApplication { get; set; }
        public virtual User? Users { get; set; }
    }
}

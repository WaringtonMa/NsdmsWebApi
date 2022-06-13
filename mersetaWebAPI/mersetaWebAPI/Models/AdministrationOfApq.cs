using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class AdministrationOfApq
    {
        public AdministrationOfApq()
        {
            AdministrationOfApqLearners = new HashSet<AdministrationOfApqLearner>();
        }

        public long Id { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EisaDate { get; set; }
        public DateTime? EndTime { get; set; }
        public int? EntryRequirementsMet { get; set; }
        public int? ExemplarEisaHasBeenPublished { get; set; }
        public int? InPossessionFinalEisa { get; set; }
        public int? RecievedRequiredTraining { get; set; }
        public int? Status { get; set; }
        public long? AssessmentCenterId { get; set; }
        public long? AssessorId { get; set; }
        public long? UsersId { get; set; }
        public long? ModeratorId { get; set; }
        public long? QualificationId { get; set; }

        public virtual Company? AssessmentCenter { get; set; }
        public virtual User? Assessor { get; set; }
        public virtual User? Moderator { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual User? Users { get; set; }
        public virtual ICollection<AdministrationOfApqLearner> AdministrationOfApqLearners { get; set; }
    }
}

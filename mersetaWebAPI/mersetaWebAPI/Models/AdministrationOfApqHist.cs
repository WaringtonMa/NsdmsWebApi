using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class AdministrationOfApqHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
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

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

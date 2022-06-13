using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class RejectReasonsChild
    {
        public long Id { get; set; }
        public string? AdditionalInformation { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? CompanyId { get; set; }
        public long? RejectReasonsId { get; set; }
        public long? UserId { get; set; }
        public long? TasksId { get; set; }
        public long? BankingDetailsId { get; set; }
        public long? WspId { get; set; }
        public long? AssessorModeratorApplicationId { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }

        public virtual AssessorModeratorApplication? AssessorModeratorApplication { get; set; }
        public virtual BankingDetail? BankingDetails { get; set; }
        public virtual Company? Company { get; set; }
        public virtual RejectReason? RejectReasons { get; set; }
        public virtual Task? Tasks { get; set; }
        public virtual User? User { get; set; }
        public virtual Wsp? Wsp { get; set; }
    }
}

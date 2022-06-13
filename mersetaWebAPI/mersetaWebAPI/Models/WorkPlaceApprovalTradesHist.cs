using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkPlaceApprovalTradesHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? NumberOfLearners { get; set; }
        public int? NumberOfMentors { get; set; }
        public long? DeleteUserId { get; set; }
        public long? OfoCodesId { get; set; }
        public long? WorkPlaceApprovalId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

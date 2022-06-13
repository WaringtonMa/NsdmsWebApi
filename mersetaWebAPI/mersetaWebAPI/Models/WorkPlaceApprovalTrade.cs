using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkPlaceApprovalTrade
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? NumberOfLearners { get; set; }
        public int? NumberOfMentors { get; set; }
        public long? DeleteUserId { get; set; }
        public long? OfoCodesId { get; set; }
        public long? WorkPlaceApprovalId { get; set; }

        public virtual User? DeleteUser { get; set; }
        public virtual OfoCode? OfoCodes { get; set; }
        public virtual WorkPlaceApproval? WorkPlaceApproval { get; set; }
    }
}

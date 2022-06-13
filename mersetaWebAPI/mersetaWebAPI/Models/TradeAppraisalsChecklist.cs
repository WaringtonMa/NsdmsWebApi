using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class TradeAppraisalsChecklist
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? Answer { get; set; }
        public long? AppraisalChecklistId { get; set; }
        public long? WorkplaceApprovalId { get; set; }

        public virtual YesNoLookup? AnswerNavigation { get; set; }
        public virtual AppraisalChecklist? AppraisalChecklist { get; set; }
        public virtual WorkPlaceApproval? WorkplaceApproval { get; set; }
    }
}

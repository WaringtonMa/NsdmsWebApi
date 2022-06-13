using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class AppraisalChecklist
    {
        public AppraisalChecklist()
        {
            TradeAppraisalsChecklists = new HashSet<TradeAppraisalsChecklist>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public long? AppraisalCategoryId { get; set; }
        public long? AppraisalCategoryCodeId { get; set; }
        public long? AppraisalsId { get; set; }

        public virtual AppraisalCategory? AppraisalCategory { get; set; }
        public virtual AppraisalCategoryCode? AppraisalCategoryCode { get; set; }
        public virtual Appraisal? Appraisals { get; set; }
        public virtual ICollection<TradeAppraisalsChecklist> TradeAppraisalsChecklists { get; set; }
    }
}

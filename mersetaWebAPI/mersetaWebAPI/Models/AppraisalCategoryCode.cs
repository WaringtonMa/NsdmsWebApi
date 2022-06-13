using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class AppraisalCategoryCode
    {
        public AppraisalCategoryCode()
        {
            AppraisalChecklists = new HashSet<AppraisalChecklist>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? AppraisalCode { get; set; }
        public string? Description { get; set; }
        public long? AppraisalCategoryId { get; set; }

        public virtual AppraisalCategory? AppraisalCategory { get; set; }
        public virtual ICollection<AppraisalChecklist> AppraisalChecklists { get; set; }
    }
}

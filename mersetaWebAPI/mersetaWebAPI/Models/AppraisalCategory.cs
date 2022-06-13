using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class AppraisalCategory
    {
        public AppraisalCategory()
        {
            AppraisalCategoryCodes = new HashSet<AppraisalCategoryCode>();
            AppraisalChecklists = new HashSet<AppraisalChecklist>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<AppraisalCategoryCode> AppraisalCategoryCodes { get; set; }
        public virtual ICollection<AppraisalChecklist> AppraisalChecklists { get; set; }
    }
}

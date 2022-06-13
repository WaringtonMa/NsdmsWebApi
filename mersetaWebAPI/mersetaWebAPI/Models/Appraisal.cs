using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Appraisal
    {
        public Appraisal()
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
        public string? Description { get; set; }
        public long? OfoCodesId { get; set; }
        public long? QualificationId { get; set; }

        public virtual OfoCode? OfoCodes { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual ICollection<AppraisalChecklist> AppraisalChecklists { get; set; }
    }
}

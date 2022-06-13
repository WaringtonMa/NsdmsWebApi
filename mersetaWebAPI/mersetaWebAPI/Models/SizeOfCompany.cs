using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SizeOfCompany
    {
        public SizeOfCompany()
        {
            MandatoryGrantEvaluations = new HashSet<MandatoryGrantEvaluation>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? Description { get; set; }
        public int? MazSize { get; set; }
        public int? MinSize { get; set; }
        public string? SmsCode { get; set; }

        public virtual ICollection<MandatoryGrantEvaluation> MandatoryGrantEvaluations { get; set; }
    }
}

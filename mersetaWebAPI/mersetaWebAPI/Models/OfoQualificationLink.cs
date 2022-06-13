using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class OfoQualificationLink
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public long OfoCodesId { get; set; }
        public long QualificationId { get; set; }

        public virtual OfoCode OfoCodes { get; set; } = null!;
        public virtual SaqaQualification Qualification { get; set; } = null!;
    }
}

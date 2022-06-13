using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class MandatoryGrantEvaluation
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? Description { get; set; }
        public int? NoScore { get; set; }
        public double? TotalScore { get; set; }
        public ulong? ValidationForm { get; set; }
        public double? WeightedScore { get; set; }
        public int? WspTypeEnum { get; set; }
        public int? YesNoEnum { get; set; }
        public int? YesScore { get; set; }
        public long? SizeOfCompanyId { get; set; }
        public long? WspId { get; set; }

        public virtual SizeOfCompany? SizeOfCompany { get; set; }
        public virtual Wsp? Wsp { get; set; }
    }
}

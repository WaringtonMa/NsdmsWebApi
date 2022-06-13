using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LearnershipDataUpload
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? EtqaRegisteringLship { get; set; }
        public string? LshipIdSaqa { get; set; }
        public string? LshipIdSaqaTwo { get; set; }
        public string? LshipRegisEndDate { get; set; }
        public string? LearnershipCode { get; set; }
        public string? LearnershipTitle { get; set; }
        public string? MinCredits { get; set; }
        public string? NqfLevel { get; set; }
        public string? Pre2009NqfLevel { get; set; }
        public string? QualId { get; set; }
        public string? QualRegisEnd { get; set; }
        public string? QualStatus { get; set; }
        public string? QualificationTitle { get; set; }
    }
}

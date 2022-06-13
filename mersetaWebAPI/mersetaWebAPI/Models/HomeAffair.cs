using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class HomeAffair
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? DeathDate { get; set; }
        public string? DeathStatus { get; set; }
        public string? DhaIdNumber { get; set; }
        public string? FullNames { get; set; }
        public string? Gender { get; set; }
        public string? IdBookDateIssued { get; set; }
        public string? IdCardDateIssued { get; set; }
        public string? IdStatus { get; set; }
        public string? MaidenName { get; set; }
        public string? MersetaIdNo { get; set; }
        public string? Surname { get; set; }
    }
}

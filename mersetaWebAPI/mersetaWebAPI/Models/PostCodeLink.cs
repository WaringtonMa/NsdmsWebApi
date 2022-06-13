using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class PostCodeLink
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? Area { get; set; }
        public string? Description { get; set; }
        public string? PostCode { get; set; }
        public string? PostCodeUsedForSars { get; set; }
        public string? ProvinceCode { get; set; }
        public long? ProvinceId { get; set; }
        public int? PostCodeUsedForSarsNumberValue { get; set; }
    }
}

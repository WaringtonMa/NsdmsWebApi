using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class GrantOfoSelection
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? Description { get; set; }
        public int? GrantYear { get; set; }
        public int? OfoAtrSelectionYear { get; set; }
        public int? OfoWspSelectionYear { get; set; }
    }
}

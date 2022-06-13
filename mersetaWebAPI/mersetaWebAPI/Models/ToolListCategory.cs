using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ToolListCategory
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public long? ToolCategoryId { get; set; }
        public long? ToolListId { get; set; }

        public virtual ToolCategory? ToolCategory { get; set; }
    }
}

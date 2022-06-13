using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ToolListTool
    {
        public ToolListTool()
        {
            WorkPlaceApprovalToolLists = new HashSet<WorkPlaceApprovalToolList>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public long? ToolId { get; set; }
        public long? ToolListId { get; set; }

        public virtual Tool? Tool { get; set; }
        public virtual ICollection<WorkPlaceApprovalToolList> WorkPlaceApprovalToolLists { get; set; }
    }
}

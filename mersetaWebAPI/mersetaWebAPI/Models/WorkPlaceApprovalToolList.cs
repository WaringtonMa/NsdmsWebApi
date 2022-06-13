using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkPlaceApprovalToolList
    {
        public long Id { get; set; }
        public ulong? Accept { get; set; }
        public int? AcceptEnum { get; set; }
        public DateTime? CreateDate { get; set; }
        public ulong? SoftDelete { get; set; }
        public long? QualificationToolListId { get; set; }
        public long? ToolListId { get; set; }
        public long? ToolListToolsId { get; set; }
        public long? WorkPlaceApprovalId { get; set; }

        public virtual QualificationToolList? QualificationToolList { get; set; }
        public virtual ToolListTool? ToolListTools { get; set; }
        public virtual WorkPlaceApproval? WorkPlaceApproval { get; set; }
    }
}

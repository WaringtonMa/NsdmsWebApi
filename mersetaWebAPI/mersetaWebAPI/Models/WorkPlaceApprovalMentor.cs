using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkPlaceApprovalMentor
    {
        public WorkPlaceApprovalMentor()
        {
            WorkPlaceApprovalSites = new HashSet<WorkPlaceApprovalSite>();
        }

        public long Id { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public string? ApprovalEnum { get; set; }
        public DateTime? CreateDate { get; set; }
        public ulong? WithClientCompany { get; set; }
        public long? CreateUserId { get; set; }
        public long? WorkPlaceApprovalId { get; set; }

        public virtual User? CreateUser { get; set; }
        public virtual WorkPlaceApproval? WorkPlaceApproval { get; set; }
        public virtual ICollection<WorkPlaceApprovalSite> WorkPlaceApprovalSites { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkplaceMonitoringSiteVisitHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public ulong? AwaitingInitiation { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? MonitoringDate { get; set; }
        public DateTime? NonComplianceApprovalAte { get; set; }
        public ulong? NonComplianceHoldingArea { get; set; }
        public DateTime? NonComplianceSubmittedDate { get; set; }
        public ulong? NonCompliancesIdentified { get; set; }
        public ulong? SignOffState { get; set; }
        public int? Status { get; set; }
        public long? ApprovedUserId { get; set; }
        public long? CloUserId { get; set; }
        public long? CompanyId { get; set; }
        public long? CreateUserId { get; set; }
        public long? CrmUserId { get; set; }
        public long? ManagerAssignedCloUserId { get; set; }
        public long? ManagerAssignedCrmUserId { get; set; }
        public long? NonComplianceApprovalUserId { get; set; }
        public long? NonComplianceSubmittedUser { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

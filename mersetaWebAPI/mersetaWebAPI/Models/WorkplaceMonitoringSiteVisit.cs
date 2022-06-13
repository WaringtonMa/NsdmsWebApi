using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkplaceMonitoringSiteVisit
    {
        public WorkplaceMonitoringSiteVisit()
        {
            WorkplaceMonitoringMitigationPlans = new HashSet<WorkplaceMonitoringMitigationPlan>();
        }

        public long Id { get; set; }
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

        public virtual User? ApprovedUser { get; set; }
        public virtual User? CloUser { get; set; }
        public virtual Company? Company { get; set; }
        public virtual User? CreateUser { get; set; }
        public virtual User? CrmUser { get; set; }
        public virtual User? ManagerAssignedCloUser { get; set; }
        public virtual User? ManagerAssignedCrmUser { get; set; }
        public virtual User? NonComplianceApprovalUser { get; set; }
        public virtual User? NonComplianceSubmittedUserNavigation { get; set; }
        public virtual ICollection<WorkplaceMonitoringMitigationPlan> WorkplaceMonitoringMitigationPlans { get; set; }
    }
}

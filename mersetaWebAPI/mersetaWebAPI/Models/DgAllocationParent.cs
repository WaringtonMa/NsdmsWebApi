using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DgAllocationParent
    {
        public DgAllocationParent()
        {
            ActiveContracts = new HashSet<ActiveContract>();
            AllocationChangesReasons = new HashSet<AllocationChangesReason>();
            DgAllocations = new HashSet<DgAllocation>();
            InverseAllocationParent = new HashSet<DgAllocationParent>();
        }

        public long Id { get; set; }
        public DateTime? AcceptanceDate { get; set; }
        public string? AllocationStatusEnum { get; set; }
        public ulong? AlreadyRequested { get; set; }
        public int? AppealStatus { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public decimal? AvailableCoFundingAmount { get; set; }
        public int? CompanyCategorization { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DateAppealed { get; set; }
        public DateTime? DateAppealedApprovedRejected { get; set; }
        public decimal? DgLevyAmount { get; set; }
        public int? DiscretionalWithdrawalAppealEnum { get; set; }
        public ulong? DontAllocate { get; set; }
        public int? Status { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public long? AllocationParentId { get; set; }
        public long? SubmissionUserId { get; set; }
        public long? UserAppealed { get; set; }
        public long? UserApproveRejectedAppeal { get; set; }
        public long? WspId { get; set; }
        public decimal? DgLevyOriginalAmount { get; set; }

        public virtual DgAllocationParent? AllocationParent { get; set; }
        public virtual User? SubmissionUser { get; set; }
        public virtual User? UserAppealedNavigation { get; set; }
        public virtual User? UserApproveRejectedAppealNavigation { get; set; }
        public virtual Wsp? Wsp { get; set; }
        public virtual ICollection<ActiveContract> ActiveContracts { get; set; }
        public virtual ICollection<AllocationChangesReason> AllocationChangesReasons { get; set; }
        public virtual ICollection<DgAllocation> DgAllocations { get; set; }
        public virtual ICollection<DgAllocationParent> InverseAllocationParent { get; set; }
    }
}

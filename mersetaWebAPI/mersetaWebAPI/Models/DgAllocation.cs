using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DgAllocation
    {
        public DgAllocation()
        {
            ProjectImplementationPlanLearners = new HashSet<ProjectImplementationPlanLearner>();
            ProjectImplementationPlans = new HashSet<ProjectImplementationPlan>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public decimal? AvailableAmount { get; set; }
        public decimal? AwardAmount { get; set; }
        public decimal? BalanceRemaining { get; set; }
        public decimal? BalanceRemainingWithCoFunding { get; set; }
        public int? CloLearners { get; set; }
        public decimal? CoFundingGrantAmount { get; set; }
        public int? CrmLearners { get; set; }
        public decimal? DgLevyAmount { get; set; }
        public decimal? DisabledGrantAmount { get; set; }
        public int? DisabledTotalLearners { get; set; }
        public int? EmployedLearners { get; set; }
        public decimal? GrantAmount { get; set; }
        public int? MaxLearners { get; set; }
        public int? MaxPossibleLearners { get; set; }
        public decimal? RecommendedAmount { get; set; }
        public decimal? RemainingCoFundingGrantAmount { get; set; }
        public decimal? RequestedAmount { get; set; }
        public decimal? RunningTotal { get; set; }
        public int? TotalLearners { get; set; }
        public decimal? TotalLevyAmount { get; set; }
        public int? UnemployedLearners { get; set; }
        public long? MandatoryGrantId { get; set; }
        public long? WspId { get; set; }
        public decimal? CoFundingAwardAmount { get; set; }
        public decimal? CoFundingBalanceRemaining { get; set; }
        public decimal? CoFundingRunningTotal { get; set; }
        public decimal? MaxPossibleAmount { get; set; }
        public int? CoFundingLearnersAwarded { get; set; }
        public int? CompanyCategorization { get; set; }
        public decimal? MaxPossibleAmountRemaining { get; set; }
        public int? MaxPossibleLearnersRemaining { get; set; }
        public decimal? TotalAwardAmount { get; set; }
        public long? NumberDisabled { get; set; }
        public int? NumberOfLearners { get; set; }
        public long? InterventionTypeId { get; set; }
        public string? AllocationStatusEnum { get; set; }
        public int? ChangeAllocationLearners { get; set; }
        public int? InitialLearners { get; set; }
        public long? DgAllocationParentId { get; set; }
        public ulong? SystemChangeAllocationLearners { get; set; }

        public virtual DgAllocationParent? DgAllocationParent { get; set; }
        public virtual InterventionType? InterventionType { get; set; }
        public virtual MandatoryGrant? MandatoryGrant { get; set; }
        public virtual Wsp? Wsp { get; set; }
        public virtual ICollection<ProjectImplementationPlanLearner> ProjectImplementationPlanLearners { get; set; }
        public virtual ICollection<ProjectImplementationPlan> ProjectImplementationPlans { get; set; }
    }
}

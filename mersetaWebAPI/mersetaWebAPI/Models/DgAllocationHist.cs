using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DgAllocationHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public string? AllocationStatusEnum { get; set; }
        public decimal? AvailableAmount { get; set; }
        public decimal? AwardAmount { get; set; }
        public decimal? BalanceRemaining { get; set; }
        public decimal? BalanceRemainingWithCoFunding { get; set; }
        public int? ChangeAllocationLearners { get; set; }
        public int? CloLearners { get; set; }
        public decimal? CoFundingAwardAmount { get; set; }
        public decimal? CoFundingGrantAmount { get; set; }
        public int? CoFundingLearnersAwarded { get; set; }
        public decimal? CoFundingRunningTotal { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CrmLearners { get; set; }
        public decimal? DisabledGrantAmount { get; set; }
        public int? DisabledTotalLearners { get; set; }
        public int? EmployedLearners { get; set; }
        public decimal? GrantAmount { get; set; }
        public int? InitialLearners { get; set; }
        public int? MaxLearners { get; set; }
        public decimal? MaxPossibleAmount { get; set; }
        public decimal? MaxPossibleAmountRemaining { get; set; }
        public int? MaxPossibleLearners { get; set; }
        public int? MaxPossibleLearnersRemaining { get; set; }
        public long? NumberDisabled { get; set; }
        public int? NumberOfLearners { get; set; }
        public decimal? RecommendedAmount { get; set; }
        public decimal? RemainingCoFundingGrantAmount { get; set; }
        public decimal? RequestedAmount { get; set; }
        public decimal? RunningTotal { get; set; }
        public ulong? SystemChangeAllocationLearners { get; set; }
        public decimal? TotalAwardAmount { get; set; }
        public int? TotalLearners { get; set; }
        public decimal? TotalLevyAmount { get; set; }
        public int? UnemployedLearners { get; set; }
        public long? DgAllocationParentId { get; set; }
        public long? InterventionTypeId { get; set; }
        public long? MandatoryGrantId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

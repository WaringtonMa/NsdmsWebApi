using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class GpGrantBatchEntryHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? ArrivalDate1FormSarsFiles { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DateLoadedToGp { get; set; }
        public string? Description { get; set; }
        public double? DiscretionaryLevy { get; set; }
        public double? DiscretionaryLevyFromSarsFiles { get; set; }
        public double? DiscretionaryLevyRounded { get; set; }
        public DateTime? DocDate { get; set; }
        public string? DocumentNumber { get; set; }
        public int? DocumentTypeDiscretionary { get; set; }
        public int? DocumentTypeMandatory { get; set; }
        public string? EmployerName { get; set; }
        public ulong? ErrorEntry { get; set; }
        public string? ErrorMessage { get; set; }
        public double? FullLevyAmount { get; set; }
        public double? FullPercentageCalculation { get; set; }
        public string? LevyNumber { get; set; }
        public ulong? LoadedToGp { get; set; }
        public double? MandatoryLevy { get; set; }
        public double? MandatoryLevyFormSarsFiles { get; set; }
        public double? MandatoryLevyRounded { get; set; }
        public double? Purchases { get; set; }
        public int? SchemeYear { get; set; }
        public ulong? ToBeRemoved { get; set; }
        public double? Total { get; set; }
        public double? TotalFromSars { get; set; }
        public DateTime? UserActionedDate { get; set; }
        public string? VoucherNo { get; set; }
        public long? ActiveContractDetailId { get; set; }
        public long? GpGrantBatchListId { get; set; }
        public long? SarsLevyDetailsId { get; set; }
        public long? UserActionedId { get; set; }
        public long? ChamberLinkedId { get; set; }
        public long? SarsEmployerDetailLinkedId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

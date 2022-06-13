using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DgLegacyPaymentsHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public string? CurrentTrxAmount { get; set; }
        public double? CurrentTrxAmountConverted { get; set; }
        public string? Description { get; set; }
        public string? DocumentAmount { get; set; }
        public double? DocumentAmountConverted { get; set; }
        public string? DocumentDate { get; set; }
        public DateTime? DocumentDateConverted { get; set; }
        public string? DocumentNumber { get; set; }
        public string? DocumentStatus { get; set; }
        public string? DocumentType { get; set; }
        public string? PostedDate { get; set; }
        public DateTime? PostedDateConverted { get; set; }
        public string? PostingDate { get; set; }
        public DateTime? PostingDateConverted { get; set; }
        public string? SchemeYear { get; set; }
        public int? SchemeYearConverted { get; set; }
        public string? TransactionDescription { get; set; }
        public string? TrxSource { get; set; }
        public string? VendorId { get; set; }
        public string? VendorName { get; set; }
        public string? Voided { get; set; }
        public string? VoucherNumber { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class TS2
    {
        public long Id { get; set; }
        public string? AccountCode { get; set; }
        public string? Chamber { get; set; }
        public int? ChamberCode { get; set; }
        public string? CurrentTrxAmount { get; set; }
        public double? CurrentTrxAmountD { get; set; }
        public string? DocumentAmount { get; set; }
        public double? DocumentAmountD { get; set; }
        public string? DocumentDate { get; set; }
        public DateTime? DocumentDateD { get; set; }
        public string? DocumentNumber { get; set; }
        public string? DocumentStatus { get; set; }
        public string? DocumentStatus2 { get; set; }
        public string? DocumentType { get; set; }
        public int? FinancialYear { get; set; }
        public string? GpCodeSchemeYear { get; set; }
        public string? GrantAllocation { get; set; }
        public string? GrantType { get; set; }
        public int? GrntTypeGpCode { get; set; }
        public ulong? Newfile { get; set; }
        public string? PostedDate { get; set; }
        public DateTime? PostedDateD { get; set; }
        public string? PostingDate { get; set; }
        public DateTime? PostingDateD { get; set; }
        public int? SchemeYear { get; set; }
        public string? TransactionDescription { get; set; }
        public string? TrxSource { get; set; }
        public string? Tx { get; set; }
        public string? Ty { get; set; }
        public string? VendorId { get; set; }
        public string? VendorName { get; set; }
        public string? Voided { get; set; }
        public string? VoucherNumber { get; set; }
        public long? Ts1Id { get; set; }

        public virtual TS1? Ts1 { get; set; }
    }
}

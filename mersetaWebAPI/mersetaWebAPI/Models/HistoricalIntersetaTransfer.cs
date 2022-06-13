using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class HistoricalIntersetaTransfer
    {
        public string? RefNo { get; set; }
        public string? TransactionType { get; set; }
        public int? TrnsfrNo { get; set; }
        public int? Seta { get; set; }
        public string? SetaName { get; set; }
        public string? TransactionDate { get; set; }
        public string? GrantType { get; set; }
        public double? Amount { get; set; }
        public int? MersetaSchemeYear { get; set; }
        public ulong Id { get; set; }
        public DateTime? TransactionDateD { get; set; }
    }
}

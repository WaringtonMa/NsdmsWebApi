using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SarsInterSetaTransferLevy
    {
        public long Id { get; set; }
        public double? Admin { get; set; }
        public double? Discretionary { get; set; }
        public double? Interest { get; set; }
        public double? Mandatory { get; set; }
        public string? OrganisationName { get; set; }
        public double? Penalties { get; set; }
        public int? RelevantMonth { get; set; }
        public int? RelevantYear { get; set; }
        public string? SchemeYear { get; set; }
        public string? Sdlnumber { get; set; }
        public string? SetaCode { get; set; }
        public string? SetaName { get; set; }
        public double? T80Percent { get; set; }
        public double? Total { get; set; }
        public double? TotalA { get; set; }
        public string? TransactionDate { get; set; }
        public string? TransactionType { get; set; }
        public string? TransferType { get; set; }
    }
}

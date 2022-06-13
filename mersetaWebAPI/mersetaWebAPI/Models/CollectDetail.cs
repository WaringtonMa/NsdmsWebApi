using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CollectDetail
    {
        public CollectDetail()
        {
            CompanyLearnersTradeTests = new HashSet<CompanyLearnersTradeTest>();
        }

        public long Id { get; set; }
        public DateTime? CollectionDate { get; set; }
        public string? CompanyName { get; set; }
        public int? CompetenceEnum { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? FirstName { get; set; }
        public string? IdNumber { get; set; }
        public string? LastName { get; set; }
        public string? RegisteredMailNumber { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public string? WaybillNumber { get; set; }

        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTests { get; set; }
    }
}

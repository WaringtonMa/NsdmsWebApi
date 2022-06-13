using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class TransactionsCompanyValidiationHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? CreateDate { get; set; }
        public ulong? ErrorEntry { get; set; }
        public string? ErrorMessage { get; set; }
        public string? LevyNumber { get; set; }
        public ulong? NewCompany { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? CreateUsersId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

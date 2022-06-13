using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Addendum
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Description { get; set; }
        public string? Title { get; set; }
        public long? ActiveContractsId { get; set; }

        public virtual ActiveContract? ActiveContracts { get; set; }
    }
}

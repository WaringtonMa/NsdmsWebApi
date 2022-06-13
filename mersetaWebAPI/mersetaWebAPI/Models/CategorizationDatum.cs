using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CategorizationDatum
    {
        public long Id { get; set; }
        public int? Categorization { get; set; }
        public string? CompanyCategory { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? LevyNumber { get; set; }
        public long? CompanyId { get; set; }

        public virtual Company? Company { get; set; }
    }
}

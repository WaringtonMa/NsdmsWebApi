using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class TS1
    {
        public TS1()
        {
            TS2s = new HashSet<TS2>();
        }

        public long Id { get; set; }
        public string? LevyNumber { get; set; }
        public int? SchemeYear { get; set; }
        public string? StatusDescription { get; set; }

        public virtual ICollection<TS2> TS2s { get; set; }
    }
}

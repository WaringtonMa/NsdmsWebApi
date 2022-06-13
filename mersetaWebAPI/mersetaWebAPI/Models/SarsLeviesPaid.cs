using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SarsLeviesPaid
    {
        public SarsLeviesPaid()
        {
            Docs = new HashSet<Doc>();
        }

        public long Id { get; set; }
        public double? CheckbookAmount { get; set; }
        public DateTime? GlPostingDate { get; set; }
        public string? LevyFile { get; set; }
        public long? SarsFileId { get; set; }

        public virtual SarsFile? SarsFile { get; set; }
        public virtual ICollection<Doc> Docs { get; set; }
    }
}

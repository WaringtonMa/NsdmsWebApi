using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SprocedureLog
    {
        public long Id { get; set; }
        public string? SpName { get; set; }
        public string? SpRanBy { get; set; }
        public DateTime? SpRanWhen { get; set; }
        public string? SpDetails { get; set; }
        public string? SpComments { get; set; }
        public int? SpStatus { get; set; }
        public string? SpStatusResponse { get; set; }
    }
}

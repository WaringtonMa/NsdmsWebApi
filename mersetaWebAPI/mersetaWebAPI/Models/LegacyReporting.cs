using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyReporting
    {
        public LegacyReporting()
        {
            LegacyReportingParams = new HashSet<LegacyReportingParam>();
        }

        public long Id { get; set; }
        public string? ForClass { get; set; }
        public string? MapKey { get; set; }
        public string? Name { get; set; }
        public string? Query { get; set; }
        public string? ReturnType { get; set; }
        public ulong? RunAsNative { get; set; }
        public ulong? SingleResult { get; set; }

        public virtual ICollection<LegacyReportingParam> LegacyReportingParams { get; set; }
    }
}

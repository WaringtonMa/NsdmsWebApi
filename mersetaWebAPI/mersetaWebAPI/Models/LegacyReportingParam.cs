using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyReportingParam
    {
        public long Id { get; set; }
        public string? FieldName { get; set; }
        public string? ParamName { get; set; }
        public long? LegacyReportingId { get; set; }

        public virtual LegacyReporting? LegacyReporting { get; set; }
    }
}

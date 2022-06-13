using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WspStrategicPriority
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? InterventionTypeId { get; set; }
        public long? StrategicPrioritiesId { get; set; }
        public long? WspId { get; set; }

        public virtual InterventionType? InterventionType { get; set; }
        public virtual StrategicPriority? StrategicPriorities { get; set; }
        public virtual Wsp? Wsp { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class StrategicPriority
    {
        public StrategicPriority()
        {
            WspStrategicPriorities = new HashSet<WspStrategicPriority>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Description { get; set; }
        public long? CreateUserId { get; set; }

        public virtual User? CreateUser { get; set; }
        public virtual ICollection<WspStrategicPriority> WspStrategicPriorities { get; set; }
    }
}

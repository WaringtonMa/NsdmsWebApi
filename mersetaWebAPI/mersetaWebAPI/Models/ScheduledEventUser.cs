using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ScheduledEventUser
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? JobTitleId { get; set; }
        public long ScheduledEventId { get; set; }
        public long UserId { get; set; }

        public virtual JobTitle? JobTitle { get; set; }
        public virtual ScheduledEvent ScheduledEvent { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}

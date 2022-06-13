using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class TaskUser
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? TaskId { get; set; }
        public long? UserId { get; set; }

        public virtual Task? Task { get; set; }
        public virtual User? User { get; set; }
    }
}

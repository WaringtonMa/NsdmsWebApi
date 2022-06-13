using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ReviewCommitteeMeetingUser
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? ReviewCommitteeMeetingId { get; set; }
        public long? UsersId { get; set; }

        public virtual ReviewCommitteeMeeting? ReviewCommitteeMeeting { get; set; }
        public virtual User? Users { get; set; }
    }
}

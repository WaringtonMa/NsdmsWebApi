using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class UsersType
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? TypeOfUser { get; set; }
        public long? UserId { get; set; }

        public virtual User? User { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class UsersDisabilityAud
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public long? DisabilityRatingId { get; set; }
        public long? DisabilityStatus { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

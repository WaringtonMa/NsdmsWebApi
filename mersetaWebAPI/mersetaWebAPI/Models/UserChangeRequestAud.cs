using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class UserChangeRequestAud
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public long? DisabilityStatus { get; set; }
        public long? EquityId { get; set; }
        public long? GenderId { get; set; }
        public long? NationalityId { get; set; }
        public long? TitleId { get; set; }
        public long? UserId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

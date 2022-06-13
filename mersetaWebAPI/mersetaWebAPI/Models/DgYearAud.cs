using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DgYearAud
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public long? DocId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

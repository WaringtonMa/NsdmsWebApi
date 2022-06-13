using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WspLocation
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? ProvinceId { get; set; }
        public long? WspId { get; set; }

        public virtual Wsp? Wsp { get; set; }
    }
}

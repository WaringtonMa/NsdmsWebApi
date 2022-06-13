using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class MandatoryGrantWorkplace
    {
        public long Id { get; set; }
        public int? Amount { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? MandatoryGrantId { get; set; }
        public long? SitesId { get; set; }

        public virtual MandatoryGrant? MandatoryGrant { get; set; }
        public virtual Site? Sites { get; set; }
    }
}

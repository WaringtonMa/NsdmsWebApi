using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyLearnersIgnoreSetmi
    {
        public long Id { get; set; }
        public long CompanyLearnerIdFlat { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Note { get; set; }
    }
}

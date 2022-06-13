using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class MunicipalityType
    {
        public MunicipalityType()
        {
            Municipalities = new HashSet<Municipality>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? MunicipalityTypeDesc { get; set; }
        public string? SicCode { get; set; }

        public virtual ICollection<Municipality> Municipalities { get; set; }
    }
}

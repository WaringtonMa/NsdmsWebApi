using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Province
    {
        public Province()
        {
            Municipalities = new HashSet<Municipality>();
        }

        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Color { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? LandArea { get; set; }
        public string? Map { get; set; }
        public string? ProvinceDesc { get; set; }
        public string? StatsProvId { get; set; }

        public virtual ICollection<Municipality> Municipalities { get; set; }
    }
}

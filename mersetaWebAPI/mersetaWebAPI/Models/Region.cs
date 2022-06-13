using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Region
    {
        public Region()
        {
            JobTitles = new HashSet<JobTitle>();
            RegionTowns = new HashSet<RegionTown>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? Description { get; set; }
        public string? SmsCode { get; set; }

        public virtual ICollection<JobTitle> JobTitles { get; set; }
        public virtual ICollection<RegionTown> RegionTowns { get; set; }
    }
}

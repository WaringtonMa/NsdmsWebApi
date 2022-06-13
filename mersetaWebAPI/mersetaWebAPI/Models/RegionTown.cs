using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class RegionTown
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? Description { get; set; }
        public long? CloId { get; set; }
        public long? CrmId { get; set; }
        public long? OtherId { get; set; }
        public long? RegionId { get; set; }
        public long? TownId { get; set; }
        public string? SmsCode { get; set; }

        public virtual HostingCompanyEmployee? Clo { get; set; }
        public virtual HostingCompanyEmployee? Crm { get; set; }
        public virtual HostingCompanyEmployee? Other { get; set; }
        public virtual Region? Region { get; set; }
        public virtual Town? Town { get; set; }
    }
}

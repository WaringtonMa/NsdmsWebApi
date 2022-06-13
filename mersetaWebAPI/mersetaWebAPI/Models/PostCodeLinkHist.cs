using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class PostCodeLinkHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public string? Area { get; set; }
        public string? Description { get; set; }
        public string? PostCode { get; set; }
        public string? PostCodeUsedForSars { get; set; }
        public string? ProvinceCode { get; set; }
        public long? ProvinceId { get; set; }
        public int? PostCodeUsedForSarsNumberValue { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

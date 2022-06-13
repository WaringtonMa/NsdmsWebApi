using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SaqaUnitstandardHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public int? Unitstandardid { get; set; }
        public string? Unitstdtitle { get; set; }
        public string? Field { get; set; }
        public string? Nqflevelg2Description { get; set; }
        public string? Saqadecisionnumber { get; set; }
        public string? Unitstdnumberofcredits { get; set; }
        public DateTime? LastDateForEnrolment { get; set; }
        public DateTime? Usregistrationenddate { get; set; }
        public DateTime? Usregistrationstartdate { get; set; }
        public string? Unitstdtypedesc { get; set; }
        public string? UnitStandardIdString { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

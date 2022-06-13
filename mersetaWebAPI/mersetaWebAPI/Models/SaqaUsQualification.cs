using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SaqaUsQualification
    {
        public long Id { get; set; }
        public string? Nqfleveldescription { get; set; }
        public string? Nqflevelg2Description { get; set; }
        public int? Qualificationid { get; set; }
        public int? Unitstandardid { get; set; }
        public int? Unitstdnumberofcredits { get; set; }
        public string? Unitstdtitle { get; set; }
        public string? Usqualtypedescription { get; set; }
        public long? QualificationId1 { get; set; }
        public int? UnitStandardLinkType { get; set; }

        public virtual SaqaQualification? QualificationId1Navigation { get; set; }
    }
}

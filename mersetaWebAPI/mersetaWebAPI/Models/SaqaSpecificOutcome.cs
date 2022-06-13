using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SaqaSpecificOutcome
    {
        public long Id { get; set; }
        public int? Outcomeid { get; set; }
        public string? OutcomeNotes { get; set; }
        public string? Outcomerange { get; set; }
        public string? OutcomeTitle { get; set; }
        public int? Unitstandardid { get; set; }
        public long? UnitstandardId1 { get; set; }

        public virtual SaqaUnitstandard? UnitstandardId1Navigation { get; set; }
    }
}

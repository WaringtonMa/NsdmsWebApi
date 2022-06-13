using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SaqaUnitstandardTemp
    {
        public SaqaUnitstandardTemp()
        {
            SaqaSpecificOutcomeTemps = new HashSet<SaqaSpecificOutcomeTemp>();
        }

        public long Id { get; set; }
        public string? Abetbanddescription { get; set; }
        public string? Etqaacronym { get; set; }
        public string? Etqaname { get; set; }
        public string? Field { get; set; }
        public string? Fielddescription { get; set; }
        public string? Nqfleveldescription { get; set; }
        public string? Nqflevelg2Description { get; set; }
        public string? Providercode { get; set; }
        public int? Provideretqaid { get; set; }
        public string? Providername { get; set; }
        public string? Registrationstatusdesc { get; set; }
        public string? Saqadecisionnumber { get; set; }
        public string? Sgbname { get; set; }
        public string? Subfielddescription { get; set; }
        public int? Trainoutperiod { get; set; }
        public int? Transitionperiod { get; set; }
        public int? Unitstandardid { get; set; }
        public string? Unitstdaccreditationoptions { get; set; }
        public string? Unitstdassessorcriteria { get; set; }
        public string? Unitstdccfocollecting { get; set; }
        public string? Unitstdccfocommunicating { get; set; }
        public string? Unitstdccfocontributing { get; set; }
        public string? Unitstdccfodemonstrating { get; set; }
        public string? Unitstdccfoidentifying { get; set; }
        public string? Unitstdccfoorganizing { get; set; }
        public string? Unitstdccfoscience { get; set; }
        public string? Unitstdccfoworking { get; set; }
        public string? Unitstddevelopmentaloutcome { get; set; }
        public string? Unitstdembeddedknowledge { get; set; }
        public string? Unitstdlearningassumptions { get; set; }
        public string? Unitstdlinkages { get; set; }
        public string? Unitstdnotes { get; set; }
        public int? Unitstdnumberofcredits { get; set; }
        public string? Unitstdoutcomeheader { get; set; }
        public string? Unitstdpurpose { get; set; }
        public string? Unitstdrange { get; set; }
        public string? Unitstdtitle { get; set; }
        public string? Unitstdtypedesc { get; set; }
        public DateTime? LastDateForEnrolment { get; set; }
        public DateTime? Usregistrationenddate { get; set; }
        public DateTime? Usregistrationstartdate { get; set; }

        public virtual ICollection<SaqaSpecificOutcomeTemp> SaqaSpecificOutcomeTemps { get; set; }
    }
}

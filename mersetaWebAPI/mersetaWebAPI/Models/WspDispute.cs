using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WspDispute
    {
        public WspDispute()
        {
            Signoffs = new HashSet<Signoff>();
        }

        public long Id { get; set; }
        public ulong? AgreementOfGrants { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? MediationDate { get; set; }
        public string? ResonForDispute { get; set; }
        public long? CreateUserId { get; set; }
        public long? WspId { get; set; }
        public ulong? NoAgreement { get; set; }
        public ulong? Resolved { get; set; }
        public string? SummaryNoAgreement { get; set; }
        public string? Venue { get; set; }
        public string? EmployerRep { get; set; }
        public string? LabourRep { get; set; }

        public virtual User? CreateUser { get; set; }
        public virtual Wsp? Wsp { get; set; }
        public virtual ICollection<Signoff> Signoffs { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class TrainingComitteeHostory
    {
        public long Id { get; set; }
        public int? ApprovalStatus { get; set; }
        public string? CellNumber { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Email { get; set; }
        public string? FaxNumber { get; set; }
        public string? FirstName { get; set; }
        public int? IdType { get; set; }
        public string? LastName { get; set; }
        public string? PassportNumber { get; set; }
        public string? RsaIdNumber { get; set; }
        public string? TelNumber { get; set; }
        public string? UnionName { get; set; }
        public long CompanyId { get; set; }
        public long? EquityId { get; set; }
        public long? ForTrainingComittee { get; set; }
        public long? GenderId { get; set; }
        public long? TitleId { get; set; }
        public long? UnionId { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual Equity? Equity { get; set; }
        public virtual TrainingComittee? ForTrainingComitteeNavigation { get; set; }
        public virtual Gender? Gender { get; set; }
        public virtual Title? Title { get; set; }
        public virtual OrganisedLabourUnion? Union { get; set; }
    }
}

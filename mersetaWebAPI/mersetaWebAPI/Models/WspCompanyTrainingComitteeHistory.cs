using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WspCompanyTrainingComitteeHistory
    {
        public long Id { get; set; }
        public int? ApprovalStatus { get; set; }
        public string? CellNumber { get; set; }
        public long? CompanyOriginalId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Email { get; set; }
        public string? FaxNumber { get; set; }
        public string? FirstName { get; set; }
        public int? IdType { get; set; }
        public string? LastName { get; set; }
        public DateTime? OrginalCreateDate { get; set; }
        public long? OrginalTrainingComitteeId { get; set; }
        public string? PassportNumber { get; set; }
        public string? RsaIdNumber { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public string? TelNumber { get; set; }
        public string? UnionName { get; set; }
        public long? EquityId { get; set; }
        public long? GenderId { get; set; }
        public long? TitleId { get; set; }
        public long? UnionId { get; set; }
        public long? WspCompanyMainHistoryId { get; set; }

        public virtual Equity? Equity { get; set; }
        public virtual Gender? Gender { get; set; }
        public virtual Title? Title { get; set; }
        public virtual OrganisedLabourUnion? Union { get; set; }
        public virtual WspCompanyMainHistory? WspCompanyMainHistory { get; set; }
    }
}

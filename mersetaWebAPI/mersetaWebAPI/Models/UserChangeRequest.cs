using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class UserChangeRequest
    {
        public long Id { get; set; }
        public int? ApprovalStatus { get; set; }
        public string? CellNumber { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? Disability { get; set; }
        public string? Email { get; set; }
        public string? FaxNumber { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int? Maried { get; set; }
        public string? MiddleName { get; set; }
        public string? PassportNumber { get; set; }
        public string? RsaIdNumber { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public string? TelNumber { get; set; }
        public int? UrbanRuralEnum { get; set; }
        public long? DisabilityStatus { get; set; }
        public long? EquityId { get; set; }
        public long? GenderId { get; set; }
        public long? LegalGaurdianId { get; set; }
        public long? NationalityId { get; set; }
        public long? TitleId { get; set; }
        public long? UserId { get; set; }

        public virtual DisabilityStatus? DisabilityStatusNavigation { get; set; }
        public virtual Equity? Equity { get; set; }
        public virtual Gender? Gender { get; set; }
        public virtual User? LegalGaurdian { get; set; }
        public virtual Nationality? Nationality { get; set; }
        public virtual Title? Title { get; set; }
        public virtual User? User { get; set; }
    }
}

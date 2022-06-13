using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyHistory
    {
        public long Id { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? ApprovalEnum { get; set; }
        public int? Categorization { get; set; }
        public string? CompanyGuid { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? CompanyRegistrationNumber { get; set; }
        public int? CompanyStatus { get; set; }
        public int? CompanyType { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Email { get; set; }
        public string? FaxNumber { get; set; }
        public DateTime? FinancialYearEndDate { get; set; }
        public int? FinancialYearEndDay { get; set; }
        public int? FinancialYearEndMonth { get; set; }
        public DateTime? FinancialYearStartDate { get; set; }
        public int? FinancialYearStartDay { get; set; }
        public int? FinancialYearStartMonth { get; set; }
        public string? LevyNumber { get; set; }
        public string? LevyNumberAdditional { get; set; }
        public ulong? Locked { get; set; }
        public ulong? NonLevyPaying { get; set; }
        public int? NumberOfEmployees { get; set; }
        public ulong? OnGp { get; set; }
        public string? PayeSdlNumber { get; set; }
        public string? RejectReason { get; set; }
        public string? SarsTradingStatus { get; set; }
        public string? TelNumber { get; set; }
        public string? TradingName { get; set; }
        public ulong? TrainingCommitteeInPlace { get; set; }
        public long? ChamberId { get; set; }
        public long? ForCompanyId { get; set; }
        public long? FormUserId { get; set; }
        public long? InstitutionTypeId { get; set; }
        public long? CompanyId { get; set; }
        public long? MajorityUnionId { get; set; }
        public long? OrganisationTypeId { get; set; }
        public long? PostalAddressId { get; set; }
        public long? RecognitionAgreementId { get; set; }
        public long? RegisteredAddressId { get; set; }
        public long? ResidentialAddressId { get; set; }
        public long? SicCodeId { get; set; }
        public string? AccreditationNumber { get; set; }
        public long? SetaId { get; set; }

        public virtual Chamber? Chamber { get; set; }
        public virtual Company? Company { get; set; }
        public virtual Company? ForCompany { get; set; }
        public virtual User? FormUser { get; set; }
        public virtual InstitutionType? InstitutionType { get; set; }
        public virtual OrganisedLabourUnion? MajorityUnion { get; set; }
        public virtual OrganisationType? OrganisationType { get; set; }
        public virtual Address? PostalAddress { get; set; }
        public virtual YesNoLookup? RecognitionAgreement { get; set; }
        public virtual Address? RegisteredAddress { get; set; }
        public virtual Address? ResidentialAddress { get; set; }
        public virtual Setum? Seta { get; set; }
        public virtual SicCode? SicCode { get; set; }
    }
}

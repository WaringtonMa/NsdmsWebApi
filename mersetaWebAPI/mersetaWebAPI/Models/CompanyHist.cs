using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? ApprovalEnum { get; set; }
        public int? Categorization { get; set; }
        public string? CompanyGuid { get; set; }
        public string? CompanyName { get; set; }
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
        public long? EtqaId { get; set; }
        public ulong? NonSetaCompany { get; set; }
        public long? SetaId { get; set; }
        public string? UserCellNumber { get; set; }
        public string? UserEmail { get; set; }
        public string? UserFirstName { get; set; }
        public string? UserLastName { get; set; }
        public string? UserMiddleName { get; set; }
        public string? UserTelNumber { get; set; }
        public string? WorkplaceApprovalNumber { get; set; }
        public DateTime? DeregisterDate { get; set; }
        public long? DeregisterUserId { get; set; }
        public long? PreviousCompanyId { get; set; }
        public string? CompanySiteNumber { get; set; }
        public string? CompanyWebsite { get; set; }
        public DateTime? ValidiationRanDate { get; set; }
        public ulong? UseTradingNameSetmis { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

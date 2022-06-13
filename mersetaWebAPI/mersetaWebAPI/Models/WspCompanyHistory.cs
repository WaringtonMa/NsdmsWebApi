using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WspCompanyHistory
    {
        public WspCompanyHistory()
        {
            InverseCompany = new HashSet<WspCompanyHistory>();
            InversePreviousCompany = new HashSet<WspCompanyHistory>();
        }

        public long Id { get; set; }
        public string? AccreditationNumber { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? ApprovalEnum { get; set; }
        public int? Categorization { get; set; }
        public string? CompanyGuid { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? CompanyRegistrationNumber { get; set; }
        public string? CompanySiteNumber { get; set; }
        public int? CompanyStatus { get; set; }
        public int? CompanyType { get; set; }
        public string? CompanyWebsite { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DeregisterDate { get; set; }
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
        public ulong? NonSetaCompany { get; set; }
        public int? NumberOfEmployees { get; set; }
        public ulong? OnGp { get; set; }
        public long? OrginalCompanyId { get; set; }
        public DateTime? OrginalCreateDate { get; set; }
        public string? PayeSdlNumber { get; set; }
        public long? PostalAddressOrginalAddressId { get; set; }
        public long? RegisteredAddressOrginalAddress { get; set; }
        public string? RejectReason { get; set; }
        public long? ResidentialAddressOrginalAddressId { get; set; }
        public string? SarsTradingStatus { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public string? TelNumber { get; set; }
        public string? TradingName { get; set; }
        public ulong? TrainingCommitteeInPlace { get; set; }
        public string? WorkplaceApprovalNumber { get; set; }
        public long? WspLinkId { get; set; }
        public long? ChamberId { get; set; }
        public long? DeregisterUserId { get; set; }
        public long? EtqaId { get; set; }
        public long? FormUserId { get; set; }
        public long? InstitutionTypeId { get; set; }
        public long? CompanyId { get; set; }
        public long? MajorityUnionId { get; set; }
        public long? OrganisationTypeId { get; set; }
        public long? PreviousCompanyId { get; set; }
        public long? RecognitionAgreementId { get; set; }
        public long? SetaId { get; set; }
        public long? SicCodeId { get; set; }
        public long? WspCompanyAddressHistoryPostalId { get; set; }
        public long? WspCompanyAddressHistoryRegisteredId { get; set; }
        public long? WspCompanyAddressHistoryResidentialId { get; set; }
        public long? WspCompanyMainHistoryId { get; set; }

        public virtual Chamber? Chamber { get; set; }
        public virtual WspCompanyHistory? Company { get; set; }
        public virtual User? DeregisterUser { get; set; }
        public virtual Etqa? Etqa { get; set; }
        public virtual User? FormUser { get; set; }
        public virtual InstitutionType? InstitutionType { get; set; }
        public virtual OrganisedLabourUnion? MajorityUnion { get; set; }
        public virtual OrganisationType? OrganisationType { get; set; }
        public virtual WspCompanyHistory? PreviousCompany { get; set; }
        public virtual YesNoLookup? RecognitionAgreement { get; set; }
        public virtual Setum? Seta { get; set; }
        public virtual SicCode? SicCode { get; set; }
        public virtual WspCompanyAddressHistory? WspCompanyAddressHistoryPostal { get; set; }
        public virtual WspCompanyAddressHistory? WspCompanyAddressHistoryRegistered { get; set; }
        public virtual WspCompanyAddressHistory? WspCompanyAddressHistoryResidential { get; set; }
        public virtual WspCompanyMainHistory? WspCompanyMainHistory { get; set; }
        public virtual ICollection<WspCompanyHistory> InverseCompany { get; set; }
        public virtual ICollection<WspCompanyHistory> InversePreviousCompany { get; set; }
    }
}

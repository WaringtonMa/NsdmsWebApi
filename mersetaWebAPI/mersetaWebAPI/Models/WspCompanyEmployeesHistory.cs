using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WspCompanyEmployeesHistory
    {
        public long Id { get; set; }
        public int? AgeGroup { get; set; }
        public int? ApprovalStatus { get; set; }
        public long? CompanyOriginalId { get; set; }
        public ulong? CompletedTraining { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? EmployedUnemployed { get; set; }
        public int? EmploymentStatus { get; set; }
        public string? FirstName { get; set; }
        public int? IdType { get; set; }
        public string? JobTitle { get; set; }
        public string? LastName { get; set; }
        public DateTime? OrginalCreateDate { get; set; }
        public long? OrginalEmployeesId { get; set; }
        public string? PassportNumber { get; set; }
        public ulong? PlannedTraining { get; set; }
        public string? RsaIdNumber { get; set; }
        public string? SdlNumber { get; set; }
        public string? SiteName { get; set; }
        public string? SiteNumber { get; set; }
        public long? SiteOriginalId { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? WspOriginalId { get; set; }
        public long? DisabilityId { get; set; }
        public long? EmploymentTypeId { get; set; }
        public long? EquityId { get; set; }
        public long? GenderId { get; set; }
        public long? HighestQualTitle { get; set; }
        public long? HighestQualType { get; set; }
        public int? MunicipalityId { get; set; }
        public long? NationalityId { get; set; }
        public long? OccupationCategoryId { get; set; }
        public long? OfoCodeId { get; set; }
        public long? WspCompanyMainHistoryId { get; set; }

        public virtual DisabilityStatus? Disability { get; set; }
        public virtual EmploymentType? EmploymentType { get; set; }
        public virtual Equity? Equity { get; set; }
        public virtual Gender? Gender { get; set; }
        public virtual SaqaQualification? HighestQualTitleNavigation { get; set; }
        public virtual QualificationType? HighestQualTypeNavigation { get; set; }
        public virtual Municipality? Municipality { get; set; }
        public virtual Nationality? Nationality { get; set; }
        public virtual OccupationCategory? OccupationCategory { get; set; }
        public virtual OfoCode? OfoCode { get; set; }
        public virtual WspCompanyMainHistory? WspCompanyMainHistory { get; set; }
    }
}

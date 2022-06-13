using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class EmployeesHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public int? AgeGroup { get; set; }
        public int? ApprovalStatus { get; set; }
        public ulong? CompletedTraining { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? EmployedUnemployed { get; set; }
        public int? EmploymentStatus { get; set; }
        public string? FirstName { get; set; }
        public int? IdType { get; set; }
        public string? JobTitle { get; set; }
        public string? LastName { get; set; }
        public string? PassportNumber { get; set; }
        public ulong? PlannedTraining { get; set; }
        public string? RsaIdNumber { get; set; }
        public string? SdlNumber { get; set; }
        public string? SiteName { get; set; }
        public string? SiteNumber { get; set; }
        public long? CompanyId { get; set; }
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
        public long? SiteId { get; set; }
        public long? WspId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

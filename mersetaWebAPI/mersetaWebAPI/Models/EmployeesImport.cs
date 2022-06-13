using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class EmployeesImport
    {
        public EmployeesImport()
        {
            EmployeesImportTrainings = new HashSet<EmployeesImportTraining>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Disability { get; set; }
        public string? EmployeeId { get; set; }
        public string? EmploymentStatus { get; set; }
        public string? EmploymentType { get; set; }
        public string? Equity { get; set; }
        public string? Error { get; set; }
        public long? ErrorSort { get; set; }
        public string? FirstName { get; set; }
        public string? Gender { get; set; }
        public string? HighestQualCode { get; set; }
        public string? HighestQualType { get; set; }
        public string? IdType { get; set; }
        public ulong? Imported { get; set; }
        public string? JobTitle { get; set; }
        public string? LastName { get; set; }
        public string? Municipality { get; set; }
        public string? Nationality { get; set; }
        public string? OccupationCategory { get; set; }
        public string? OfoCode { get; set; }
        public string? SdlNumber { get; set; }
        public string? SiteNumber { get; set; }
        public string? UniqueId { get; set; }
        public long? EmpId { get; set; }
        public long? WspId { get; set; }
        public long? CompanyId { get; set; }
        public string? SpecialisationCode { get; set; }

        public virtual Company? Company { get; set; }
        public virtual Employee? Emp { get; set; }
        public virtual Wsp? Wsp { get; set; }
        public virtual ICollection<EmployeesImportTraining> EmployeesImportTrainings { get; set; }
    }
}

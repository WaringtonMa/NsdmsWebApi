using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class EmployeesImportTraining
    {
        public long Id { get; set; }
        public string? AccreditationNumber { get; set; }
        public int? CompletedPlanned { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? EmpUniqueId { get; set; }
        public string? Error { get; set; }
        public long? ErrorSort { get; set; }
        public string? Etqa { get; set; }
        public ulong? Imported { get; set; }
        public string? InterventionCost { get; set; }
        public string? InterventionLevel { get; set; }
        public string? InterventionTitle { get; set; }
        public int? PivotalNonpivotal { get; set; }
        public string? ProviderName { get; set; }
        public string? SaqaId { get; set; }
        public string? SourceOfFunding { get; set; }
        public long? EmpTrainingId { get; set; }
        public long? EmployeesImportId { get; set; }

        public virtual EmployeesTraining? EmpTraining { get; set; }
        public virtual EmployeesImport? EmployeesImport { get; set; }
    }
}

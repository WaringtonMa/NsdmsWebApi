using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class EmployeesTraining
    {
        public EmployeesTraining()
        {
            EmployeesImportTrainings = new HashSet<EmployeesImportTraining>();
        }

        public long Id { get; set; }
        public string? AccreditationNumber { get; set; }
        public int? CompletedPlanned { get; set; }
        public DateTime? CreateDate { get; set; }
        public double? InterventionCost { get; set; }
        public string? InterventionTitle { get; set; }
        public int? PivotNonPivot { get; set; }
        public string? ProviderName { get; set; }
        public long? WspId { get; set; }
        public long? EtqaId { get; set; }
        public long? InterventionLevelId { get; set; }
        public long? NqfLevelId { get; set; }
        public long? QualificationId { get; set; }
        public long? SourceOfFunding { get; set; }

        public virtual Etqa? Etqa { get; set; }
        public virtual InterventionLevel? InterventionLevel { get; set; }
        public virtual NqfLevel? NqfLevel { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual Funding? SourceOfFundingNavigation { get; set; }
        public virtual Employee? Wsp { get; set; }
        public virtual ICollection<EmployeesImportTraining> EmployeesImportTrainings { get; set; }
    }
}

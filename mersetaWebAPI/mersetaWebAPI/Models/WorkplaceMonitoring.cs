using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkplaceMonitoring
    {
        public WorkplaceMonitoring()
        {
            LearnerInductions = new HashSet<LearnerInduction>();
            LearnerMonitoringSurveys = new HashSet<LearnerMonitoringSurvey>();
            WorkplaceMonitoringMitigations = new HashSet<WorkplaceMonitoringMitigation>();
            WorkplaceMonitoringPurposeOfSiteVisits = new HashSet<WorkplaceMonitoringPurposeOfSiteVisit>();
        }

        public long Id { get; set; }
        public int? AccessTrainingProvider { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? BariersReltingToTraining { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ExposedTrainingRequirements { get; set; }
        public int? ExtendAnyContract { get; set; }
        public int? IndicatedPerRelevantContract { get; set; }
        public int? PossessionN1Certificate { get; set; }
        public int? PrescribedBargainingCouncilWages { get; set; }
        public int? QualifiedMentor { get; set; }
        public int? RecieveToolbox { get; set; }
        public int? RequiredPpe { get; set; }
        public int? SatisfiedTraining { get; set; }
        public int? Status { get; set; }
        public DateTime? VisitDate { get; set; }
        public long? CompanyId { get; set; }
        public long? UserId { get; set; }
        public ulong? IgnoreTranchePayments { get; set; }
        public long? ActiveContractsId { get; set; }

        public virtual ActiveContract? ActiveContracts { get; set; }
        public virtual Company? Company { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<LearnerInduction> LearnerInductions { get; set; }
        public virtual ICollection<LearnerMonitoringSurvey> LearnerMonitoringSurveys { get; set; }
        public virtual ICollection<WorkplaceMonitoringMitigation> WorkplaceMonitoringMitigations { get; set; }
        public virtual ICollection<WorkplaceMonitoringPurposeOfSiteVisit> WorkplaceMonitoringPurposeOfSiteVisits { get; set; }
    }
}

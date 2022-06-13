using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Learnership
    {
        public Learnership()
        {
            CompanyLearners = new HashSet<CompanyLearner>();
            CompanyLearnersChanges = new HashSet<CompanyLearnersChange>();
            CompanyLearnersDetailsChanges = new HashSet<CompanyLearnersDetailsChange>();
            LearnershipUnitStandards = new HashSet<LearnershipUnitStandard>();
            LegacyAssessorLearnerships = new HashSet<LegacyAssessorLearnership>();
            LegacyEmployerWa2Learnerships = new HashSet<LegacyEmployerWa2Learnership>();
            LegacyLearnershipAssessment1s = new HashSet<LegacyLearnershipAssessment1>();
            LegacyLearnerships = new HashSet<LegacyLearnership>();
            LegacyModeratorLearnerships = new HashSet<LegacyModeratorLearnership>();
            LegacyProviderApplicationAlterationAudits = new HashSet<LegacyProviderApplicationAlterationAudit>();
            LegacyProviderLearnerships = new HashSet<LegacyProviderLearnership>();
            TrainingProviderLearnerships = new HashSet<TrainingProviderLearnership>();
            UserLearnerships = new HashSet<UserLearnership>();
            Users = new HashSet<User>();
            WorkPlaceApprovalData = new HashSet<WorkPlaceApprovalDatum>();
            WorkPlaceApprovals = new HashSet<WorkPlaceApproval>();
            WorkplaceMonitoringLearnerInductions = new HashSet<WorkplaceMonitoringLearnerInduction>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? Description { get; set; }
        public string? Code { get; set; }
        public long? AqpId { get; set; }
        public long? EtqaId { get; set; }
        public long? OfoCodesId { get; set; }
        public long? QualificationId { get; set; }
        public string? SmsCode { get; set; }
        public int? Credits { get; set; }
        public string? LearnershipCode { get; set; }
        public long? OrginalQualificationAssignedId { get; set; }
        public long? CreateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? LastUpdateUser { get; set; }

        public virtual Aqp? Aqp { get; set; }
        public virtual Etqa? Etqa { get; set; }
        public virtual OfoCode? OfoCodes { get; set; }
        public virtual SaqaQualification? OrginalQualificationAssigned { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearners { get; set; }
        public virtual ICollection<CompanyLearnersChange> CompanyLearnersChanges { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChanges { get; set; }
        public virtual ICollection<LearnershipUnitStandard> LearnershipUnitStandards { get; set; }
        public virtual ICollection<LegacyAssessorLearnership> LegacyAssessorLearnerships { get; set; }
        public virtual ICollection<LegacyEmployerWa2Learnership> LegacyEmployerWa2Learnerships { get; set; }
        public virtual ICollection<LegacyLearnershipAssessment1> LegacyLearnershipAssessment1s { get; set; }
        public virtual ICollection<LegacyLearnership> LegacyLearnerships { get; set; }
        public virtual ICollection<LegacyModeratorLearnership> LegacyModeratorLearnerships { get; set; }
        public virtual ICollection<LegacyProviderApplicationAlterationAudit> LegacyProviderApplicationAlterationAudits { get; set; }
        public virtual ICollection<LegacyProviderLearnership> LegacyProviderLearnerships { get; set; }
        public virtual ICollection<TrainingProviderLearnership> TrainingProviderLearnerships { get; set; }
        public virtual ICollection<UserLearnership> UserLearnerships { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<WorkPlaceApprovalDatum> WorkPlaceApprovalData { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovals { get; set; }
        public virtual ICollection<WorkplaceMonitoringLearnerInduction> WorkplaceMonitoringLearnerInductions { get; set; }
    }
}

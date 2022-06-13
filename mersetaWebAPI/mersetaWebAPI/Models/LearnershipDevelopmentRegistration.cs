using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LearnershipDevelopmentRegistration
    {
        public LearnershipDevelopmentRegistration()
        {
            InversePreviousLearnership = new HashSet<LearnershipDevelopmentRegistration>();
        }

        public long Id { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? ApprovalEnum { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Department { get; set; }
        public string? Designation { get; set; }
        public string? Guid { get; set; }
        public string? IndustryBodyOrRepresentativeBodyName { get; set; }
        public string? LearnerNumber { get; set; }
        public int? NewLearnership { get; set; }
        public int? PivotNonPivot { get; set; }
        public string? ProfessionalBodyName { get; set; }
        public string? RegistrationNumber { get; set; }
        public long? ApplicantType { get; set; }
        public long? ChamberId { get; set; }
        public long? CompanyId { get; set; }
        public long? InterventionTitleId { get; set; }
        public long? InterventionTypeId { get; set; }
        public long? NqfAlignedId { get; set; }
        public long? OfoCodesId { get; set; }
        public long? PreviousLearnershipId { get; set; }
        public long? QualificationId { get; set; }
        public long? SkillsIdentificationId { get; set; }
        public long? SkillsProgramId { get; set; }
        public long? SkillsSetId { get; set; }
        public long? UnitStandardId { get; set; }
        public long? UserId { get; set; }

        public virtual ApplicantType? ApplicantTypeNavigation { get; set; }
        public virtual Chamber? Chamber { get; set; }
        public virtual Company? Company { get; set; }
        public virtual InterventionTitle? InterventionTitle { get; set; }
        public virtual InterventionType? InterventionType { get; set; }
        public virtual YesNoLookup? NqfAligned { get; set; }
        public virtual OfoCode? OfoCodes { get; set; }
        public virtual LearnershipDevelopmentRegistration? PreviousLearnership { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual SkillsIdentification? SkillsIdentification { get; set; }
        public virtual SkillsProgram? SkillsProgram { get; set; }
        public virtual SkillsSet? SkillsSet { get; set; }
        public virtual SaqaUnitstandard? UnitStandard { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<LearnershipDevelopmentRegistration> InversePreviousLearnership { get; set; }
    }
}

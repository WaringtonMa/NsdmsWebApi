using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SkillsRegistration
    {
        public SkillsRegistration()
        {
            SkillsRegistrationQualificationUnitStandards = new HashSet<SkillsRegistrationQualificationUnitStandard>();
            SkillsRegistrationUnitStandards = new HashSet<SkillsRegistrationUnitStandard>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? FitCareer { get; set; }
        public string? ProposedTitle { get; set; }
        public string? ResearchSummary { get; set; }
        public int? SkillsType { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public long? CompanyId { get; set; }
        public long? OfoCodesId { get; set; }
        public long? QualificationId { get; set; }
        public long? SkillsIdentificationId { get; set; }
        public string? HowWillAssist { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? ApprovalEnum { get; set; }
        public long? UserId { get; set; }
        public int? IntergratedSummativeAssesment { get; set; }
        public int? LearnerOnCompletionHaveEmployableSkill { get; set; }
        public int? LearningAssumedToBeInPlace { get; set; }
        public int? SectorsIdentified { get; set; }
        public int? SequenceOfUsAddressed { get; set; }
        public int? SkillsProgrammesArticulate { get; set; }
        public int? TitleOfTheSkillsProgrammeSkillsSetAddressing { get; set; }
        public int? UsPartOfNqf { get; set; }
        public int? AboveNqfLevel1 { get; set; }
        public int? AlignedToAnExistingOrganizingFramework { get; set; }
        public int? HasNqfBeenDetermined { get; set; }
        public string? AmendedTitle { get; set; }
        public DateTime? LastDateForEnrolment { get; set; }
        public string? RegistrationNumber { get; set; }
        public long? ReviewCommitteeMeetingId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual OfoCode? OfoCodes { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual ReviewCommitteeMeeting? ReviewCommitteeMeeting { get; set; }
        public virtual SkillsIdentification? SkillsIdentification { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<SkillsRegistrationQualificationUnitStandard> SkillsRegistrationQualificationUnitStandards { get; set; }
        public virtual ICollection<SkillsRegistrationUnitStandard> SkillsRegistrationUnitStandards { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SummativeAssessmentReport
    {
        public SummativeAssessmentReport()
        {
            CompletionLetters = new HashSet<CompletionLetter>();
            NonSetaQualificationsCompletions = new HashSet<NonSetaQualificationsCompletion>();
            SummativeAssessmentReportUnitStandards = new HashSet<SummativeAssessmentReportUnitStandard>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? PivotNonPivot { get; set; }
        public long? CompanyLearnersId { get; set; }
        public long? InterventionLevelId { get; set; }
        public long? InterventionTypeId { get; set; }
        public long? NonSetaQualificationsCompletionId { get; set; }
        public long? NqfAlignedId { get; set; }
        public long? NqfLevelsId { get; set; }
        public long? QualificationId { get; set; }
        public long? SkillsProgramId { get; set; }
        public long? SkillsSetId { get; set; }
        public long? TrainingProviderVerficationId { get; set; }
        public long? UnitStandardId { get; set; }
        public long? UsersId { get; set; }

        public virtual CompanyLearner? CompanyLearners { get; set; }
        public virtual InterventionLevel? InterventionLevel { get; set; }
        public virtual InterventionType? InterventionType { get; set; }
        public virtual NonSetaQualificationsCompletion? NonSetaQualificationsCompletion { get; set; }
        public virtual YesNoLookup? NqfAligned { get; set; }
        public virtual NqfLevel? NqfLevels { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual SkillsProgram? SkillsProgram { get; set; }
        public virtual SkillsSet? SkillsSet { get; set; }
        public virtual TrainingProviderVerfication? TrainingProviderVerfication { get; set; }
        public virtual SaqaUnitstandard? UnitStandard { get; set; }
        public virtual User? Users { get; set; }
        public virtual ICollection<CompletionLetter> CompletionLetters { get; set; }
        public virtual ICollection<NonSetaQualificationsCompletion> NonSetaQualificationsCompletions { get; set; }
        public virtual ICollection<SummativeAssessmentReportUnitStandard> SummativeAssessmentReportUnitStandards { get; set; }
    }
}

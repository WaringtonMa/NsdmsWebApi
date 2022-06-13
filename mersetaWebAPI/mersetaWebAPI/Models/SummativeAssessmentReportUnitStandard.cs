using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SummativeAssessmentReportUnitStandard
    {
        public long Id { get; set; }
        public DateTime? AssesmentDate { get; set; }
        public int? CompetenceEnum { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModerationDate { get; set; }
        public int? UnitStandardTypeEnum { get; set; }
        public long? AssessorApplicationId { get; set; }
        public long? AssessorUserId { get; set; }
        public long? CompanyLearnersId { get; set; }
        public long? LegacyAssessorAccredidationId { get; set; }
        public long? LegacyModeratorAccredidationId { get; set; }
        public long? ModeratorApplicationId { get; set; }
        public long? ModeratorUserId { get; set; }
        public long? QualificationId { get; set; }
        public long? SummativeAssessmentReportId { get; set; }
        public long? UnitStandardsId { get; set; }

        public virtual AssessorModeratorApplication? AssessorApplication { get; set; }
        public virtual User? AssessorUser { get; set; }
        public virtual CompanyLearner? CompanyLearners { get; set; }
        public virtual LegacyAssessorAccreditation? LegacyAssessorAccredidation { get; set; }
        public virtual LegacyModeratorAccreditation? LegacyModeratorAccredidation { get; set; }
        public virtual AssessorModeratorApplication? ModeratorApplication { get; set; }
        public virtual User? ModeratorUser { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual SummativeAssessmentReport? SummativeAssessmentReport { get; set; }
        public virtual SaqaUnitstandard? UnitStandards { get; set; }
    }
}

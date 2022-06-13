using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyModeratorAccreditation
    {
        public LegacyModeratorAccreditation()
        {
            AssessorModeratorApplications = new HashSet<AssessorModeratorApplication>();
            SummativeAssessmentReportUnitStandards = new HashSet<SummativeAssessmentReportUnitStandard>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? AssessorRegNo { get; set; }
        public string? AssessorType { get; set; }
        public string? DecisionNumber { get; set; }
        public string? FirstName { get; set; }
        public string? IdNo { get; set; }
        public string? LastDateChanged { get; set; }
        public string? ModeratorRegEndDate { get; set; }
        public string? ModeratorRegStartDate { get; set; }
        public string? ModeratorStatusDesc { get; set; }
        public string? ModeratorStatusEffectiveDate { get; set; }
        public string? ReviewCommitteeDate { get; set; }
        public string? SRefNo { get; set; }
        public string? Surname { get; set; }
        public string? TitleDesc { get; set; }
        public ulong? ValidRsaIdNumber { get; set; }
        public ulong? AppearsOnHomeAffairsData { get; set; }
        public string? ModeratorRegNo { get; set; }
        public ulong? Processed { get; set; }
        public string? ScopeYn { get; set; }
        public ulong? AliveOnHomeAffairsData { get; set; }
        public ulong? OnPersonsFile { get; set; }
        public ulong? OnPersonsFileAlternativeId { get; set; }
        public ulong? ValidStatus { get; set; }

        public virtual ICollection<AssessorModeratorApplication> AssessorModeratorApplications { get; set; }
        public virtual ICollection<SummativeAssessmentReportUnitStandard> SummativeAssessmentReportUnitStandards { get; set; }
    }
}

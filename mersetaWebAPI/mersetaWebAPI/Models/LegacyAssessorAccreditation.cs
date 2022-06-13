using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyAssessorAccreditation
    {
        public LegacyAssessorAccreditation()
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
        public string? AssessorRegEndDate { get; set; }
        public string? AssessorRegNo { get; set; }
        public string? AssessorRegStartDate { get; set; }
        public string? AssessorStatusDesc { get; set; }
        public string? AssessorStatusEffectiveDate { get; set; }
        public string? AssessorType { get; set; }
        public string? DecisionNumber { get; set; }
        public string? FirstName { get; set; }
        public string? IdNo { get; set; }
        public string? LastDateChanged { get; set; }
        public ulong? Processed { get; set; }
        public string? ReviewCommitteeDate { get; set; }
        public string? SRefNo { get; set; }
        public string? Surname { get; set; }
        public string? TitleDesc { get; set; }
        public ulong? ValidRsaIdNumber { get; set; }
        public ulong? AppearsOnHomeAffairsData { get; set; }
        public string? Comments { get; set; }
        public string? EtqaSetaDesc { get; set; }
        public ulong? AliveOnHomeAffairsData { get; set; }
        public ulong? OnPersonsFile { get; set; }
        public ulong? OnPersonsFileAlternativeId { get; set; }
        public ulong? ValidStatus { get; set; }
        public string? AssessorStatusBeforeAlteration { get; set; }

        public virtual ICollection<AssessorModeratorApplication> AssessorModeratorApplications { get; set; }
        public virtual ICollection<SummativeAssessmentReportUnitStandard> SummativeAssessmentReportUnitStandards { get; set; }
    }
}

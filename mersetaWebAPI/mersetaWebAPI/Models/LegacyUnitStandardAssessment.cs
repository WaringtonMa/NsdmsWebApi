using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyUnitStandardAssessment
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? AgreementUnitStdStatusDesc { get; set; }
        public string? AssessorFirstName { get; set; }
        public string? AssessorId { get; set; }
        public string? AssessorRegNo { get; set; }
        public string? AssessorSurname { get; set; }
        public string? DtAssessment { get; set; }
        public string? FirstName { get; set; }
        public string? HologramNumber { get; set; }
        public string? IdNo { get; set; }
        public string? LearnerUsStatusDesc { get; set; }
        public string? MiddleNames { get; set; }
        public string? PkiLearnerAssessmentId { get; set; }
        public string? SRefNo { get; set; }
        public string? Surname { get; set; }
        public string? UnitStdCode { get; set; }
        public string? UnitStdDesc { get; set; }
        public ulong? AppearsOnHomeAffairsData { get; set; }
        public ulong? Processed { get; set; }
        public ulong? ValidRsaIdNumber { get; set; }
        public long? UnitStandardId { get; set; }
        public ulong? AppearsAccreditationData { get; set; }
        public long? LegacyUnitStandardFlatId { get; set; }

        public virtual SaqaUnitstandard? UnitStandard { get; set; }
    }
}

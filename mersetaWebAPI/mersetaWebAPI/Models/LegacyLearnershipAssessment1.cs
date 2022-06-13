using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyLearnershipAssessment1
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? AgreementRefNo { get; set; }
        public string? AgreementStatusDesc { get; set; }
        public string? AgreementUnitStdStatusDesc { get; set; }
        public ulong? AppearsAccreditationData { get; set; }
        public ulong? AppearsOnHomeAffairsData { get; set; }
        public string? AssessorFirstName { get; set; }
        public string? AssessorId { get; set; }
        public string? AssessorRegNo { get; set; }
        public string? AssessorSurname { get; set; }
        public string? DtAssessment { get; set; }
        public string? FirstName { get; set; }
        public string? HologramNumber { get; set; }
        public string? LearnerId { get; set; }
        public string? LearnershipCode { get; set; }
        public string? LearnershipTitle { get; set; }
        public string? LShipCode { get; set; }
        public string? MiddleNames { get; set; }
        public string? PkiLearnerAssessmentId { get; set; }
        public string? Surname { get; set; }
        public string? UnitStdCode { get; set; }
        public string? UnitStdDesc { get; set; }
        public ulong? ValidRsaIdNumber { get; set; }
        public long? LearnershipId { get; set; }

        public virtual Learnership? Learnership { get; set; }
    }
}

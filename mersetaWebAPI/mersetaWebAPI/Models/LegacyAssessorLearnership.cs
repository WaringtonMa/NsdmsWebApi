using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyAssessorLearnership
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? AlternateIdNo { get; set; }
        public ulong? ApplicationSubmited { get; set; }
        public string? AssessorFirstRegDate { get; set; }
        public string? AssessorId { get; set; }
        public string? AssessorRegEndDate { get; set; }
        public string? AssessorRegNo { get; set; }
        public string? AssessorRegStartDate { get; set; }
        public string? AssessorStatusDesc { get; set; }
        public string? FirstName { get; set; }
        public string? LearnershipCode { get; set; }
        public string? LshipCode { get; set; }
        public string? MiddleNames { get; set; }
        public ulong? Processed { get; set; }
        public string? SaqaUnitStandardId { get; set; }
        public string? Surname { get; set; }
        public ulong? ValidRsaIdNumber { get; set; }
        public long? LearnershipId { get; set; }

        public virtual Learnership? Learnership { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyModeratorLearnership
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? AlternateId { get; set; }
        public ulong? ApplicationSubmited { get; set; }
        public string? AssessorId { get; set; }
        public string? FirstName { get; set; }
        public string? LearnershipCode { get; set; }
        public string? LShipCode { get; set; }
        public string? MiddleNames { get; set; }
        public string? ModeratorFirstRegDate { get; set; }
        public string? ModeratorRegEndDate { get; set; }
        public string? ModeratorRegNo { get; set; }
        public string? ModeratorRegStartDate { get; set; }
        public string? ModeratorStatusDesc { get; set; }
        public ulong? Processed { get; set; }
        public string? SaqaUnitStandardId { get; set; }
        public string? Surname { get; set; }
        public ulong? ValidRsaIdNumber { get; set; }
        public long? LearnershipId { get; set; }
        public long? QualificationId { get; set; }

        public virtual Learnership? Learnership { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
    }
}

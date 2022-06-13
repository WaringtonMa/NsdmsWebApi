using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyModeratorUnitStandard
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? AlternateIdNo { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleNames { get; set; }
        public string? ModeratorFirstRegDate { get; set; }
        public string? ModeratorId { get; set; }
        public string? ModeratorRegEndDate { get; set; }
        public string? ModeratorRegNo { get; set; }
        public string? ModeratorRegStartDate { get; set; }
        public string? ModeratorStatusDesc { get; set; }
        public string? QualCode { get; set; }
        public string? Surname { get; set; }
        public string? UnitStdCode { get; set; }
        public ulong? Processed { get; set; }
        public ulong? ValidRsaIdNumber { get; set; }
        public long? UnitStandardId { get; set; }
        public ulong? AppearsOnHomeAffairsData { get; set; }
        public ulong? ApplicationSubmited { get; set; }
        public string? Comments { get; set; }
        public ulong? AppearsAccreditationData { get; set; }

        public virtual SaqaUnitstandard? UnitStandard { get; set; }
    }
}

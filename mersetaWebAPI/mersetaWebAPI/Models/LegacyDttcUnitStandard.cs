using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyDttcUnitStandard
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? AccreditationEndDate { get; set; }
        public string? AccreditationStartDate { get; set; }
        public string? DttcStatus { get; set; }
        public string? LinkedSdl { get; set; }
        public string? OrganisationNameLegal { get; set; }
        public string? OrganisationNameTrade { get; set; }
        public ulong? Processed { get; set; }
        public string? SRefNo { get; set; }
        public string? SaqaUsId { get; set; }
        public string? SdlNo { get; set; }
        public string? UnitStdDesc { get; set; }
        public ulong? ValidRsaIdNumber { get; set; }
        public long? UnitStandardId { get; set; }

        public virtual SaqaUnitstandard? UnitStandard { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyDttcQualification
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? AccreditationEndDate { get; set; }
        public string? AccreditationStartSate { get; set; }
        public ulong? AppearsOnHomeAffairsData { get; set; }
        public string? DttcStatus { get; set; }
        public string? LinkedSdl { get; set; }
        public string? OrganisationNameLegal { get; set; }
        public string? OrganisationNameTrade { get; set; }
        public ulong? Processed { get; set; }
        public string? QualCode { get; set; }
        public string? SdlNo { get; set; }
        public ulong? ValidRsaIdNumber { get; set; }
        public long? QualificationId { get; set; }

        public virtual SaqaQualification? Qualification { get; set; }
    }
}

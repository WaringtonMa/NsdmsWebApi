using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LegacyDttcSkillsProgramme
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
        public string? SProgrammeDesc { get; set; }
        public string? SRefNo { get; set; }
        public string? SaqaUsId { get; set; }
        public string? SdlNo { get; set; }
        public string? SkillsProgrammeRegistrationNumber { get; set; }
        public ulong? ValidRsaIdNumber { get; set; }
        public long? SkillsProgramId { get; set; }

        public virtual SkillsProgram? SkillsProgram { get; set; }
    }
}

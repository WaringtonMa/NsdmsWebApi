using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkPlaceApprovalDatum
    {
        public long Id { get; set; }
        public string? AccreditationStartDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? LearnershipCode { get; set; }
        public string? OfoCode { get; set; }
        public string? QualificationCode { get; set; }
        public string? SProgrammeCode { get; set; }
        public string? SdlNumber { get; set; }
        public long? CompanyId { get; set; }
        public long? LearnershipId { get; set; }
        public long? OfoCodesId { get; set; }
        public long? QualificationId { get; set; }
        public long? SkillsProgramId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual Learnership? Learnership { get; set; }
        public virtual OfoCode? OfoCodes { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual SkillsProgram? SkillsProgram { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SdpType
    {
        public SdpType()
        {
            SdpCompanies = new HashSet<SdpCompany>();
            SdpCompanyActionCurrentDesignations = new HashSet<SdpCompanyAction>();
            SdpCompanyActionNewDesignations = new HashSet<SdpCompanyAction>();
            SdpCompanyHistories = new HashSet<SdpCompanyHistory>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public ulong? ActionLearners { get; set; }
        public ulong? ActionSdpInformation { get; set; }
        public string? Description { get; set; }
        public ulong? RegisterLearners { get; set; }
        public ulong? ViewLearners { get; set; }
        public ulong? ViewSdpInformation { get; set; }
        public long? DesignationId { get; set; }
        public ulong? ActionTradeTestCentreAssessors { get; set; }
        public ulong? ViewTradeTestCentreAssessors { get; set; }
        public ulong? AlterAssModLinked { get; set; }
        public ulong? AlterSdpsLinked { get; set; }
        public ulong? AlterSiteInfo { get; set; }

        public virtual Designation? Designation { get; set; }
        public virtual ICollection<SdpCompany> SdpCompanies { get; set; }
        public virtual ICollection<SdpCompanyAction> SdpCompanyActionCurrentDesignations { get; set; }
        public virtual ICollection<SdpCompanyAction> SdpCompanyActionNewDesignations { get; set; }
        public virtual ICollection<SdpCompanyHistory> SdpCompanyHistories { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class RelationshipToCompany
    {
        public RelationshipToCompany()
        {
            SdfCompanies = new HashSet<SdfCompany>();
            SdfCompanyHistories = new HashSet<SdfCompanyHistory>();
            SdpCompanies = new HashSet<SdpCompany>();
            SdpCompanyHistories = new HashSet<SdpCompanyHistory>();
            TrainingProviderApplications = new HashSet<TrainingProviderApplication>();
            WspSdfCompanyHistories = new HashSet<WspSdfCompanyHistory>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? Description { get; set; }
        public string? SmsCode { get; set; }

        public virtual ICollection<SdfCompany> SdfCompanies { get; set; }
        public virtual ICollection<SdfCompanyHistory> SdfCompanyHistories { get; set; }
        public virtual ICollection<SdpCompany> SdpCompanies { get; set; }
        public virtual ICollection<SdpCompanyHistory> SdpCompanyHistories { get; set; }
        public virtual ICollection<TrainingProviderApplication> TrainingProviderApplications { get; set; }
        public virtual ICollection<WspSdfCompanyHistory> WspSdfCompanyHistories { get; set; }
    }
}

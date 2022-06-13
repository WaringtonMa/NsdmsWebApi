using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Chamber
    {
        public Chamber()
        {
            Companies = new HashSet<Company>();
            CompanyHistories = new HashSet<CompanyHistory>();
            LearnershipDevelopmentRegistrations = new HashSet<LearnershipDevelopmentRegistration>();
            SicCodes = new HashSet<SicCode>();
            WspCompanyHistories = new HashSet<WspCompanyHistory>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? Description { get; set; }
        public string? Code { get; set; }
        public int? GpVendorClass { get; set; }
        public string? SmsCode { get; set; }
        public string? GpAccountNumberCode { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<CompanyHistory> CompanyHistories { get; set; }
        public virtual ICollection<LearnershipDevelopmentRegistration> LearnershipDevelopmentRegistrations { get; set; }
        public virtual ICollection<SicCode> SicCodes { get; set; }
        public virtual ICollection<WspCompanyHistory> WspCompanyHistories { get; set; }
    }
}

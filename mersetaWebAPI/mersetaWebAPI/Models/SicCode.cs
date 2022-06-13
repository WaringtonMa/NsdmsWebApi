using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SicCode
    {
        public SicCode()
        {
            Companies = new HashSet<Company>();
            CompanyHistories = new HashSet<CompanyHistory>();
            NonSetaCompanies = new HashSet<NonSetaCompany>();
            WspCompanyHistories = new HashSet<WspCompanyHistory>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? Description { get; set; }
        public string? Code { get; set; }
        public long? ChamberId { get; set; }
        public string? SmsCode { get; set; }

        public virtual Chamber? Chamber { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<CompanyHistory> CompanyHistories { get; set; }
        public virtual ICollection<NonSetaCompany> NonSetaCompanies { get; set; }
        public virtual ICollection<WspCompanyHistory> WspCompanyHistories { get; set; }
    }
}

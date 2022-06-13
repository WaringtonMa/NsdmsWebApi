using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Designation
    {
        public Designation()
        {
            CompanyUsers = new HashSet<CompanyUser>();
            CompanyUsersHistories = new HashSet<CompanyUsersHistory>();
            NonSetaCompanyUsers = new HashSet<NonSetaCompanyUser>();
            SdpTypes = new HashSet<SdpType>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? Description { get; set; }
        public string? Code { get; set; }
        public string? SmsCode { get; set; }
        public ulong? SdpDesignation { get; set; }

        public virtual ICollection<CompanyUser> CompanyUsers { get; set; }
        public virtual ICollection<CompanyUsersHistory> CompanyUsersHistories { get; set; }
        public virtual ICollection<NonSetaCompanyUser> NonSetaCompanyUsers { get; set; }
        public virtual ICollection<SdpType> SdpTypes { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyUserPosition
    {
        public CompanyUserPosition()
        {
            CompanyUsers = new HashSet<CompanyUser>();
            CompanyUsersHistories = new HashSet<CompanyUsersHistory>();
            NonSetaCompanyUsers = new HashSet<NonSetaCompanyUser>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<CompanyUser> CompanyUsers { get; set; }
        public virtual ICollection<CompanyUsersHistory> CompanyUsersHistories { get; set; }
        public virtual ICollection<NonSetaCompanyUser> NonSetaCompanyUsers { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DisabilityRating
    {
        public DisabilityRating()
        {
            CompanyLearnersTradeTests = new HashSet<CompanyLearnersTradeTest>();
            Users = new HashSet<User>();
            UsersDisabilities = new HashSet<UsersDisability>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? Description { get; set; }
        public long? DisabilityStatus { get; set; }

        public virtual DisabilityStatus? DisabilityStatusNavigation { get; set; }
        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTests { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<UsersDisability> UsersDisabilities { get; set; }
    }
}

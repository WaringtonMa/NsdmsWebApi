using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class UnionMembership
    {
        public UnionMembership()
        {
            CompanyLearners = new HashSet<CompanyLearner>();
            CompanyLearnersDetailsChanges = new HashSet<CompanyLearnersDetailsChange>();
            Users = new HashSet<User>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<CompanyLearner> CompanyLearners { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChanges { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}

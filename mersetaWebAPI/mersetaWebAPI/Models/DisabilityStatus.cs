using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DisabilityStatus
    {
        public DisabilityStatus()
        {
            CompanyLearnersTradeTests = new HashSet<CompanyLearnersTradeTest>();
            DisabilityRatings = new HashSet<DisabilityRating>();
            Employees = new HashSet<Employee>();
            EmployeesHistories = new HashSet<EmployeesHistory>();
            Learners = new HashSet<Learner>();
            MandatoryGrantDetailArchives = new HashSet<MandatoryGrantDetailArchive>();
            MandatoryGrantDetails = new HashSet<MandatoryGrantDetail>();
            MandatoryGrants = new HashSet<MandatoryGrant>();
            UserChangeRequests = new HashSet<UserChangeRequest>();
            Users = new HashSet<User>();
            UsersDisabilities = new HashSet<UsersDisability>();
            WspCompanyEmployeesHistories = new HashSet<WspCompanyEmployeesHistory>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public string? SmsCode { get; set; }
        public ulong? CanSelect { get; set; }
        public int? SetmisDisabilityIndicator { get; set; }

        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTests { get; set; }
        public virtual ICollection<DisabilityRating> DisabilityRatings { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<EmployeesHistory> EmployeesHistories { get; set; }
        public virtual ICollection<Learner> Learners { get; set; }
        public virtual ICollection<MandatoryGrantDetailArchive> MandatoryGrantDetailArchives { get; set; }
        public virtual ICollection<MandatoryGrantDetail> MandatoryGrantDetails { get; set; }
        public virtual ICollection<MandatoryGrant> MandatoryGrants { get; set; }
        public virtual ICollection<UserChangeRequest> UserChangeRequests { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<UsersDisability> UsersDisabilities { get; set; }
        public virtual ICollection<WspCompanyEmployeesHistory> WspCompanyEmployeesHistories { get; set; }
    }
}

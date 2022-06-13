using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class OrganisedLabourUnion
    {
        public OrganisedLabourUnion()
        {
            Companies = new HashSet<Company>();
            CompanyHistories = new HashSet<CompanyHistory>();
            CompanyLearners = new HashSet<CompanyLearner>();
            CompanyLearnersDetailsChanges = new HashSet<CompanyLearnersDetailsChange>();
            TrainingComitteeHostories = new HashSet<TrainingComitteeHostory>();
            TrainingComittees = new HashSet<TrainingComittee>();
            Users = new HashSet<User>();
            WspChecklists = new HashSet<WspChecklist>();
            WspCompanyHistories = new HashSet<WspCompanyHistory>();
            WspCompanyTrainingComitteeHistories = new HashSet<WspCompanyTrainingComitteeHistory>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? Description { get; set; }
        public string? SmsCode { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<CompanyHistory> CompanyHistories { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearners { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChanges { get; set; }
        public virtual ICollection<TrainingComitteeHostory> TrainingComitteeHostories { get; set; }
        public virtual ICollection<TrainingComittee> TrainingComittees { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<WspChecklist> WspChecklists { get; set; }
        public virtual ICollection<WspCompanyHistory> WspCompanyHistories { get; set; }
        public virtual ICollection<WspCompanyTrainingComitteeHistory> WspCompanyTrainingComitteeHistories { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Title
    {
        public Title()
        {
            TrainingComitteeHostories = new HashSet<TrainingComitteeHostory>();
            TrainingComittees = new HashSet<TrainingComittee>();
            UserChangeRequests = new HashSet<UserChangeRequest>();
            Users = new HashSet<User>();
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

        public virtual ICollection<TrainingComitteeHostory> TrainingComitteeHostories { get; set; }
        public virtual ICollection<TrainingComittee> TrainingComittees { get; set; }
        public virtual ICollection<UserChangeRequest> UserChangeRequests { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<WspCompanyTrainingComitteeHistory> WspCompanyTrainingComitteeHistories { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class AdministrationOfApqLearner
    {
        public AdministrationOfApqLearner()
        {
            ClQualificationAchievements = new HashSet<ClQualificationAchievement>();
            CompanyLearnersAchievementStatusEisas = new HashSet<CompanyLearnersAchievementStatusEisa>();
        }

        public long Id { get; set; }
        public long? AdministrationOfAqpId { get; set; }
        public long? CompanyLearnersId { get; set; }

        public virtual AdministrationOfApq? AdministrationOfAqp { get; set; }
        public virtual CompanyLearner? CompanyLearners { get; set; }
        public virtual ICollection<ClQualificationAchievement> ClQualificationAchievements { get; set; }
        public virtual ICollection<CompanyLearnersAchievementStatusEisa> CompanyLearnersAchievementStatusEisas { get; set; }
    }
}

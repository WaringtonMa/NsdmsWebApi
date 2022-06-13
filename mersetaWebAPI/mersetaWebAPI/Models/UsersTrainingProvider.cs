using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class UsersTrainingProvider
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? InterventionStartDate { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string? TrainingDescription { get; set; }
        public string? TrainingDurationDescription { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? CompanyId { get; set; }
        public long? UserId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual User? User { get; set; }
    }
}

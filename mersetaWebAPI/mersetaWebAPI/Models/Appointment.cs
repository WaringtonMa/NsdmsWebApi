using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Appointment
    {
        public Appointment()
        {
            CompanyLearners = new HashSet<CompanyLearner>();
            CompanyLearnersDetailsChanges = new HashSet<CompanyLearnersDetailsChange>();
        }

        public long Id { get; set; }
        public string? AdditionalInfo { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DateAndTime { get; set; }
        public string? Note { get; set; }
        public int? Status { get; set; }
        public string? Title { get; set; }
        public string? Venue { get; set; }
        public long? AppointmentWithUserId { get; set; }
        public long? UserId { get; set; }

        public virtual User? AppointmentWithUser { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearners { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChanges { get; set; }
    }
}

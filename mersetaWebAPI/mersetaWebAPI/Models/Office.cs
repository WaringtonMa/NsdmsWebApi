using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Office
    {
        public Office()
        {
            Users = new HashSet<User>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? Description { get; set; }
        public string? ContactNumber { get; set; }
        public string? Email { get; set; }
        public string? FaxNumber { get; set; }
        public long? PhysicalAddressId { get; set; }
        public string? SmsCode { get; set; }
        public string? ContactPerson { get; set; }
        public string? ContactPersonEmail { get; set; }

        public virtual Address? PhysicalAddress { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}

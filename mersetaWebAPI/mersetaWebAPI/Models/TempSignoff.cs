using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class TempSignoff
    {
        public TempSignoff()
        {
            Signoffs = new HashSet<Signoff>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Email { get; set; }
        public string FirstName { get; set; } = null!;
        public string? IdNumber { get; set; }
        public int? IdPassportSelection { get; set; }
        public DateTime? LastActionDate { get; set; }
        public string LastName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string? PassportNumber { get; set; }
        public long? RefToSignOffFlat { get; set; }
        public long? LastActionUser { get; set; }

        public virtual User? LastActionUserNavigation { get; set; }
        public virtual ICollection<Signoff> Signoffs { get; set; }
    }
}

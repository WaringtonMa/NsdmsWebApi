using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SkillsProgramHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public int? Credits { get; set; }
        public string? Description { get; set; }
        public int? Duration { get; set; }
        public string? ProgrammeId { get; set; }
        public long? NetqaId { get; set; }
        public long? QualificationId { get; set; }
        public string? RegistrationNumber { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

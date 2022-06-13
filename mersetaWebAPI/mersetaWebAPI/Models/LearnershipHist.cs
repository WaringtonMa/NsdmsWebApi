using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class LearnershipHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public string? SetmisCode { get; set; }
        public int? Credits { get; set; }
        public string? Description { get; set; }
        public string? LearnershipCode { get; set; }
        public long? AqpId { get; set; }
        public long? EtqaId { get; set; }
        public long? OfoCodesId { get; set; }
        public long? OrginalQualificationAssignedId { get; set; }
        public long? QualificationId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

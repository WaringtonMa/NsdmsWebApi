using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CoursewareDistibution
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? ModulesId { get; set; }
        public long? UnitStandardsId { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? ApprovalEnum { get; set; }
        public long? CompanyId { get; set; }
        public long? UserId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual Module? Modules { get; set; }
        public virtual SaqaUnitstandard? UnitStandards { get; set; }
        public virtual User? User { get; set; }
    }
}

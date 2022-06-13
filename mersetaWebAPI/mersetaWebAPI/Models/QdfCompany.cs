using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class QdfCompany
    {
        public QdfCompany()
        {
            QdfCompanyUsers = new HashSet<QdfCompanyUser>();
        }

        public long Id { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? ApprovalEnum { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ReviewDate { get; set; }
        public long? CompanyId { get; set; }
        public long QualificationsCurriculumDevelopmentId { get; set; }
        public long? ReviewUserId { get; set; }
        public long? UserId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual QualificationsCurriculumDevelopment QualificationsCurriculumDevelopment { get; set; } = null!;
        public virtual User? ReviewUser { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<QdfCompanyUser> QdfCompanyUsers { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SmeQualification
    {
        public SmeQualification()
        {
            CompanyLearners = new HashSet<CompanyLearner>();
            InverseSmeQualificationsParent = new HashSet<SmeQualification>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Status { get; set; }
        public long? QualificationId { get; set; }
        public long? SitesSmeId { get; set; }
        public ulong? Acepted { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public long? ApproveUserId { get; set; }
        public long? SmeQualificationsParentId { get; set; }

        public virtual User? ApproveUser { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual SitesSme? SitesSme { get; set; }
        public virtual SmeQualification? SmeQualificationsParent { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearners { get; set; }
        public virtual ICollection<SmeQualification> InverseSmeQualificationsParent { get; set; }
    }
}

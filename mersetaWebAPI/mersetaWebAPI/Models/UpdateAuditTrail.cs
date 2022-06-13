using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class UpdateAuditTrail
    {
        public UpdateAuditTrail()
        {
            UpdateAuditTrailChanges = new HashSet<UpdateAuditTrailChange>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? BankingDetailsId { get; set; }
        public long? CompanyId { get; set; }
        public long? UsersId { get; set; }

        public virtual BankingDetail? BankingDetails { get; set; }
        public virtual Company? Company { get; set; }
        public virtual User? Users { get; set; }
        public virtual ICollection<UpdateAuditTrailChange> UpdateAuditTrailChanges { get; set; }
    }
}

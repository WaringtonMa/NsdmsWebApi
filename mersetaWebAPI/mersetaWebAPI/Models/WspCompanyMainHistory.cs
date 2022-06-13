using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WspCompanyMainHistory
    {
        public WspCompanyMainHistory()
        {
            WspCompanyAddressHistories = new HashSet<WspCompanyAddressHistory>();
            WspCompanyEmployeesHistories = new HashSet<WspCompanyEmployeesHistory>();
            WspCompanyHistories = new HashSet<WspCompanyHistory>();
            WspCompanyTrainingComitteeHistories = new HashSet<WspCompanyTrainingComitteeHistory>();
            WspSdfCompanyHistories = new HashSet<WspSdfCompanyHistory>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? CompanyId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual ICollection<WspCompanyAddressHistory> WspCompanyAddressHistories { get; set; }
        public virtual ICollection<WspCompanyEmployeesHistory> WspCompanyEmployeesHistories { get; set; }
        public virtual ICollection<WspCompanyHistory> WspCompanyHistories { get; set; }
        public virtual ICollection<WspCompanyTrainingComitteeHistory> WspCompanyTrainingComitteeHistories { get; set; }
        public virtual ICollection<WspSdfCompanyHistory> WspSdfCompanyHistories { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class GpGrantBatchListHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public string? AdditionalRejectionReason { get; set; }
        public int? ApprovalEnum { get; set; }
        public string? BatchDescription { get; set; }
        public int? BatchNumber { get; set; }
        public ulong? CompletedGpTransation { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DateCompletedGpTransation { get; set; }
        public DateTime? DateFinalApproved { get; set; }
        public DateTime? FromDatePeriod { get; set; }
        public double? OriginalAmount { get; set; }
        public DateTime? SarsFromDatePeriod { get; set; }
        public DateTime? SarsToDatePeriod { get; set; }
        public DateTime? ToDatePeriod { get; set; }
        public int? WspType { get; set; }
        public long? ApproveUserId { get; set; }
        public long? CreateUsersId { get; set; }
        public DateTime? DateValidiationRun { get; set; }
        public ulong? ValidiationRun { get; set; }
        public ulong? ValidiationUnderway { get; set; }
        public int? FilteredSchemeYear { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

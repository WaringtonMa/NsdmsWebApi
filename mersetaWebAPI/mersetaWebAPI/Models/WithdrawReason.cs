using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WithdrawReason
    {
        public WithdrawReason()
        {
            WithdrawReasonMultipleSelections = new HashSet<WithdrawReasonMultipleSelection>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? Description { get; set; }
        public ulong? ForCrm { get; set; }
        public ulong? ForExecutive { get; set; }
        public ulong? ForManager { get; set; }
        public int? ForProcess { get; set; }
        public ulong? ForSeniorManager { get; set; }
        public ulong? ForClo { get; set; }
        public string? HowTo { get; set; }
        public ulong? SoftDeleted { get; set; }

        public virtual ICollection<WithdrawReasonMultipleSelection> WithdrawReasonMultipleSelections { get; set; }
    }
}

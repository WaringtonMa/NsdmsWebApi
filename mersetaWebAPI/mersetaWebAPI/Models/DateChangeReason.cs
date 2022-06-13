using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DateChangeReason
    {
        public DateChangeReason()
        {
            DateChangeMultipleSelections = new HashSet<DateChangeMultipleSelection>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? Description { get; set; }
        public ulong? ForManagerSelection { get; set; }
        public int? ForProcess { get; set; }

        public virtual ICollection<DateChangeMultipleSelection> DateChangeMultipleSelections { get; set; }
    }
}

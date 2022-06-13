using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DhetReporting
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Description { get; set; }
        public int? DhetFileNumberEnum { get; set; }
        public string? NativeSql { get; set; }
    }
}

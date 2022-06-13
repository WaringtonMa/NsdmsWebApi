using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class OnScreenHelp
    {
        public long Id { get; set; }
        public ulong? Active { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? HelpText { get; set; }
        public string? Screen { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class GpCreditor
    {
        public string? VendorId { get; set; }
        public string? VendorName { get; set; }
        public string? VendorClassId { get; set; }
        public string? VendorStatus { get; set; }
        public double? CurrentBalance { get; set; }
        public string? Hold { get; set; }
        public ulong Id { get; set; }
    }
}

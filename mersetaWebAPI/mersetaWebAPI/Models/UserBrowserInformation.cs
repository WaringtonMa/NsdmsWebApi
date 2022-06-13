using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class UserBrowserInformation
    {
        public long Id { get; set; }
        public string? BrowserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? FullUrl { get; set; }
        public string? IpAddress { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string? OperatingSystem { get; set; }
        public string? Referrer { get; set; }
        public string? UserAgent { get; set; }
        public long? UsersId { get; set; }
        public long? TasksId { get; set; }
        public string? CallingClass { get; set; }
        public string? CallingMethod { get; set; }
        public string? IpAddressDecoded { get; set; }

        public virtual Task? Tasks { get; set; }
        public virtual User? Users { get; set; }
    }
}

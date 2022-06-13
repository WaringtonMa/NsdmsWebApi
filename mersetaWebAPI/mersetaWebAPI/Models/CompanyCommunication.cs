using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyCommunication
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Description { get; set; }
        public string? Guid { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? Title { get; set; }
        public ulong? Visible { get; set; }
        public long? CompanyId { get; set; }
        public long? CreateUsersId { get; set; }
        public long? LastUpdateUserId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual User? CreateUsers { get; set; }
        public virtual User? LastUpdateUser { get; set; }
    }
}

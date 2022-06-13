using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class UsersRole
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Note { get; set; }
        public long? ProcessRolesId { get; set; }
        public long? UsersId { get; set; }

        public virtual ProcessRole? ProcessRoles { get; set; }
        public virtual User? Users { get; set; }
    }
}

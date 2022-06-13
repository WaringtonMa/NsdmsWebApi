using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class UsersResponsibility
    {
        public long Id { get; set; }
        public long? CompanyUsersId { get; set; }
        public long? UserResponsibilityId { get; set; }

        public virtual CompanyUser? CompanyUsers { get; set; }
        public virtual UserResponsibility? UserResponsibility { get; set; }
    }
}

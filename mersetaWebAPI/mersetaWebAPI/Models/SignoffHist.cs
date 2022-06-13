using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SignoffHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public ulong? Accept { get; set; }
        public ulong? Completed { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DateSignOffUserChanged { get; set; }
        public ulong? Dispute { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? Guid { get; set; }
        public string? OneTimePassword { get; set; }
        public DateTime? SignOffDate { get; set; }
        public string? SignOffTitle { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public long? ChangeUserId { get; set; }
        public long? DgVerificationId { get; set; }
        public long? MgVerificationId { get; set; }
        public long? TempSignoffId { get; set; }
        public long? UserId { get; set; }
        public long? WspId { get; set; }
        public long? WspDisputeId { get; set; }
        public ulong? LastestSignoff { get; set; }
        public ulong? ExternalUserSignoff { get; set; }
        public ulong? CanChangeSignOffUser { get; set; }
        public long? RoleId { get; set; }
        public int? SignoffByEnum { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

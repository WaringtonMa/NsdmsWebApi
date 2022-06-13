using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Signoff
    {
        public long Id { get; set; }
        public ulong? Accept { get; set; }
        public ulong? Completed { get; set; }
        public DateTime? CreateDate { get; set; }
        public ulong? Dispute { get; set; }
        public string? SignOffTitle { get; set; }
        public long? DgVerificationId { get; set; }
        public long? MgVerificationId { get; set; }
        public long? UserId { get; set; }
        public long? WspId { get; set; }
        public string? Guid { get; set; }
        public long? WspDisputeId { get; set; }
        public long? TempSignoffId { get; set; }
        public DateTime? SignOffDate { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public DateTime? DateSignOffUserChanged { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? OneTimePassword { get; set; }
        public long? ChangeUserId { get; set; }
        public ulong? LastestSignoff { get; set; }
        public ulong? ExternalUserSignoff { get; set; }
        public ulong? CanChangeSignOffUser { get; set; }
        public long? RoleId { get; set; }
        public int? SignoffByEnum { get; set; }

        public virtual User? ChangeUser { get; set; }
        public virtual DgVerification? DgVerification { get; set; }
        public virtual MgVerification? MgVerification { get; set; }
        public virtual Role? Role { get; set; }
        public virtual TempSignoff? TempSignoff { get; set; }
        public virtual User? User { get; set; }
        public virtual Wsp? Wsp { get; set; }
        public virtual WspDispute? WspDispute { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class EnrolmentStatus
    {
        public EnrolmentStatus()
        {
            MandatoryGrantDetailArchives = new HashSet<MandatoryGrantDetailArchive>();
            MandatoryGrantDetails = new HashSet<MandatoryGrantDetail>();
            MgVerificationDetails = new HashSet<MgVerificationDetail>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? Description { get; set; }
        public string? Code { get; set; }
        public ulong? AppearOnAtr { get; set; }
        public ulong? AppearOnWsp { get; set; }
        public string? SmsCode { get; set; }

        public virtual ICollection<MandatoryGrantDetailArchive> MandatoryGrantDetailArchives { get; set; }
        public virtual ICollection<MandatoryGrantDetail> MandatoryGrantDetails { get; set; }
        public virtual ICollection<MgVerificationDetail> MgVerificationDetails { get; set; }
    }
}

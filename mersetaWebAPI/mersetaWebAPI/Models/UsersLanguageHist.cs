using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class UsersLanguageHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? CreateDate { get; set; }
        public ulong? HomeLanguage { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? LanguageId { get; set; }
        public long? ReadId { get; set; }
        public long? SpearkId { get; set; }
        public long? UpdateUserId { get; set; }
        public long? UserId { get; set; }
        public long? WriteId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

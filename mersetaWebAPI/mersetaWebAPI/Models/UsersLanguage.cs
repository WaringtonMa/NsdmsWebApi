using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class UsersLanguage
    {
        public long Id { get; set; }
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

        public virtual Language? Language { get; set; }
        public virtual YesNoLookup? Read { get; set; }
        public virtual YesNoLookup? Speark { get; set; }
        public virtual User? UpdateUser { get; set; }
        public virtual User? User { get; set; }
        public virtual YesNoLookup? Write { get; set; }
    }
}

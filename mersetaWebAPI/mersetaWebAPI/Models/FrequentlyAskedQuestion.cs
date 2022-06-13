using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class FrequentlyAskedQuestion
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Note { get; set; }
        public ulong? QuestionActive { get; set; }
        public string? QuestionAnswer { get; set; }
        public string? QuestionAsked { get; set; }
        public string? QuestionSection { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class MailTemplate
    {
        public long Id { get; set; }
        public int? MailCode { get; set; }
        public string? SubjectText { get; set; }
        public string? TemplateText { get; set; }
    }
}

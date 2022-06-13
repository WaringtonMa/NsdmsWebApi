using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SdfType
    {
        public SdfType()
        {
            SdfCompanies = new HashSet<SdfCompany>();
            SdfCompanyHistories = new HashSet<SdfCompanyHistory>();
            WspSdfCompanyHistories = new HashSet<WspSdfCompanyHistory>();
            WspSignoffs = new HashSet<WspSignoff>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? Description { get; set; }
        public string? Code { get; set; }
        public ulong? SignOffWsp { get; set; }
        public long? SignOnRecognition { get; set; }
        public string? SmsCode { get; set; }
        public ulong? RegisterLearners { get; set; }
        public ulong? RegisterMentors { get; set; }

        public virtual YesNoLookup? SignOnRecognitionNavigation { get; set; }
        public virtual ICollection<SdfCompany> SdfCompanies { get; set; }
        public virtual ICollection<SdfCompanyHistory> SdfCompanyHistories { get; set; }
        public virtual ICollection<WspSdfCompanyHistory> WspSdfCompanyHistories { get; set; }
        public virtual ICollection<WspSignoff> WspSignoffs { get; set; }
    }
}

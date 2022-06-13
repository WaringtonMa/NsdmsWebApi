﻿using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Institution
    {
        public Institution()
        {
            CompanyLearners = new HashSet<CompanyLearner>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? Description { get; set; }
        public long? InstitutionTypeId { get; set; }
        public string? SmsCode { get; set; }

        public virtual InstitutionType? InstitutionType { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearners { get; set; }
    }
}

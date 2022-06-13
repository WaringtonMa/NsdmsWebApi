﻿using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class AccreditationStatus
    {
        public AccreditationStatus()
        {
            TrainingProviderApplications = new HashSet<TrainingProviderApplication>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? Description { get; set; }
        public ulong? LegacyStatus { get; set; }

        public virtual ICollection<TrainingProviderApplication> TrainingProviderApplications { get; set; }
    }
}

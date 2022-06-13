using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DesignatedTrade
    {
        public DesignatedTrade()
        {
            CompanyLearners = new HashSet<CompanyLearner>();
            CompanyLearnersDetailsChanges = new HashSet<CompanyLearnersDetailsChange>();
            CompanyLearnersLostTimes = new HashSet<CompanyLearnersLostTime>();
            DesignatedTradeLevels = new HashSet<DesignatedTradeLevel>();
            SaqaQualifications = new HashSet<SaqaQualification>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public ulong? AutoExtend { get; set; }
        public string? Description { get; set; }
        public int? DesignatedTradeType { get; set; }
        public long Duration { get; set; }
        public long Extention { get; set; }
        public string? QualificationId { get; set; }

        public virtual ICollection<CompanyLearner> CompanyLearners { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChanges { get; set; }
        public virtual ICollection<CompanyLearnersLostTime> CompanyLearnersLostTimes { get; set; }
        public virtual ICollection<DesignatedTradeLevel> DesignatedTradeLevels { get; set; }
        public virtual ICollection<SaqaQualification> SaqaQualifications { get; set; }
    }
}

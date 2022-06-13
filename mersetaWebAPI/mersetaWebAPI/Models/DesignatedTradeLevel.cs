using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DesignatedTradeLevel
    {
        public DesignatedTradeLevel()
        {
            CompanyLearners = new HashSet<CompanyLearner>();
            CompanyLearnersDetailsChanges = new HashSet<CompanyLearnersDetailsChange>();
            CompanyLearnersLostTimes = new HashSet<CompanyLearnersLostTime>();
            CompanyLearnersProgresses = new HashSet<CompanyLearnersProgress>();
            CompanyLearnersTradeTests = new HashSet<CompanyLearnersTradeTest>();
            DesignatedTradeLevelItems = new HashSet<DesignatedTradeLevelItem>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? Description { get; set; }
        public long Maxweeks { get; set; }
        public long Minweeks { get; set; }
        public long? DesignatedTradeTypeId { get; set; }
        public long Level { get; set; }
        public long? DesignatedTradeId { get; set; }
        public long? QualificationId { get; set; }
        public ulong? Extension { get; set; }
        public DateTime? DateLegacyAttempts { get; set; }
        public int? LegacyMaxAttemptsAmount { get; set; }
        public int MaxAttemptsAmount { get; set; }
        public ulong? NoOrder { get; set; }
        public string? ReportDisplayName { get; set; }
        public string? ReportDownloadName { get; set; }
        public string? DocumentNumber { get; set; }
        public string? DocumentTitle { get; set; }
        public int TotalModulesAssigned { get; set; }

        public virtual DesignatedTrade? DesignatedTrade { get; set; }
        public virtual DesignatedTradeType? DesignatedTradeType { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearners { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChanges { get; set; }
        public virtual ICollection<CompanyLearnersLostTime> CompanyLearnersLostTimes { get; set; }
        public virtual ICollection<CompanyLearnersProgress> CompanyLearnersProgresses { get; set; }
        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTests { get; set; }
        public virtual ICollection<DesignatedTradeLevelItem> DesignatedTradeLevelItems { get; set; }
    }
}

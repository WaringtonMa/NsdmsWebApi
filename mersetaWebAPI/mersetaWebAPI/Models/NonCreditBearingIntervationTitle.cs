using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class NonCreditBearingIntervationTitle
    {
        public NonCreditBearingIntervationTitle()
        {
            CompanyLearners = new HashSet<CompanyLearner>();
            CompanyLearnersDetailsChanges = new HashSet<CompanyLearnersDetailsChange>();
            MandatoryGrantDetailArchives = new HashSet<MandatoryGrantDetailArchive>();
            MandatoryGrantDetails = new HashSet<MandatoryGrantDetail>();
            MandatoryGrantRecommendations = new HashSet<MandatoryGrantRecommendation>();
            MandatoryGrants = new HashSet<MandatoryGrant>();
            MgVerificationDetails = new HashSet<MgVerificationDetail>();
            WorkplaceMonitoringLearnerInductions = new HashSet<WorkplaceMonitoringLearnerInduction>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<CompanyLearner> CompanyLearners { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChanges { get; set; }
        public virtual ICollection<MandatoryGrantDetailArchive> MandatoryGrantDetailArchives { get; set; }
        public virtual ICollection<MandatoryGrantDetail> MandatoryGrantDetails { get; set; }
        public virtual ICollection<MandatoryGrantRecommendation> MandatoryGrantRecommendations { get; set; }
        public virtual ICollection<MandatoryGrant> MandatoryGrants { get; set; }
        public virtual ICollection<MgVerificationDetail> MgVerificationDetails { get; set; }
        public virtual ICollection<WorkplaceMonitoringLearnerInduction> WorkplaceMonitoringLearnerInductions { get; set; }
    }
}

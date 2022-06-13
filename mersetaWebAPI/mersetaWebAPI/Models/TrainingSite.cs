using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class TrainingSite
    {
        public TrainingSite()
        {
            AssessorModeratorCompanySites = new HashSet<AssessorModeratorCompanySite>();
            CompanyLearners = new HashSet<CompanyLearner>();
            LegacyProviderApplicationSiteAllocations = new HashSet<LegacyProviderApplicationSiteAllocation>();
            SdpCompanies = new HashSet<SdpCompany>();
            SdpCompanyActions = new HashSet<SdpCompanyAction>();
            TrainingProviderApplications = new HashSet<TrainingProviderApplication>();
        }

        public long Id { get; set; }
        public int? ApprovalStatus { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastActionUserDate { get; set; }
        public string? SiteGuid { get; set; }
        public string SiteName { get; set; } = null!;
        public long? CompanyId { get; set; }
        public long? LastActionUserId { get; set; }
        public long? PostalAddressId { get; set; }
        public long? ResidentialAddressId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual User? LastActionUser { get; set; }
        public virtual Address? PostalAddress { get; set; }
        public virtual Address? ResidentialAddress { get; set; }
        public virtual ICollection<AssessorModeratorCompanySite> AssessorModeratorCompanySites { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearners { get; set; }
        public virtual ICollection<LegacyProviderApplicationSiteAllocation> LegacyProviderApplicationSiteAllocations { get; set; }
        public virtual ICollection<SdpCompany> SdpCompanies { get; set; }
        public virtual ICollection<SdpCompanyAction> SdpCompanyActions { get; set; }
        public virtual ICollection<TrainingProviderApplication> TrainingProviderApplications { get; set; }
    }
}

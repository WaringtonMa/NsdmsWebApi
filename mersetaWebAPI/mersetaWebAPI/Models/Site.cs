using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Site
    {
        public Site()
        {
            AddressChanges = new HashSet<AddressChange>();
            AddressHistories = new HashSet<AddressHistory>();
            Addresses = new HashSet<Address>();
            CompanyLearners = new HashSet<CompanyLearner>();
            CompanyLearnersDetailsChanges = new HashSet<CompanyLearnersDetailsChange>();
            DgVerificationSites = new HashSet<DgVerificationSite>();
            Employees = new HashSet<Employee>();
            EmployeesHistories = new HashSet<EmployeesHistory>();
            MandatoryGrantWorkplaces = new HashSet<MandatoryGrantWorkplace>();
            SiteVisitReportNews = new HashSet<SiteVisitReportNew>();
            SiteVisitReportSmes = new HashSet<SiteVisitReportSme>();
            SitesHistories = new HashSet<SitesHistory>();
            SitesSmes = new HashSet<SitesSme>();
            WorkPlaceApprovalSites = new HashSet<WorkPlaceApprovalSite>();
            WorkPlaceApprovals = new HashSet<WorkPlaceApproval>();
            WspCompanyAddressHistories = new HashSet<WspCompanyAddressHistory>();
        }

        public long Id { get; set; }
        public string? CompanyGuid { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyRegistrationNumber { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Email { get; set; }
        public string? FaxNumber { get; set; }
        public string? LevyNumber { get; set; }
        public int? NumberOfEmployees { get; set; }
        public string? SiteNumber { get; set; }
        public string? TelNumber { get; set; }
        public long? CompanyId { get; set; }
        public long? FormUserId { get; set; }
        public long? RegisteredAddressId { get; set; }
        public int? SiteStatus { get; set; }
        public string? CompanySiteNumber { get; set; }
        public long? LegacyOrganisationSitesId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual User? FormUser { get; set; }
        public virtual LegacyOrganisationSite? LegacyOrganisationSites { get; set; }
        public virtual Address? RegisteredAddress { get; set; }
        public virtual ICollection<AddressChange> AddressChanges { get; set; }
        public virtual ICollection<AddressHistory> AddressHistories { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearners { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChanges { get; set; }
        public virtual ICollection<DgVerificationSite> DgVerificationSites { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<EmployeesHistory> EmployeesHistories { get; set; }
        public virtual ICollection<MandatoryGrantWorkplace> MandatoryGrantWorkplaces { get; set; }
        public virtual ICollection<SiteVisitReportNew> SiteVisitReportNews { get; set; }
        public virtual ICollection<SiteVisitReportSme> SiteVisitReportSmes { get; set; }
        public virtual ICollection<SitesHistory> SitesHistories { get; set; }
        public virtual ICollection<SitesSme> SitesSmes { get; set; }
        public virtual ICollection<WorkPlaceApprovalSite> WorkPlaceApprovalSites { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovals { get; set; }
        public virtual ICollection<WspCompanyAddressHistory> WspCompanyAddressHistories { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Address
    {
        public Address()
        {
            AddressChangePostalAddresses = new HashSet<AddressChange>();
            AddressChangeResidentialAddresses = new HashSet<AddressChange>();
            AddressHistories = new HashSet<AddressHistory>();
            CompanyHistoryPostalAddresses = new HashSet<CompanyHistory>();
            CompanyHistoryRegisteredAddresses = new HashSet<CompanyHistory>();
            CompanyHistoryResidentialAddresses = new HashSet<CompanyHistory>();
            CompanyPostalAddresses = new HashSet<Company>();
            CompanyRegisteredAddresses = new HashSet<Company>();
            CompanyResidentialAddresses = new HashSet<Company>();
            CompanyTradeTestEmployerPostalAddresses = new HashSet<CompanyTradeTestEmployer>();
            CompanyTradeTestEmployerRegisteredAddresses = new HashSet<CompanyTradeTestEmployer>();
            CompanyTradeTestEmployerResidentialAddresses = new HashSet<CompanyTradeTestEmployer>();
            LearnerPostalAddresses = new HashSet<Learner>();
            LearnerResidentialAddresses = new HashSet<Learner>();
            NonSetaCompanyPostalAddresses = new HashSet<NonSetaCompany>();
            NonSetaCompanyRegisteredAddresses = new HashSet<NonSetaCompany>();
            NonSetaCompanyResidentialAddresses = new HashSet<NonSetaCompany>();
            Offices = new HashSet<Office>();
            SitesHistories = new HashSet<SitesHistory>();
            SitesNavigation = new HashSet<Site>();
            SitesSmes = new HashSet<SitesSme>();
            TrainingSitePostalAddresses = new HashSet<TrainingSite>();
            TrainingSiteResidentialAddresses = new HashSet<TrainingSite>();
            UserBirthAddresses = new HashSet<User>();
            UserPostalAddresses = new HashSet<User>();
            UserResidentialAddresses = new HashSet<User>();
            WorkPlaceApprovalSites = new HashSet<WorkPlaceApprovalSite>();
        }

        public long Id { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? AddressLine4 { get; set; }
        public DateTime? CreateDate { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string? Postcode { get; set; }
        public ulong? PrimaryAddr { get; set; }
        public ulong? SameAddress { get; set; }
        public long? CompanyId { get; set; }
        public long? HostingCompanyId { get; set; }
        public int? MunicipalityId { get; set; }
        public long? UserId { get; set; }
        public long? SitesId { get; set; }
        public long? TownId { get; set; }
        public double? LatitudeDegrees { get; set; }
        public double? LatitudeMinutes { get; set; }
        public double? LatitudeSeconds { get; set; }
        public double? LongitudeDegrees { get; set; }
        public double? LongitudeMinutes { get; set; }
        public double? LongitudeSeconds { get; set; }
        public long? StatsSaareaCodeId { get; set; }
        public ulong? InitialValidation { get; set; }
        public ulong? WorkflowValidation { get; set; }
        public DateTime? ValidiationRanDate { get; set; }
        public long? CreateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? LastUpdateUser { get; set; }

        public virtual Company? Company { get; set; }
        public virtual HostingCompany? HostingCompany { get; set; }
        public virtual Municipality? Municipality { get; set; }
        public virtual Site? Sites { get; set; }
        public virtual StatssaAreaCode? StatsSaareaCode { get; set; }
        public virtual Town? Town { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<AddressChange> AddressChangePostalAddresses { get; set; }
        public virtual ICollection<AddressChange> AddressChangeResidentialAddresses { get; set; }
        public virtual ICollection<AddressHistory> AddressHistories { get; set; }
        public virtual ICollection<CompanyHistory> CompanyHistoryPostalAddresses { get; set; }
        public virtual ICollection<CompanyHistory> CompanyHistoryRegisteredAddresses { get; set; }
        public virtual ICollection<CompanyHistory> CompanyHistoryResidentialAddresses { get; set; }
        public virtual ICollection<Company> CompanyPostalAddresses { get; set; }
        public virtual ICollection<Company> CompanyRegisteredAddresses { get; set; }
        public virtual ICollection<Company> CompanyResidentialAddresses { get; set; }
        public virtual ICollection<CompanyTradeTestEmployer> CompanyTradeTestEmployerPostalAddresses { get; set; }
        public virtual ICollection<CompanyTradeTestEmployer> CompanyTradeTestEmployerRegisteredAddresses { get; set; }
        public virtual ICollection<CompanyTradeTestEmployer> CompanyTradeTestEmployerResidentialAddresses { get; set; }
        public virtual ICollection<Learner> LearnerPostalAddresses { get; set; }
        public virtual ICollection<Learner> LearnerResidentialAddresses { get; set; }
        public virtual ICollection<NonSetaCompany> NonSetaCompanyPostalAddresses { get; set; }
        public virtual ICollection<NonSetaCompany> NonSetaCompanyRegisteredAddresses { get; set; }
        public virtual ICollection<NonSetaCompany> NonSetaCompanyResidentialAddresses { get; set; }
        public virtual ICollection<Office> Offices { get; set; }
        public virtual ICollection<SitesHistory> SitesHistories { get; set; }
        public virtual ICollection<Site> SitesNavigation { get; set; }
        public virtual ICollection<SitesSme> SitesSmes { get; set; }
        public virtual ICollection<TrainingSite> TrainingSitePostalAddresses { get; set; }
        public virtual ICollection<TrainingSite> TrainingSiteResidentialAddresses { get; set; }
        public virtual ICollection<User> UserBirthAddresses { get; set; }
        public virtual ICollection<User> UserPostalAddresses { get; set; }
        public virtual ICollection<User> UserResidentialAddresses { get; set; }
        public virtual ICollection<WorkPlaceApprovalSite> WorkPlaceApprovalSites { get; set; }
    }
}

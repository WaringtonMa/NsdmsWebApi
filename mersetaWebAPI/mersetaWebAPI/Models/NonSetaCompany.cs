using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class NonSetaCompany
    {
        public NonSetaCompany()
        {
            CompanyLearners = new HashSet<CompanyLearner>();
            CompanyLearnersDetailsChanges = new HashSet<CompanyLearnersDetailsChange>();
            CompanyQualifications = new HashSet<CompanyQualification>();
            CompanyUnitStandards = new HashSet<CompanyUnitStandard>();
            NonSetaCompanyUsers = new HashSet<NonSetaCompanyUser>();
            TrainingProviderApplications = new HashSet<TrainingProviderApplication>();
        }

        public long Id { get; set; }
        public string? AccreditationNumber { get; set; }
        public int? ApprovalEnum { get; set; }
        public string? CompanyGuid { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? CompanyNumber { get; set; }
        public string? CompanyRegistrationNumber { get; set; }
        public int? CompanyStatus { get; set; }
        public int? CompanyType { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Email { get; set; }
        public string? FaxNumber { get; set; }
        public string? LevyNumber { get; set; }
        public string? TelNumber { get; set; }
        public long? PostalAddressId { get; set; }
        public long? RegisteredAddressId { get; set; }
        public long? ResidentialAddressId { get; set; }
        public long? SetaId { get; set; }
        public long? SicCodeId { get; set; }

        public virtual Address? PostalAddress { get; set; }
        public virtual Address? RegisteredAddress { get; set; }
        public virtual Address? ResidentialAddress { get; set; }
        public virtual Setum? Seta { get; set; }
        public virtual SicCode? SicCode { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearners { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChanges { get; set; }
        public virtual ICollection<CompanyQualification> CompanyQualifications { get; set; }
        public virtual ICollection<CompanyUnitStandard> CompanyUnitStandards { get; set; }
        public virtual ICollection<NonSetaCompanyUser> NonSetaCompanyUsers { get; set; }
        public virtual ICollection<TrainingProviderApplication> TrainingProviderApplications { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class PreviousSchool
    {
        public PreviousSchool()
        {
            CompanyLearners = new HashSet<CompanyLearner>();
            CompanyLearnersDetailsChanges = new HashSet<CompanyLearnersDetailsChange>();
            Users = new HashSet<User>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? AddrInit { get; set; }
        public string? Addressee { get; set; }
        public string? Allocation { get; set; }
        public string? ComponentNo { get; set; }
        public string? DmUnName { get; set; }
        public string? DataYear { get; set; }
        public string? DemarcationFrom { get; set; }
        public string? DemarcationTo { get; set; }
        public string? EducatorTwentyEighteen { get; set; }
        public string? EiCircuit { get; set; }
        public string? EiDistrict { get; set; }
        public string? EiRegion { get; set; }
        public string? ExDept { get; set; }
        public string? ExamCentre { get; set; }
        public string? ExamNo { get; set; }
        public string? Facsimile { get; set; }
        public string? GisLatitude { get; set; }
        public string? GisLongitude { get; set; }
        public string? GisSource { get; set; }
        public string? LmUnName { get; set; }
        public string? LearnersTwentyEighteen { get; set; }
        public string? Nas { get; set; }
        public string? NatEmis { get; set; }
        public string? NewNatemis { get; set; }
        public string? NoFeeSchool { get; set; }
        public string? NodalArea { get; set; }
        public string? OfficialInstitutionName { get; set; }
        public string? OldNatemis { get; set; }
        public string? OwnerBuildings { get; set; }
        public string? OwnerLand { get; set; }
        public string? PayPointNo { get; set; }
        public string? PhasePed { get; set; }
        public string? PostalAddress { get; set; }
        public string? Province { get; set; }
        public string? ProvinceCd { get; set; }
        public string? Quintile { get; set; }
        public string? RegistrationDate { get; set; }
        public string? SectionTwentyOne { get; set; }
        public string? SectionTwentyOneFunct { get; set; }
        public string? Sector { get; set; }
        public string? SpCode { get; set; }
        public string? SpName { get; set; }
        public string? Specialization { get; set; }
        public string? Status { get; set; }
        public string? StreetAddress { get; set; }
        public string? Suburb { get; set; }
        public string? Telephone { get; set; }
        public string? TownCity { get; set; }
        public string? TownshipVillage { get; set; }
        public string? TypeDoe { get; set; }
        public string? UrbanRural { get; set; }
        public string? WardId { get; set; }

        public virtual ICollection<CompanyLearner> CompanyLearners { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChanges { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}

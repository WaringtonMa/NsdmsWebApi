using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkPlaceApprovalSite
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string FirstName { get; set; } = null!;
        public string? IdentityNumber { get; set; }
        public string LastName { get; set; } = null!;
        public string? LearnershipRegistrationNumber { get; set; }
        public int? NumberOfArtisans { get; set; }
        public int? NumberOfLearners { get; set; }
        public long? SitesId { get; set; }
        public long? WorkPlaceApprovalId { get; set; }
        public int? ApprovalEnum { get; set; }
        public string? PassportNumber { get; set; }
        public ulong? UseCompanyAddress { get; set; }
        public long? DeleteUserId { get; set; }
        public long? QualificationId { get; set; }
        public long? ResidentialAddressId { get; set; }
        public long? SitesSmeId { get; set; }
        public long? WorkPlaceApprovalMentorId { get; set; }

        public virtual User? DeleteUser { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual Address? ResidentialAddress { get; set; }
        public virtual Site? Sites { get; set; }
        public virtual SitesSme? SitesSme { get; set; }
        public virtual WorkPlaceApproval? WorkPlaceApproval { get; set; }
        public virtual WorkPlaceApprovalMentor? WorkPlaceApprovalMentor { get; set; }
    }
}

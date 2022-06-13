using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WorkPlaceApprovalSitesHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public int? ApprovalEnum { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? FirstName { get; set; }
        public string? IdentityNumber { get; set; }
        public string? LastName { get; set; }
        public string? LearnershipRegistrationNumber { get; set; }
        public int? NumberOfArtisans { get; set; }
        public int? NumberOfLearners { get; set; }
        public string? PassportNumber { get; set; }
        public ulong? UseCompanyAddress { get; set; }
        public long? DeleteUserId { get; set; }
        public long? QualificationId { get; set; }
        public long? ResidentialAddressId { get; set; }
        public long? SitesId { get; set; }
        public long? SitesSmeId { get; set; }
        public long? WorkPlaceApprovalId { get; set; }
        public long? WorkPlaceApprovalMentorId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

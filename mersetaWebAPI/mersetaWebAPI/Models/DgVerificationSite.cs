using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DgVerificationSite
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string FirstName { get; set; } = null!;
        public string? IdentityNumber { get; set; }
        public string LastName { get; set; } = null!;
        public string? LearnershipRegistrationNumber { get; set; }
        public int? NumberOfArtisans { get; set; }
        public int? NumberOfLearners { get; set; }
        public long? DgVerificationId { get; set; }
        public long? MandatoryGrantId { get; set; }
        public long? QualificationId { get; set; }
        public long? SitesId { get; set; }

        public virtual DgVerification? DgVerification { get; set; }
        public virtual MandatoryGrant? MandatoryGrant { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual Site? Sites { get; set; }
    }
}

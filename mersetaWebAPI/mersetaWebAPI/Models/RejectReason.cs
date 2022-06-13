using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class RejectReason
    {
        public RejectReason()
        {
            DgVerificationRejectionInformations = new HashSet<DgVerificationRejectionInformation>();
            MandatoryGrantRecommendations = new HashSet<MandatoryGrantRecommendation>();
            RejectReasonMultipleSelectionHists = new HashSet<RejectReasonMultipleSelectionHist>();
            RejectReasonMultipleSelections = new HashSet<RejectReasonMultipleSelection>();
            RejectReasonsChildren = new HashSet<RejectReasonsChild>();
            WspRejectionInformations = new HashSet<WspRejectionInformation>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? Description { get; set; }
        public int? ForProcess { get; set; }
        public string? HowTo { get; set; }
        public string? SmsCode { get; set; }
        public ulong? ForCrm { get; set; }
        public ulong? ForExecutive { get; set; }
        public ulong? ForManager { get; set; }
        public ulong? ForSeniorManager { get; set; }
        public ulong? ForClo { get; set; }
        public ulong? SoftDeleted { get; set; }

        public virtual ICollection<DgVerificationRejectionInformation> DgVerificationRejectionInformations { get; set; }
        public virtual ICollection<MandatoryGrantRecommendation> MandatoryGrantRecommendations { get; set; }
        public virtual ICollection<RejectReasonMultipleSelectionHist> RejectReasonMultipleSelectionHists { get; set; }
        public virtual ICollection<RejectReasonMultipleSelection> RejectReasonMultipleSelections { get; set; }
        public virtual ICollection<RejectReasonsChild> RejectReasonsChildren { get; set; }
        public virtual ICollection<WspRejectionInformation> WspRejectionInformations { get; set; }
    }
}

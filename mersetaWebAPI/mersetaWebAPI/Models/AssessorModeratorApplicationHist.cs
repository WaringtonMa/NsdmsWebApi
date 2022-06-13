using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class AssessorModeratorApplicationHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public int? ApplicationType { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string? CertificateNumber { get; set; }
        public DateTime? CodeOfConductAcceptDate { get; set; }
        public ulong? CodeOfConductAccepted { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EndDate { get; set; }
        public ulong? FinalRejected { get; set; }
        public DateTime? StartDate { get; set; }
        public int? Status { get; set; }
        public long? JobTitleId { get; set; }
        public long? OfoCodesId { get; set; }
        public long? ReviewCommitteeMeetingId { get; set; }
        public long? ReviewCommitteeMeetingAgendaId { get; set; }
        public long? UsersId { get; set; }
        public ulong? FinalApproved { get; set; }
        public long? LegacyAssessorAccreditationId { get; set; }
        public long? LegacyModeratorAccreditationId { get; set; }
        public long? EtqaId { get; set; }
        public ulong? DuplicateApplication { get; set; }
        public int? TypeAssessorModerator { get; set; }
        public ulong? TradeTestCenterApplication { get; set; }
        public ulong? AssessorApplication { get; set; }
        public ulong? ModeratorApplication { get; set; }
        public long? CreateUserId { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? LastUpdateUserId { get; set; }
        public ulong? SystemUpdate { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

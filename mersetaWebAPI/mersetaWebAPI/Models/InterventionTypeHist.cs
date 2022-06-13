using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class InterventionTypeHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? CreateDate { get; set; }
        public double? BasicGrantAmount { get; set; }
        public string? Description { get; set; }
        public double? DisabilityGrantAmount { get; set; }
        public int? Duration { get; set; }
        public int? InterventionTypeEnum { get; set; }
        public double? OtherGrantAmount { get; set; }
        public int? PivotNonpivot { get; set; }
        public int? PrioritisationScale { get; set; }
        public ulong? WorkplaceApprovalRequired { get; set; }
        public int? TranchIntervals { get; set; }
        public ulong? BursariesDocumentsRequired { get; set; }
        public ulong? ExtensionRequest { get; set; }
        public ulong? Busary { get; set; }
        public string? Dhet { get; set; }
        public ulong? ForTradeTest { get; set; }
        public string? Form { get; set; }
        public string? GovDescription { get; set; }
        public ulong? RequestVerificationOfAssessments { get; set; }
        public ulong? WorkplaceBasedLearning { get; set; }
        public ulong? ForSdpAccreditation { get; set; }
        public ulong? CompletionLetter { get; set; }
        public ulong? RegistrationByNonMerseta { get; set; }
        public ulong? Arpl { get; set; }
        public string? ShortDescription { get; set; }
        public string? PartOfIdString { get; set; }
        public ulong? AtrSelection { get; set; }
        public ulong? CanSelect { get; set; }
        public ulong? WspElection { get; set; }
        public int? QmrTypeSelection { get; set; }
        public int? QualificationTypeSelection { get; set; }
        public ulong? Institution { get; set; }
        public long? AetProgrammeLevelId { get; set; }
        public ulong? Onesidedtermination { get; set; }
        public int? TrancheRule { get; set; }
        public ulong? QmrTvetReport { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

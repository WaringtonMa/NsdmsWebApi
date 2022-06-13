using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Doc
    {
        public Doc()
        {
            DgYears = new HashSet<DgYear>();
            DocumentTrackers = new HashSet<DocumentTracker>();
            InverseOriginalDoc = new HashSet<Doc>();
            TrainingProviderDocParents = new HashSet<TrainingProviderDocParent>();
        }

        public long Id { get; set; }
        public string? ContentType { get; set; }
        public DateTime? CreateDate { get; set; }
        public byte[]? Data { get; set; }
        public string? Extension { get; set; }
        public string? NewFname { get; set; }
        public string? Note { get; set; }
        public string? OriginalFname { get; set; }
        public int? VersionNo { get; set; }
        public long? CompanyId { get; set; }
        public long? ConfigDocId { get; set; }
        public long? OriginalDocId { get; set; }
        public long? ForUserId { get; set; }
        public long? UserId { get; set; }
        public long? WspId { get; set; }
        public long? HostingCompanyTemplatesId { get; set; }
        public int? DocumentRequiredCheckEnum { get; set; }
        public long? BankingDetailsId { get; set; }
        public long? ExtensionRequestId { get; set; }
        public long? SarsLeviesPaidId { get; set; }
        public long? DgVerificationId { get; set; }
        public long? MailLogId { get; set; }
        public int? ApprovalStatus { get; set; }
        public long? ModulesId { get; set; }
        public long? ModulesTitlesId { get; set; }
        public long? ChangeReasonId { get; set; }
        public string? TargetClass { get; set; }
        public long? TargetKey { get; set; }
        public string? TargetClassTemp { get; set; }
        public long? TargetKeyTemp { get; set; }

        public virtual BankingDetail? BankingDetails { get; set; }
        public virtual ChangeReason? ChangeReason { get; set; }
        public virtual Company? Company { get; set; }
        public virtual ConfigDoc? ConfigDoc { get; set; }
        public virtual DgVerification? DgVerification { get; set; }
        public virtual ExtensionRequest? ExtensionRequest { get; set; }
        public virtual User? ForUser { get; set; }
        public virtual HostingCompanyTemplate? HostingCompanyTemplates { get; set; }
        public virtual MailLog? MailLog { get; set; }
        public virtual Module? Modules { get; set; }
        public virtual ModulesTitle? ModulesTitles { get; set; }
        public virtual Doc? OriginalDoc { get; set; }
        public virtual SarsLeviesPaid? SarsLeviesPaid { get; set; }
        public virtual User? User { get; set; }
        public virtual Wsp? Wsp { get; set; }
        public virtual DocByte DocByte { get; set; } = null!;
        public virtual ICollection<DgYear> DgYears { get; set; }
        public virtual ICollection<DocumentTracker> DocumentTrackers { get; set; }
        public virtual ICollection<Doc> InverseOriginalDoc { get; set; }
        public virtual ICollection<TrainingProviderDocParent> TrainingProviderDocParents { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SetmisFile505
    {
        public long Id { get; set; }
        public string? AlternativeIdType { get; set; }
        public string? AssessorEtqeId { get; set; }
        public string? AssessorRegistrationNumber { get; set; }
        public DateTime? DateStamp { get; set; }
        public string? ModeratorEtqeId { get; set; }
        public string? ModeratorRegistrationNumber { get; set; }
        public string? NationalId { get; set; }
        public string? PersonAlternateId { get; set; }
        public string? ProviderCode { get; set; }
        public string? ProviderEtqeId { get; set; }
        public string? QualificationId { get; set; }
        public string? TradeTestDate { get; set; }
        public string? TradeTestNumber { get; set; }
        public string? TradeTestProviderCode { get; set; }
        public string? TradeTestProviderEtqeId { get; set; }
        public string? TradeTestResultId { get; set; }
        public string? TradeTestResultReasonId { get; set; }
    }
}

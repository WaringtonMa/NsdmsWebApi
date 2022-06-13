using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class NlrdFile26
    {
        public long Id { get; set; }
        public decimal? AlternativeIdType { get; set; }
        public DateTime? DateStamp { get; set; }
        public string? DesignationEtqaId { get; set; }
        public DateTime? DesignationEndDate { get; set; }
        public string? DesignationId { get; set; }
        public string? DesignationRegistrationNumber { get; set; }
        public DateTime? DesignationStartDate { get; set; }
        public string? EtqaDecisionNumber { get; set; }
        public string? NationalId { get; set; }
        public string? PersonAlternateId { get; set; }
        public string? ProviderCode { get; set; }
        public string? ProviderEtqaId { get; set; }
        public string? StructureStatusId { get; set; }
    }
}

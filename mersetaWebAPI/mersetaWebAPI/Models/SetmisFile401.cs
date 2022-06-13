using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SetmisFile401
    {
        public long Id { get; set; }
        public string? AlternativeIdType { get; set; }
        public DateTime? DateStamp { get; set; }
        public string? DesignationEtqeId { get; set; }
        public DateTime? DesignationEndDate { get; set; }
        public string? DesignationId { get; set; }
        public string? DesignationRegistrationNumber { get; set; }
        public DateTime? DesignationStartDate { get; set; }
        public string? DesignationStructureStatusId { get; set; }
        public string? EtqeDecisionNumber { get; set; }
        public string? Filler01 { get; set; }
        public string? Filler02 { get; set; }
        public string? Filler03 { get; set; }
        public string? NationalId { get; set; }
        public string? PersonAlternateId { get; set; }
        public string? ProviderCode { get; set; }
        public string? ProviderEtqeId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class NlrdFile27
    {
        public long Id { get; set; }
        public DateTime? DateStamp { get; set; }
        public string? DesignationEtqaId { get; set; }
        public string? DesignationId { get; set; }
        public string? DesignationRegistrationNumber { get; set; }
        public string? EtqaDecisionNumber { get; set; }
        public string? LearnershipId { get; set; }
        public string? NqfDesigStatusCode { get; set; }
        public DateTime? NqfDesignationEndDate { get; set; }
        public DateTime? NqfDesignationStartDate { get; set; }
        public int? QualificationId { get; set; }
        public int? UnitStandardId { get; set; }
    }
}

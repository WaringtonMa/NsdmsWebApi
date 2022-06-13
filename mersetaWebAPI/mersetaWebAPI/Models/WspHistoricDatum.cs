using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WspHistoricDatum
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public string? FinalStatus { get; set; }
        public string? GrantNameRevised { get; set; }
        public int? LevyYear { get; set; }
        public string? OrganisationNameLegal { get; set; }
        public string? OrganistaionNameTrade { get; set; }
        public string? ReferenceNo { get; set; }
        public int? WspStatusEnum { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WspCalculationDatum
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Description { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Female { get; set; }
        public string? FundingMethod { get; set; }
        public string? LevyNumber { get; set; }
        public int? Male { get; set; }
        public string? NqfLevelBandDesc { get; set; }
        public string? OfoCode { get; set; }
        public DateTime? StartDate { get; set; }
        public int? TotalLearners { get; set; }
        public string? TrainingDescription { get; set; }
        public long? CompanyId { get; set; }
        public long? FundingId { get; set; }
        public long? OfoCodesId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual Funding? Funding { get; set; }
        public virtual OfoCode? OfoCodes { get; set; }
    }
}

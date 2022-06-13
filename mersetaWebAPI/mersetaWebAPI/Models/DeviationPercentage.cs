using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DeviationPercentage
    {
        public long? Id { get; set; }
        public string? CompanyName { get; set; }
        public string? LevyNumber { get; set; }
        public decimal? TotalCalcData { get; set; }
        public decimal? TotalTrainData { get; set; }
        public decimal? Percentage { get; set; }
    }
}

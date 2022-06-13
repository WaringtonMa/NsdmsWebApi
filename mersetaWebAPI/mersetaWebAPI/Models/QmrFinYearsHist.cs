using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class QmrFinYearsHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? CreateDate { get; set; }
        public ulong? DataGenerated { get; set; }
        public DateTime? DataGenerationDate { get; set; }
        public DateTime? DateDataGenerated { get; set; }
        public DateTime? DateForGeneration { get; set; }
        public int? FinYearEnd { get; set; }
        public int? FinYearQuarters { get; set; }
        public long? FinYearQuartersLookUpFlatKey { get; set; }
        public int? FinYearStart { get; set; }
        public DateTime? FromDate { get; set; }
        public string? RefNo { get; set; }
        public DateTime? ToDate { get; set; }
        public long? FinancialYearsId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

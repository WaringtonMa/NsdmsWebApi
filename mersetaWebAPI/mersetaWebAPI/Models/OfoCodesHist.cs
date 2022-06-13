using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class OfoCodesHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Description { get; set; }
        public string? Fm { get; set; }
        public string? MajorGroup { get; set; }
        public string? MinorGroup { get; set; }
        public string? OfoCode { get; set; }
        public string? SpecialisationCode { get; set; }
        public string? SubMajorGroup { get; set; }
        public ulong? Trade { get; set; }
        public string? TradeType { get; set; }
        public string? UnitGroup { get; set; }
        public long? OccupationCategoryId { get; set; }
        public long? OfoCodesId { get; set; }
        public ulong? Active { get; set; }
        public ulong? GreenOccupation { get; set; }
        public ulong? GreenSkill { get; set; }
        public int? Year { get; set; }
        public string? SetmisCode { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

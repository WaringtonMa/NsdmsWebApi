using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class WspSkillsGap
    {
        public long Id { get; set; }
        public ulong? ClericalSupportWorkersSelection { get; set; }
        public DateTime? CreateDate { get; set; }
        public ulong? ElementaryWorkersSelection { get; set; }
        public ulong? ManagerSelection { get; set; }
        public ulong? PlantMachineOperatorsAssemblersSelection { get; set; }
        public ulong? ProfessionalsSelection { get; set; }
        public string? RowDescription { get; set; }
        public ulong? ServiceSalesWorkersSelection { get; set; }
        public ulong? SkilledTradesWorkersSelection { get; set; }
        public int? SkillsGapSection { get; set; }
        public ulong? TechniciansAssociateProfessionalsSelection { get; set; }
        public long? WspId { get; set; }

        public virtual Wsp? Wsp { get; set; }
    }
}

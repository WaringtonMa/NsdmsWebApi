using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ProviderApplicationSuspensionDeActivated
    {
        public long Id { get; set; }
        public string? AccreditationNumberAtTime { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? PreviousProviderStatus { get; set; }
        public int? ProviderSusActions { get; set; }
        public string? Reason { get; set; }
        public ulong? RemovedSuspension { get; set; }
        public int? StatusAssigned { get; set; }
        public long? CompanyId { get; set; }
        public long? CreateUserId { get; set; }
        public long? TrainingProviderApplicationId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual User? CreateUser { get; set; }
        public virtual TrainingProviderApplication? TrainingProviderApplication { get; set; }
    }
}

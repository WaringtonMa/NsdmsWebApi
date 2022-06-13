using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyLearnersDetailsChangeAud
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public long? AppointmentId { get; set; }
        public long? DesignatedTradeId { get; set; }
        public long? DesignatedTradeLevelId { get; set; }
        public long? DesignatedTradeTypeId { get; set; }
        public long? DgtagId { get; set; }
        public long? EmploymentTypeId { get; set; }
        public long? HighestQualificationId { get; set; }
        public long? LearnershipId { get; set; }
        public long? MandatoryGrantGetailId { get; set; }
        public long? NonCreditBearingIntervationTitleId { get; set; }
        public long? OrganisedLabourUnionMembershipId { get; set; }
        public long? PreviousSchools { get; set; }
        public long? ProjectImplementationPlanId { get; set; }
        public long? ProjecttypeId { get; set; }
        public long? ReviewCommitteeMeetingId { get; set; }
        public long? ScheduledEventId { get; set; }
        public long? SiteId { get; set; }
        public long? DundingId { get; set; }
        public long? StatsSaareaCodeId { get; set; }
        public long? UnionMembershipId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyLearnersTermination
    {
        public CompanyLearnersTermination()
        {
            InverseCompanyLearnersTerminationParent = new HashSet<CompanyLearnersTermination>();
        }

        public long Id { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastWorkingDayOfLearner { get; set; }
        public int? Status { get; set; }
        public int? TerminationTypeEnum { get; set; }
        public long? CompanyLearnersId { get; set; }
        public DateTime? InvestigateDate { get; set; }
        public long? CreateUserId { get; set; }
        public long? ReviewCommitteeMeetingId { get; set; }
        public long? ReviewCommitteeMeetingAgendaId { get; set; }
        public long? CompanyLearnersTerminationParentId { get; set; }
        public long? InvestigatorUserId { get; set; }
        public long? TaskId { get; set; }
        public long? TrainingProviderApplicationId { get; set; }
        public int? CreatedByEnum { get; set; }
        public int? SignoffByEnum { get; set; }

        public virtual CompanyLearner? CompanyLearners { get; set; }
        public virtual CompanyLearnersTermination? CompanyLearnersTerminationParent { get; set; }
        public virtual User? CreateUser { get; set; }
        public virtual User? InvestigatorUser { get; set; }
        public virtual ReviewCommitteeMeeting? ReviewCommitteeMeeting { get; set; }
        public virtual ReviewCommitteeMeetingAgendum? ReviewCommitteeMeetingAgenda { get; set; }
        public virtual Task? Task { get; set; }
        public virtual TrainingProviderApplication? TrainingProviderApplication { get; set; }
        public virtual ICollection<CompanyLearnersTermination> InverseCompanyLearnersTerminationParent { get; set; }
    }
}

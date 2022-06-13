using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class MgVerification
    {
        public MgVerification()
        {
            Signoffs = new HashSet<Signoff>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DateCaptured { get; set; }
        public long? WspId { get; set; }
        public ulong? CompleteIdentifiedTraining { get; set; }
        public ulong? HasTrainingCommenced { get; set; }
        public string? Note { get; set; }
        public ulong? ProofOfTrainingVerified { get; set; }
        public ulong? TrainingNeedsIdentified { get; set; }
        public long? FinalFin { get; set; }
        public DateTime? ResetDate { get; set; }
        public ulong? CompanyRepSignOff { get; set; }
        public ulong? CrmSignOff { get; set; }
        public ulong? MersetaRepSignOff { get; set; }
        public ulong? SdfSignOff { get; set; }
        public int? Status { get; set; }
        public long? AtrSubmitted { get; set; }
        public long? CompleteInYear { get; set; }
        public long? EmployerAttendMeetings { get; set; }
        public long? LabourAttendMeetings { get; set; }
        public long? MgSignedOff { get; set; }
        public long? OrganisedLabourUnion { get; set; }
        public long? ProofTrainingVerified { get; set; }
        public long? TrainingComitteeMinutes { get; set; }
        public long? TrainingCommenced { get; set; }
        public long? TrainingCompletedAsPrevious { get; set; }
        public long? WspSubmitted { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public ulong? DateForVisitProvided { get; set; }
        public DateTime? ReviewDate { get; set; }
        public ulong? SubmitedForVerification { get; set; }
        public long? CloGeneratedForId { get; set; }
        public string? CloComment { get; set; }
        public long? BatchNumber { get; set; }
        public long? PrimaryUserSignOffId { get; set; }
        public long? CrmUserAssignedId { get; set; }

        public virtual YesNoLookup? AtrSubmittedNavigation { get; set; }
        public virtual User? CloGeneratedFor { get; set; }
        public virtual YesNoLookup? CompleteInYearNavigation { get; set; }
        public virtual User? CrmUserAssigned { get; set; }
        public virtual YesNoLookup? EmployerAttendMeetingsNavigation { get; set; }
        public virtual YesNoLookup? LabourAttendMeetingsNavigation { get; set; }
        public virtual YesNoLookup? MgSignedOffNavigation { get; set; }
        public virtual YesNoLookup? OrganisedLabourUnionNavigation { get; set; }
        public virtual User? PrimaryUserSignOff { get; set; }
        public virtual YesNoLookup? ProofTrainingVerifiedNavigation { get; set; }
        public virtual YesNoLookup? TrainingComitteeMinutesNavigation { get; set; }
        public virtual YesNoLookup? TrainingCommencedNavigation { get; set; }
        public virtual YesNoLookup? TrainingCompletedAsPreviousNavigation { get; set; }
        public virtual Wsp? Wsp { get; set; }
        public virtual YesNoLookup? WspSubmittedNavigation { get; set; }
        public virtual ICollection<Signoff> Signoffs { get; set; }
    }
}

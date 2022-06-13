using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyLearnersDetailsChange
    {
        public long Id { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? CertificateDate { get; set; }
        public DateTime? CommencementDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? ConditionalPlacementDate { get; set; }
        public int? ContractOfEmploymentSpecified { get; set; }
        public int? ContractOfEmploymentCopy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Credits { get; set; }
        public string? CurrentJobTitle { get; set; }
        public string? CurrentStatus { get; set; }
        public string? DgTag { get; set; }
        public string? Dgtag1 { get; set; }
        public string? DocumentBoxId { get; set; }
        public int? EmployedByEmployerBefore { get; set; }
        public DateTime? EmploymentContractEndDate { get; set; }
        public DateTime? EmploymentContractStartDate { get; set; }
        public DateTime? EmploymentEndDate { get; set; }
        public DateTime? EmploymentStartDate { get; set; }
        public int? EmploymentStatus { get; set; }
        public string? Etqid { get; set; }
        public DateTime? FileApprovalDate { get; set; }
        public int? FileApproval { get; set; }
        public string? Funding { get; set; }
        public int? HighestEducationEnum { get; set; }
        public ulong? HostCompanyAvailable { get; set; }
        public int? HostCompanyYesNoEnum { get; set; }
        public int? Howlong { get; set; }
        public DateTime? LastSchoolYear { get; set; }
        public int? LearnerStatus { get; set; }
        public string? LearnershipCode { get; set; }
        public ulong? MersetaCompany { get; set; }
        public int? MersetaFunded { get; set; }
        public string? MetroFileBarcode { get; set; }
        public string? NoExplain { get; set; }
        public string? NonCredidBearingDescription { get; set; }
        public int? PartOfUnion { get; set; }
        public int? PivotNonPivot { get; set; }
        public ulong? ProviderAccredited { get; set; }
        public ulong? ProviderWorkplaceApproved { get; set; }
        public string? QualificationCode { get; set; }
        public string? QualificationTitle { get; set; }
        public DateTime? RegisteredDate { get; set; }
        public string? RegistrationNumber { get; set; }
        public int? ReviewStatus { get; set; }
        public int? SchemeYear { get; set; }
        public DateTime? SignedDate { get; set; }
        public ulong? Signoff { get; set; }
        public int? Status { get; set; }
        public int? Submission { get; set; }
        public ulong? SystemTermination { get; set; }
        public int? UndertakenLearningProgramBefore { get; set; }
        public int? WorkplaceBasedBefore { get; set; }
        public string? YesSpecify { get; set; }
        public long? AppointmentId { get; set; }
        public long? CompanyId { get; set; }
        public long? CompanyLearnersParentId { get; set; }
        public long? CreateUserId { get; set; }
        public long? DesignatedTradeId { get; set; }
        public long? DesignatedTradeLevelId { get; set; }
        public long? DesignatedTradeTypeId { get; set; }
       // public long? DgtagId { get; set; }
        public long? EmployerId { get; set; }
        public long? EmploymentTypeId { get; set; }
        public long? HighestQualificationId { get; set; }
        public long? HostCompanyId { get; set; }
        public long? InterventionLevelId { get; set; }
        public long? InterventionTypeId { get; set; }
        public long? LearnershipId { get; set; }
        public long? MandatoryGrantGetailId { get; set; }
        public long? NonCreditBearingIntervationTitleId { get; set; }
        public long? NonSetaCompanyId { get; set; }
        public long? NqfAlignedId { get; set; }
        public long? NqfLevelsId { get; set; }
        public long? OfoCodesId { get; set; }
        public long? OrganisedLabourUnionMembershipId { get; set; }
        public long? PreviousSchools { get; set; }
        public long? ProjectImplementationPlanId { get; set; }
        public long? ProjecttypeId { get; set; }
        public long? QualificationId { get; set; }
        public long? ReviewCommitteeMeetingId { get; set; }
        public long? ScheduledEventId { get; set; }
        public long? SiteId { get; set; }
        public long? SkillsProgramId { get; set; }
        public long? SkillsSetId { get; set; }
        public long? DundingId { get; set; }
        public long? StatsSaareaCodeId { get; set; }
        public long? UnionMembershipId { get; set; }
        public long? UnitStandardId { get; set; }
        public long? UserId { get; set; }

        public virtual Appointment? Appointment { get; set; }
        public virtual Company? Company { get; set; }
        public virtual CompanyLearner? CompanyLearnersParent { get; set; }
        public virtual User? CreateUser { get; set; }
        public virtual DesignatedTrade? DesignatedTrade { get; set; }
        public virtual DesignatedTradeLevel? DesignatedTradeLevel { get; set; }
        public virtual DesignatedTradeType? DesignatedTradeType { get; set; }
       // public virtual DgYear? Dgtag { get; set; }
        public virtual Funding? Dunding { get; set; }
        public virtual Company? Employer { get; set; }
        public virtual EmploymentType? EmploymentType { get; set; }
        public virtual SaqaQualification? HighestQualification { get; set; }
        public virtual Company? HostCompany { get; set; }
        public virtual InterventionLevel? InterventionLevel { get; set; }
        public virtual InterventionType? InterventionType { get; set; }
        public virtual Learnership? Learnership { get; set; }
        public virtual MandatoryGrantDetail? MandatoryGrantGetail { get; set; }
        public virtual NonCreditBearingIntervationTitle? NonCreditBearingIntervationTitle { get; set; }
        public virtual NonSetaCompany? NonSetaCompany { get; set; }
        public virtual YesNoLookup? NqfAligned { get; set; }
        public virtual NqfLevel? NqfLevels { get; set; }
        public virtual OfoCode? OfoCodes { get; set; }
        public virtual OrganisedLabourUnion? OrganisedLabourUnionMembership { get; set; }
        public virtual PreviousSchool? PreviousSchoolsNavigation { get; set; }
        public virtual ProjectImplementationPlan? ProjectImplementationPlan { get; set; }
        public virtual ProjectType? Projecttype { get; set; }
        public virtual SaqaQualification? Qualification { get; set; }
        public virtual ReviewCommitteeMeeting? ReviewCommitteeMeeting { get; set; }
        public virtual ScheduledEvent? ScheduledEvent { get; set; }
        public virtual Site? Site { get; set; }
        public virtual SkillsProgram? SkillsProgram { get; set; }
        public virtual SkillsSet? SkillsSet { get; set; }
        public virtual StatssaAreaCode? StatsSaareaCode { get; set; }
        public virtual UnionMembership? UnionMembership { get; set; }
        public virtual SaqaUnitstandard? UnitStandard { get; set; }
        public virtual User? User { get; set; }
    }
}

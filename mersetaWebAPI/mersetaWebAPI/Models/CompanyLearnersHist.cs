﻿using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class CompanyLearnersHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? CertificateDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CurrentStatus { get; set; }
        public string? Dgtag { get; set; }
        public string? Etqid { get; set; }
        public string? Funding { get; set; }
        public int? LearnerStatus { get; set; }
        public string? LearnershipCode { get; set; }
        public string? MetroFileBarcode { get; set; }
        public int? PivotNonPivot { get; set; }
        public string? QualificationCode { get; set; }
        public int? SchemeYear { get; set; }
        public int? Status { get; set; }
        public long? CompanyId { get; set; }
        public long? EmployerId { get; set; }
        public long? InterventionLevelId { get; set; }
        public long? InterventionTypeId { get; set; }
        public long? MandatoryGrantGetailId { get; set; }
        public long? NqfAlignedId { get; set; }
        public long? NqfLevelsId { get; set; }
        public long? QualificationId { get; set; }
        public long? SkillsProgramId { get; set; }
        public long? SkillsSetId { get; set; }
        public long? UnitStandardId { get; set; }
        public long? UserId { get; set; }
        public DateTime? CommencementDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string? DgTag1 { get; set; }
        public int? MersetaFunded { get; set; }
        public ulong? Signoff { get; set; }
        public long? AppointmentId { get; set; }
        public long? CreateUserId { get; set; }
        public long? DgtagId { get; set; }
        public long? OfoCodesId { get; set; }
        public long? ProjecttypeId { get; set; }
        public DateTime? RegisteredDate { get; set; }
        public int? ReviewStatus { get; set; }
        public long? ReviewCommitteeMeetingId { get; set; }
        public string? Credits { get; set; }
        public string? QualificationTitle { get; set; }
        public string? RegistrationNumber { get; set; }
        public int? UndertakenLearningProgramBefore { get; set; }
        public long? NonSetaCompanyId { get; set; }
        public int? ContractOfEmploymentSpecified { get; set; }
        public int? ContractOfEmploymentCopy { get; set; }
        public int? EmployedByEmployerBefore { get; set; }
        public string? NoExplain { get; set; }
        public int? WorkplaceBasedBefore { get; set; }
        public string? YesSpecify { get; set; }
        public long? DesignatedTradeId { get; set; }
        public long? DesignatedTradeLevelId { get; set; }
        public long? DesignatedTradeTypeId { get; set; }
        public long? SiteId { get; set; }
        public string? DocumentBoxId { get; set; }
        public DateTime? EmploymentContractEndDate { get; set; }
        public DateTime? EmploymentContractStartDate { get; set; }
        public DateTime? LastSchoolYear { get; set; }
        public long? CompanyLearnersParentId { get; set; }
        public long? LearnershipId { get; set; }
        public long? ProjectImplementationPlanId { get; set; }
        public long? ScheduledEventId { get; set; }
        public long? DundingId { get; set; }
        public long? StatsSaareaCodeId { get; set; }
        public string? CurrentJobTitle { get; set; }
        public ulong? HostCompanyAvailable { get; set; }
        public int? HostCompanyYesNoEnum { get; set; }
        public long? HostCompanyId { get; set; }
        public long? NonCreditBearingIntervationTitleId { get; set; }
        public ulong? SystemTermination { get; set; }
        public ulong? ProviderAccredited { get; set; }
        public ulong? ProviderWorkplaceApproved { get; set; }
        public int? Submission { get; set; }
        public DateTime? EmploymentEndDate { get; set; }
        public DateTime? EmploymentStartDate { get; set; }
        public int? EmploymentStatus { get; set; }
        public DateTime? FileApprovalDate { get; set; }
        public int? FileApproval { get; set; }
        public int? Howlong { get; set; }
        public int? PartOfUnion { get; set; }
        public long? HighestQualificationId { get; set; }
        public long? OrganisedLabourUnionMembershipId { get; set; }
        public long? UnionMembershipId { get; set; }
        public string? NonCredidBearingDescription { get; set; }
        public int? HighestEducationEnum { get; set; }
        public DateTime? ConditionalPlacementDate { get; set; }
        public DateTime? SignedDate { get; set; }
        public long? EmploymentTypeId { get; set; }
        public long? PreviousSchools { get; set; }
        public ulong? MersetaCompany { get; set; }
        public long? SmeQualificationId { get; set; }
        public ulong? MersetaRegistration { get; set; }
        public long? LegacyId { get; set; }
        public DateTime? DateQualificationObtained { get; set; }
        public DateTime? LastPassedTestDate { get; set; }
        public string? LegacyTargetClass { get; set; }
        public long? TrainingProviderApplicationId { get; set; }
        public long? SitesSmeId { get; set; }
        public string? CertificateNumber { get; set; }
        public DateTime? LegacyRegistrationDate { get; set; }
        public long? AssessorApplicationId { get; set; }
        public long? ModeratorApplicationId { get; set; }
        public long? TestCentreTrainingProviderApplicationId { get; set; }
        public long? LeaningProgrammeId { get; set; }
        public DateTime? DateLearnerCompleted { get; set; }
        public DateTime? DateLearnerRegistered { get; set; }
        public DateTime? DateLearnerTerminated { get; set; }
        public long? InstitutionId { get; set; }
        public long? TvetFetQualificationId { get; set; }
        public ulong? NewBursary { get; set; }
        public long? CompanyLearnersBursaryLinkId { get; set; }
        public int? DocumentChangeStatus { get; set; }
        public int? SignoffByEnum { get; set; }
        public int? CreatedByEnum { get; set; }
        public int? TvetLecturer { get; set; }
        public ulong? ELearner { get; set; }
        public long? TrainingSiteId { get; set; }
        public int? ContinuationFlag { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

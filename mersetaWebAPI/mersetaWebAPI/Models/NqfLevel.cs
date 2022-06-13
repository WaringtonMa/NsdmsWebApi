using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class NqfLevel
    {
        public NqfLevel()
        {
            CompanyLearners = new HashSet<CompanyLearner>();
            CompanyLearnersDetailsChanges = new HashSet<CompanyLearnersDetailsChange>();
            EmployeesTrainings = new HashSet<EmployeesTraining>();
            MandatoryGrantDetailArchives = new HashSet<MandatoryGrantDetailArchive>();
            MandatoryGrantDetails = new HashSet<MandatoryGrantDetail>();
            MandatoryGrants = new HashSet<MandatoryGrant>();
            MgVerificationDetails = new HashSet<MgVerificationDetail>();
            SaqaQualificationTemps = new HashSet<SaqaQualificationTemp>();
            SaqaQualifications = new HashSet<SaqaQualification>();
            SummativeAssessmentReports = new HashSet<SummativeAssessmentReport>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Description { get; set; }
        public int? Level { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate1 { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public long? InterventionLevelId { get; set; }
        public long? HighestQualificationRequiredId { get; set; }
        public string? Pre2009Description { get; set; }
        public string? SmsCode { get; set; }
        public string? SaqaQualificationDescription { get; set; }
        public string? UnitStandardCode { get; set; }

        public virtual HighestQualificationRequired? HighestQualificationRequired { get; set; }
        public virtual InterventionLevel? InterventionLevel { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearners { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChanges { get; set; }
        public virtual ICollection<EmployeesTraining> EmployeesTrainings { get; set; }
        public virtual ICollection<MandatoryGrantDetailArchive> MandatoryGrantDetailArchives { get; set; }
        public virtual ICollection<MandatoryGrantDetail> MandatoryGrantDetails { get; set; }
        public virtual ICollection<MandatoryGrant> MandatoryGrants { get; set; }
        public virtual ICollection<MgVerificationDetail> MgVerificationDetails { get; set; }
        public virtual ICollection<SaqaQualificationTemp> SaqaQualificationTemps { get; set; }
        public virtual ICollection<SaqaQualification> SaqaQualifications { get; set; }
        public virtual ICollection<SummativeAssessmentReport> SummativeAssessmentReports { get; set; }
    }
}

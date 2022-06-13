using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Etqa
    {
        public Etqa()
        {
            AssessorModeratorApplications = new HashSet<AssessorModeratorApplication>();
            Companies = new HashSet<Company>();
            CompanyLearnersTradeTestAssessorEtqas = new HashSet<CompanyLearnersTradeTest>();
            CompanyLearnersTradeTestModeratorEtqas = new HashSet<CompanyLearnersTradeTest>();
            DgVerifications = new HashSet<DgVerification>();
            EmployeesTrainings = new HashSet<EmployeesTraining>();
            InterSetaTransferCurrentEtqas = new HashSet<InterSetaTransfer>();
            InterSetaTransferNewEtqas = new HashSet<InterSetaTransfer>();
            Learnerships = new HashSet<Learnership>();
            MandatoryGrantDetailArchives = new HashSet<MandatoryGrantDetailArchive>();
            MandatoryGrantDetails = new HashSet<MandatoryGrantDetail>();
            MandatoryGrants = new HashSet<MandatoryGrant>();
            SkillsPrograms = new HashSet<SkillsProgram>();
            SkillsSets = new HashSet<SkillsSet>();
            TrainingProviderApplications = new HashSet<TrainingProviderApplication>();
            WorkPlaceApprovals = new HashSet<WorkPlaceApproval>();
            WspCompanyHistories = new HashSet<WspCompanyHistory>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? Description { get; set; }
        public string? SmsCode { get; set; }

        public virtual ICollection<AssessorModeratorApplication> AssessorModeratorApplications { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTestAssessorEtqas { get; set; }
        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTestModeratorEtqas { get; set; }
        public virtual ICollection<DgVerification> DgVerifications { get; set; }
        public virtual ICollection<EmployeesTraining> EmployeesTrainings { get; set; }
        public virtual ICollection<InterSetaTransfer> InterSetaTransferCurrentEtqas { get; set; }
        public virtual ICollection<InterSetaTransfer> InterSetaTransferNewEtqas { get; set; }
        public virtual ICollection<Learnership> Learnerships { get; set; }
        public virtual ICollection<MandatoryGrantDetailArchive> MandatoryGrantDetailArchives { get; set; }
        public virtual ICollection<MandatoryGrantDetail> MandatoryGrantDetails { get; set; }
        public virtual ICollection<MandatoryGrant> MandatoryGrants { get; set; }
        public virtual ICollection<SkillsProgram> SkillsPrograms { get; set; }
        public virtual ICollection<SkillsSet> SkillsSets { get; set; }
        public virtual ICollection<TrainingProviderApplication> TrainingProviderApplications { get; set; }
        public virtual ICollection<WorkPlaceApproval> WorkPlaceApprovals { get; set; }
        public virtual ICollection<WspCompanyHistory> WspCompanyHistories { get; set; }
    }
}

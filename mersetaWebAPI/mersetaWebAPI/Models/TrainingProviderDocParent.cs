using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class TrainingProviderDocParent
    {
        public TrainingProviderDocParent()
        {
            CompanyQualifications = new HashSet<CompanyQualification>();
            CompanyUnitStandards = new HashSet<CompanyUnitStandard>();
            SaqaQualificationTemps = new HashSet<SaqaQualificationTemp>();
            SaqaQualifications = new HashSet<SaqaQualification>();
            TrainingProviderLearnerships = new HashSet<TrainingProviderLearnership>();
            TrainingProviderSkillsPrograms = new HashSet<TrainingProviderSkillsProgram>();
            TrainingProviderSkillsSets = new HashSet<TrainingProviderSkillsSet>();
            WorkPlaceApprovalSkillsSets = new HashSet<WorkPlaceApprovalSkillsSet>();
            WorkPlaceApprovalUnitStandards = new HashSet<WorkPlaceApprovalUnitStandard>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Note { get; set; }
        public long? DocId { get; set; }

        public virtual Doc? Doc { get; set; }
        public virtual ICollection<CompanyQualification> CompanyQualifications { get; set; }
        public virtual ICollection<CompanyUnitStandard> CompanyUnitStandards { get; set; }
        public virtual ICollection<SaqaQualificationTemp> SaqaQualificationTemps { get; set; }
        public virtual ICollection<SaqaQualification> SaqaQualifications { get; set; }
        public virtual ICollection<TrainingProviderLearnership> TrainingProviderLearnerships { get; set; }
        public virtual ICollection<TrainingProviderSkillsProgram> TrainingProviderSkillsPrograms { get; set; }
        public virtual ICollection<TrainingProviderSkillsSet> TrainingProviderSkillsSets { get; set; }
        public virtual ICollection<WorkPlaceApprovalSkillsSet> WorkPlaceApprovalSkillsSets { get; set; }
        public virtual ICollection<WorkPlaceApprovalUnitStandard> WorkPlaceApprovalUnitStandards { get; set; }
    }
}

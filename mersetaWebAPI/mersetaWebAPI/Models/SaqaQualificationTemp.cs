using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SaqaQualificationTemp
    {
        public SaqaQualificationTemp()
        {
            SaqaUsQualificationTemps = new HashSet<SaqaUsQualificationTemp>();
        }

        public long Id { get; set; }
        public int? Qualificationid { get; set; }
        public string? QualificationidString { get; set; }
        public int? Qualificationminimumcredits { get; set; }
        public string? Qualificationtitle { get; set; }
        public string? Etqaacronym { get; set; }
        public string? Etqaid { get; set; }
        public string? Etqaname { get; set; }
        public DateTime? LastDateForEnrolment { get; set; }
        public DateTime? LastDateForEnrolment1 { get; set; }
        public DateTime? Lastdateforachievement { get; set; }
        public string? Nqflevelg2description { get; set; }
        public string? Qualificationtypedesc { get; set; }
        public DateTime? Qualregistrationenddate { get; set; }
        public DateTime? Qualregistrationstartdate { get; set; }
        public ulong? WorkplaceApprovalRequired { get; set; }
        public string? Abetbanddescription { get; set; }
        public string? Eloacqualassessmentcriteria { get; set; }
        public string? Eloacqualificationoutcome { get; set; }
        public string? Field { get; set; }
        public string? Fielddescription { get; set; }
        public string? Islearningprogramme { get; set; }
        public int? Learningprogrammequal { get; set; }
        public string? NqflevelId { get; set; }
        public string? Nqfleveldescription { get; set; }
        public string? Providercode { get; set; }
        public int? Provideretqaid { get; set; }
        public string? Providername { get; set; }
        public string? Qualarticulationoptions { get; set; }
        public string? Qualassessorcriteria { get; set; }
        public string? Qualificationclassdesc { get; set; }
        public string? Qualificationnotes { get; set; }
        public string? Qualificationpurpose { get; set; }
        public string? Qualintlbenchmarkingmemo { get; set; }
        public string? Quallearningassumedinplace { get; set; }
        public string? Qualmoderationoptions { get; set; }
        public string? Qualrulesofcombination { get; set; }
        public string? Recognizeprevlearningflag { get; set; }
        public string? Registrationstatusdesc { get; set; }
        public string? Saqadecisionnumber { get; set; }
        public string? Sgbname { get; set; }
        public string? Subfielddescription { get; set; }
        public int? Trainoutperiod { get; set; }
        public int? Transitionperiod { get; set; }
        public string? Nqflevelg2Id { get; set; }
        public long? NqfLevelId1 { get; set; }
        public long? TrainingProviderDocParentId { get; set; }
        public string? Qualificationtypeid { get; set; }
        public string? Registrationstatuscode { get; set; }

        public virtual NqfLevel? NqfLevelId1Navigation { get; set; }
        public virtual TrainingProviderDocParent? TrainingProviderDocParent { get; set; }
        public virtual ICollection<SaqaUsQualificationTemp> SaqaUsQualificationTemps { get; set; }
    }
}

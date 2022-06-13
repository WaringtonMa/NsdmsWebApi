using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SaqaQualificationHist
    {
        public long Id { get; set; }
        public int Rev { get; set; }
        public sbyte? Revtype { get; set; }
        public int? Qualificationid { get; set; }
        public string? QualificationidString { get; set; }
        public string? Qualificationtitle { get; set; }
        public string? Etqaid { get; set; }
        public string? Nqflevelg2description { get; set; }
        public long? NqfLevelId { get; set; }
        public int? Qualificationminimumcredits { get; set; }
        public string? Etqaacronym { get; set; }
        public string? Etqaname { get; set; }
        public DateTime? LastDateForEnrolment { get; set; }
        public string? Qualificationtypedesc { get; set; }
        public ulong? WorkplaceApprovalRequired { get; set; }
        public DateTime? Lastdateforachievement { get; set; }
        public DateTime? Qualregistrationenddate { get; set; }
        public DateTime? Qualregistrationstartdate { get; set; }
        public long? TrainingProviderDocParentId { get; set; }
        public string? Qualificationtypeid { get; set; }
        public string? Registrationstatuscode { get; set; }
        public string? Registrationstatusdesc { get; set; }
        public long? DesignatedTradeId { get; set; }
        public string? Nqfleveldescription { get; set; }
        public string? Islearningprogramme { get; set; }
        public string? Learningprogrammequal { get; set; }
        public long? LearnerMentorRatioId { get; set; }
        public int? LevelFour { get; set; }
        public int? LevelOne { get; set; }
        public int? LevelThree { get; set; }
        public int? LevelTwo { get; set; }
        public string? Subfielddescription { get; set; }
        public long? SubFieldId { get; set; }

        public virtual Revinfo RevNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class QmrFinYear
    {
        public QmrFinYear()
        {
            QmrAetProgrammeData = new HashSet<QmrAetProgrammeDatum>();
            QmrArtisanData = new HashSet<QmrArtisanDatum>();
            QmrBursaryData = new HashSet<QmrBursaryDatum>();
            QmrCandidacyProgrammeData = new HashSet<QmrCandidacyProgrammeDatum>();
            QmrIndividualUnitStandardData = new HashSet<QmrIndividualUnitStandardDatum>();
            QmrInternshipData = new HashSet<QmrInternshipDatum>();
            QmrLearnershipData = new HashSet<QmrLearnershipDatum>();
            QmrLecturerDevelopmentData = new HashSet<QmrLecturerDevelopmentDatum>();
            QmrRplData = new HashSet<QmrRplDatum>();
            QmrSkillsProgrammeData = new HashSet<QmrSkillsProgrammeDatum>();
            QmrTvetData = new HashSet<QmrTvetDatum>();
            QmrUniversityStudentData = new HashSet<QmrUniversityStudentDatum>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public ulong? DataGenerated { get; set; }
        public DateTime? DataGenerationDate { get; set; }
        public DateTime? DateDataGenerated { get; set; }
        public int? FinYearEnd { get; set; }
        public int? FinYearQuarters { get; set; }
        public long? FinYearQuartersLookUpFlatKey { get; set; }
        public int? FinYearStart { get; set; }
        public DateTime? FromDate { get; set; }
        public string? RefNo { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? DateForGeneration { get; set; }
        public long? FinancialYearsId { get; set; }

        public virtual FinancialYear? FinancialYears { get; set; }
        public virtual ICollection<QmrAetProgrammeDatum> QmrAetProgrammeData { get; set; }
        public virtual ICollection<QmrArtisanDatum> QmrArtisanData { get; set; }
        public virtual ICollection<QmrBursaryDatum> QmrBursaryData { get; set; }
        public virtual ICollection<QmrCandidacyProgrammeDatum> QmrCandidacyProgrammeData { get; set; }
        public virtual ICollection<QmrIndividualUnitStandardDatum> QmrIndividualUnitStandardData { get; set; }
        public virtual ICollection<QmrInternshipDatum> QmrInternshipData { get; set; }
        public virtual ICollection<QmrLearnershipDatum> QmrLearnershipData { get; set; }
        public virtual ICollection<QmrLecturerDevelopmentDatum> QmrLecturerDevelopmentData { get; set; }
        public virtual ICollection<QmrRplDatum> QmrRplData { get; set; }
        public virtual ICollection<QmrSkillsProgrammeDatum> QmrSkillsProgrammeData { get; set; }
        public virtual ICollection<QmrTvetDatum> QmrTvetData { get; set; }
        public virtual ICollection<QmrUniversityStudentDatum> QmrUniversityStudentData { get; set; }
    }
}

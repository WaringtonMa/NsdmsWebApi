using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ImpactOfStaffTraining
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? DifficultKeepUp { get; set; }
        public int? EasierImportSkills { get; set; }
        public int? FindThatTherePositions { get; set; }
        public int? GraduatesSeemGetting { get; set; }
        public int? MostOurLearners { get; set; }
        public int? OnlyTrainAccordingToOurBusinessNeeds { get; set; }
        public int? ReadilyEmploy { get; set; }
        public int? ReadilyTrainTheUnemployed { get; set; }
        public int? TherePreference { get; set; }
        public int? TrainImproveProductivitys { get; set; }
        public int? TrainOurStaff { get; set; }
        public int? TrainOverAndAboveOurImmediateCompanyNeeds { get; set; }
        public int? TrainToAid { get; set; }
        public int? TrainToRemainGloballyCompetitive { get; set; }
        public int? TrainingCurrent { get; set; }
        public int? TrainingInstitutions { get; set; }
        public int? TrainingIsNo { get; set; }
        public int? WeReadilyEmployFetGraduates { get; set; }
        public int? WeTrainToKeepUpWithNewTechnologies { get; set; }
        public int? WorkWithTraining { get; set; }
        public long? WspId { get; set; }

        public virtual Wsp? Wsp { get; set; }
    }
}

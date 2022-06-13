using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class DgYear
    {
        public DgYear()
        {
            AllocationLists = new HashSet<AllocationList>();
            CompanyLearners = new HashSet<CompanyLearner>();
            CompanyLearnersDetailsChanges = new HashSet<CompanyLearnersDetailsChange>();
            DgYearLearningPrograms = new HashSet<DgYearLearningProgram>();
            ProjectTypes = new HashSet<ProjectType>();
            Wsps = new HashSet<Wsp>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? SmsCode { get; set; }
        public decimal? AllocationAmount { get; set; }
        public string? Description { get; set; }
        public int? FinYear { get; set; }
        public int? DgWindowType { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartDate { get; set; }
        public long? DocId { get; set; }

        public virtual Doc? Doc { get; set; }
        public virtual ICollection<AllocationList> AllocationLists { get; set; }
        public virtual ICollection<CompanyLearner> CompanyLearners { get; set; }
        public virtual ICollection<CompanyLearnersDetailsChange> CompanyLearnersDetailsChanges { get; set; }
        public virtual ICollection<DgYearLearningProgram> DgYearLearningPrograms { get; set; }
        public virtual ICollection<ProjectType> ProjectTypes { get; set; }
        public virtual ICollection<Wsp> Wsps { get; set; }
    }
}

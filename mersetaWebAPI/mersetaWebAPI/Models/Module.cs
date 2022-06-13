using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class Module
    {
        public Module()
        {
            CoursewareDistibutions = new HashSet<CoursewareDistibution>();
            Docs = new HashSet<Doc>();
            ModulesUnitStandards = new HashSet<ModulesUnitStandard>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? ModuleRef { get; set; }
        public string? ModuleTitle { get; set; }
        public string? ModuleTopic { get; set; }
        public string? Description { get; set; }
        public long? ModulesCategoryId { get; set; }
        public string? SmsCode { get; set; }

        public virtual ModulesCategory? ModulesCategory { get; set; }
        public virtual ICollection<CoursewareDistibution> CoursewareDistibutions { get; set; }
        public virtual ICollection<Doc> Docs { get; set; }
        public virtual ICollection<ModulesUnitStandard> ModulesUnitStandards { get; set; }
    }
}

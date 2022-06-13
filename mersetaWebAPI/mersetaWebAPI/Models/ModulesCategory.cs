using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ModulesCategory
    {
        public ModulesCategory()
        {
            Modules = new HashSet<Module>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? Description { get; set; }
        public string? FourthDescription { get; set; }
        public string? SecondDescription { get; set; }
        public string? ThirdDescription { get; set; }
        public string? SmsCode { get; set; }

        public virtual ICollection<Module> Modules { get; set; }
    }
}

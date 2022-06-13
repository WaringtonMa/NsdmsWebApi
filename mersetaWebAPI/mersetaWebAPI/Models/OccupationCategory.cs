using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class OccupationCategory
    {
        public OccupationCategory()
        {
            CompanyLearnersTradeTests = new HashSet<CompanyLearnersTradeTest>();
            Employees = new HashSet<Employee>();
            EmployeesHistories = new HashSet<EmployeesHistory>();
            OfoCodes = new HashSet<OfoCode>();
            WspCompanyEmployeesHistories = new HashSet<WspCompanyEmployeesHistory>();
            WspSkillsRequirements = new HashSet<WspSkillsRequirement>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? Description { get; set; }
        public string? SmsCode { get; set; }

        public virtual ICollection<CompanyLearnersTradeTest> CompanyLearnersTradeTests { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<EmployeesHistory> EmployeesHistories { get; set; }
        public virtual ICollection<OfoCode> OfoCodes { get; set; }
        public virtual ICollection<WspCompanyEmployeesHistory> WspCompanyEmployeesHistories { get; set; }
        public virtual ICollection<WspSkillsRequirement> WspSkillsRequirements { get; set; }
    }
}

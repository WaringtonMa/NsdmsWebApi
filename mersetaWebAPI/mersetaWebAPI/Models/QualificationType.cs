using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class QualificationType
    {
        public QualificationType()
        {
            Employees = new HashSet<Employee>();
            EmployeesHistories = new HashSet<EmployeesHistory>();
            UserQualifications = new HashSet<UserQualification>();
            WspCompanyEmployeesHistories = new HashSet<WspCompanyEmployeesHistory>();
        }

        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? NlrdCode { get; set; }
        public string? QctoCode { get; set; }
        public string? SetmisCode { get; set; }
        public string? Description { get; set; }
        public string? Code { get; set; }
        public string? SmsCode { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<EmployeesHistory> EmployeesHistories { get; set; }
        public virtual ICollection<UserQualification> UserQualifications { get; set; }
        public virtual ICollection<WspCompanyEmployeesHistory> WspCompanyEmployeesHistories { get; set; }
    }
}

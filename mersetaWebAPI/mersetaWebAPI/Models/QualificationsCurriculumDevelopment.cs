using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class QualificationsCurriculumDevelopment
    {
        public QualificationsCurriculumDevelopment()
        {
            QdfCompanies = new HashSet<QdfCompany>();
        }

        public long Id { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CurrentTraining { get; set; }
        public string? Demand { get; set; }
        public ulong? EdisipChecked { get; set; }
        public string? EdisipCheckedEvidence { get; set; }
        public ulong? IpapChecked { get; set; }
        public string? IpapCheckedEvidence { get; set; }
        public string? KeyStakeholders { get; set; }
        public ulong? NdpChecked { get; set; }
        public string? NdpCheckedEvidence { get; set; }
        public string? NewDevelopment1 { get; set; }
        public string? NewDevelopment2 { get; set; }
        public string? NewDevelopment3 { get; set; }
        public ulong? NgpChecked { get; set; }
        public string? NgpCheckedEvidence { get; set; }
        public string? PrimaryServiceOccupation { get; set; }
        public string? PurposeQualification { get; set; }
        public string? ReAlignmentQualificationIdList { get; set; }
        public string? ReviewQualificationIdList { get; set; }
        public string? RoleQualification { get; set; }
        public int? Status { get; set; }
        public DateTime? SubmitDate { get; set; }
        public string? TemplateType { get; set; }
        public string? UsersService { get; set; }
        public long? CompanyId { get; set; }
        public DateTime? UploadDate { get; set; }
        public long? ApproveUser { get; set; }
        public long? CreateUser { get; set; }
        public long? SubmitUser { get; set; }
        public long? UploadUser { get; set; }
        public int? TemplateTypeEnum { get; set; }
        public long? OfoCodesId { get; set; }

        public virtual User? ApproveUserNavigation { get; set; }
        public virtual Company? Company { get; set; }
        public virtual User? CreateUserNavigation { get; set; }
        public virtual OfoCode? OfoCodes { get; set; }
        public virtual User? SubmitUserNavigation { get; set; }
        public virtual User? UploadUserNavigation { get; set; }
        public virtual ICollection<QdfCompany> QdfCompanies { get; set; }
    }
}

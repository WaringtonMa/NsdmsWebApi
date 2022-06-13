using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class SiteVisitReportNew
    {
        public SiteVisitReportNew()
        {
            SiteVisitReportDisputes = new HashSet<SiteVisitReportDispute>();
            SiteVisitReportSmes = new HashSet<SiteVisitReportSme>();
        }

        public long Id { get; set; }
        public string? Comments { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DateApproved { get; set; }
        public DateTime? EquipmentFiveRevisitDate { get; set; }
        public DateTime? EquipmentFourRevisitDate { get; set; }
        public DateTime? EquipmentOneRevisitDate { get; set; }
        public DateTime? EquipmentThreeRevisitDate { get; set; }
        public DateTime? EquipmentTwoRevisitDate { get; set; }
        public string? GpsDetails { get; set; }
        public DateTime? RecordOneRevisitDate { get; set; }
        public DateTime? RecordTwoRevisitDate { get; set; }
        public DateTime? RevisitDate { get; set; }
        public DateTime? SafetyOneRevisitDate { get; set; }
        public DateTime? SafetyThreeRevisitDate { get; set; }
        public DateTime? SafetyTwoRevisitDate { get; set; }
        public int? SiteVisitReportStatus { get; set; }
        public DateTime? SiteVisitReportDate { get; set; }
        public long? CompanyId { get; set; }
        public long? Site { get; set; }
        public long? UserId { get; set; }
        public long? EquipmentYesNoFive { get; set; }
        public long? EquipmentYesNoFour { get; set; }
        public long? EquipmentYesNoOne { get; set; }
        public long? EquipmentYesNoThree { get; set; }
        public long? EquipmentYesNoTwo { get; set; }
        public long? RecordYesNoOne { get; set; }
        public long? RecordYesNoTwo { get; set; }
        public long? SafetyYesNoOne { get; set; }
        public long? SafetyYesNoThree { get; set; }
        public long? SafetyYesNoTwo { get; set; }

        public virtual Company? Company { get; set; }
        public virtual YesNoLookup? EquipmentYesNoFiveNavigation { get; set; }
        public virtual YesNoLookup? EquipmentYesNoFourNavigation { get; set; }
        public virtual YesNoLookup? EquipmentYesNoOneNavigation { get; set; }
        public virtual YesNoLookup? EquipmentYesNoThreeNavigation { get; set; }
        public virtual YesNoLookup? EquipmentYesNoTwoNavigation { get; set; }
        public virtual YesNoLookup? RecordYesNoOneNavigation { get; set; }
        public virtual YesNoLookup? RecordYesNoTwoNavigation { get; set; }
        public virtual YesNoLookup? SafetyYesNoOneNavigation { get; set; }
        public virtual YesNoLookup? SafetyYesNoThreeNavigation { get; set; }
        public virtual YesNoLookup? SafetyYesNoTwoNavigation { get; set; }
        public virtual Site? SiteNavigation { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<SiteVisitReportDispute> SiteVisitReportDisputes { get; set; }
        public virtual ICollection<SiteVisitReportSme> SiteVisitReportSmes { get; set; }
    }
}

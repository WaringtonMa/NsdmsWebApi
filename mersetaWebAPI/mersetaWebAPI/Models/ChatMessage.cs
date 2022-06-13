using System;
using System.Collections.Generic;

namespace mersetaWebAPI.Models
{
    public partial class ChatMessage
    {
        public ChatMessage()
        {
            InverseParentChat = new HashSet<ChatMessage>();
        }

        public long Id { get; set; }
        public DateTime? AttendToDateByStaff { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Msg { get; set; }
        public long? AttendToByStaffId { get; set; }
        public long? HostingCompanyDepartmentId { get; set; }
        public long? ParentChatId { get; set; }
        public long? UserId { get; set; }

        public virtual User? AttendToByStaff { get; set; }
        public virtual HostingCompanyDepartment? HostingCompanyDepartment { get; set; }
        public virtual ChatMessage? ParentChat { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<ChatMessage> InverseParentChat { get; set; }
    }
}

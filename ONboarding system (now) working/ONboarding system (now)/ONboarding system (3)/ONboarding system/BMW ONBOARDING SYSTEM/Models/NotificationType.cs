using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMW_ONBOARDING_SYSTEM.Models
{
    public partial class NotificationType
    {
        public NotificationType()
        {
            Notification = new HashSet<Notification>();
        }

        [Key]
        [Column("NotificationTypeID")]
        public int NotificationTypeId { get; set; }
        [StringLength(50)]
        public string NotificationTypeDescription { get; set; }

        [InverseProperty("NotificationType")]
        public virtual ICollection<Notification> Notification { get; set; }
    }
}

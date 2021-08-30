using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMW_ONBOARDING_SYSTEM.Models
{
    public partial class Notification
    {
        [Key]
        [Column("NotificationID")]
        public int NotificationId { get; set; }
        [Column("NotificationTypeID")]
        public int NotificationTypeId { get; set; }
        [StringLength(150)]
        public string NotificationMessageDescription { get; set; }

        [ForeignKey(nameof(NotificationTypeId))]
        [InverseProperty("Notification")]
        public virtual NotificationType NotificationType { get; set; }
        [InverseProperty("Notification")]
        public virtual UserNotification UserNotification { get; set; }
    }
}

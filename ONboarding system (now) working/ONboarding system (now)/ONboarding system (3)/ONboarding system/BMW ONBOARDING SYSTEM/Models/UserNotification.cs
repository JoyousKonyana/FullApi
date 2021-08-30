using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMW_ONBOARDING_SYSTEM.Models
{
    public partial class UserNotification
    {
        [Key]
        [Column("NotificationID")]
        public int NotificationId { get; set; }
        [Column("UserID")]
        public int UserId { get; set; }

        [ForeignKey(nameof(NotificationId))]
        [InverseProperty("UserNotification")]
        public virtual Notification Notification { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("UserNotification")]
        public virtual User User { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMW_ONBOARDING_SYSTEM.Models
{
    public partial class ActiveLog
    {
        [Key]
        [Column("ActiveLogID")]
        public int ActiveLogId { get; set; }
        [Column("UserID")]
        public int UserId { get; set; }
        [Required]
        [Column("ActiveLogDeviceIPAddress")]
        [StringLength(50)]
        public string ActiveLogDeviceIpaddress { get; set; }
        [Required]
        public byte[] ActiveLogLoginTimestamp { get; set; }
        public TimeSpan ActiveLogLastActiveTimestamp { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("ActiveLog")]
        public virtual User User { get; set; }
    }
}

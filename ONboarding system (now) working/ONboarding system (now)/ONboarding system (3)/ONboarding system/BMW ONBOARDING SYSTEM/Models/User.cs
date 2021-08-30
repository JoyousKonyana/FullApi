using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMW_ONBOARDING_SYSTEM.Models
{
    public partial class User
    {
        public User()
        {
            ActiveLog = new HashSet<ActiveLog>();
            AuditLog = new HashSet<AuditLog>();
            UserNotification = new HashSet<UserNotification>();
        }

        [Key]
        [Column("UserID")]
        public int UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
    
        public string Password { get; set; }
        [Column("UserRoleID")]
        public int? UserRoleId { get; set; }
        [Column("EmployeeID")]
        public int? EmployeeId { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("User")]
        public virtual Employee Employee { get; set; }
        [ForeignKey(nameof(UserRoleId))]
        [InverseProperty("User")]
        public virtual UserRole UserRole { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<ActiveLog> ActiveLog { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<AuditLog> AuditLog { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<UserNotification> UserNotification { get; set; }
    }
}

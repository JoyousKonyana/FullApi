using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMW_ONBOARDING_SYSTEM.Models
{
    public partial class AuditReport
    {
        [Key]
        [Column("AuditReportID")]
        public int AuditReportId { get; set; }
        [Column("AuditLogID")]
        public int AuditLogId { get; set; }
        [Column(TypeName = "date")]
        public DateTime AuditReportDate { get; set; }
        [StringLength(50)]
        public string AuditReportDescription { get; set; }

        [ForeignKey(nameof(AuditLogId))]
        [InverseProperty("AuditReport")]
        public virtual AuditLog AuditLog { get; set; }
    }
}

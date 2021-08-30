using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMW_ONBOARDING_SYSTEM.Models
{
    public partial class Certificate
    {
        [Key]
        [Column("CertificateID")]
        public int CertificateId { get; set; }
        [Column("LessonCompletionStatusID")]
        public int? LessonCompletionStatusId { get; set; }
        [StringLength(50)]
        public string CertificateDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CertificateDateGenerated { get; set; }
        [Column("CertificateTypeID")]
        public int? CertificateTypeId { get; set; }
        [Column("CourseCompletionStatusID")]
        public int? CourseCompletionStatusId { get; set; }
    }
}

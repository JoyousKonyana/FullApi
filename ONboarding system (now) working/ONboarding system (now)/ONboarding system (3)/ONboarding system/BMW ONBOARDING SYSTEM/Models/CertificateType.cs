using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMW_ONBOARDING_SYSTEM.Models
{
    public partial class CertificateType
    {
        [Key]
        [Column("CertificateTypeID")]
        public int CertificateTypeId { get; set; }
        [StringLength(50)]
        public string CertificateTypeTemplate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMW_ONBOARDING_SYSTEM.Models
{
    [Table("FAQ")]
    public partial class Faq
    {
        [Key]
        [Column("FAQID")]
        public int Faqid { get; set; }
        [Required]
        [Column("FAQDescription")]
        [StringLength(100)]
        public string Faqdescription { get; set; }
        [Column("FAQAnswer")]
        [StringLength(150)]
        public string Faqanswer { get; set; }
    }
}

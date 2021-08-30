using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMW_ONBOARDING_SYSTEM.Models
{
    public partial class Equipment
    {
        [Key]
        [Column("EquipmentID")]
        public int EquipmentId { get; set; }
        [Column("EquipmentTypeID")]
        public int EquipmentTypeId { get; set; }
        [Column("EquipmentTradeInStatusID")]
        public int EquipmentTradeInStatusId { get; set; }
        [Column("WarrantyID")]
        public int WarrantyId { get; set; }
        [Column("EquipmentBrandID")]
        public int EquipmentBrandId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EquipmentTradeInDeadline { get; set; }
        [Required]
        [StringLength(50)]
        public string EquipmentSerialNumber { get; set; }

        [ForeignKey(nameof(EquipmentBrandId))]
        [InverseProperty("Equipment")]
        public virtual EquipmentBrand EquipmentBrand { get; set; }
        [ForeignKey(nameof(EquipmentTradeInStatusId))]
        [InverseProperty("Equipment")]
        public virtual EquipmentTradeInStatus EquipmentTradeInStatus { get; set; }
        [ForeignKey(nameof(EquipmentTypeId))]
        [InverseProperty("Equipment")]
        public virtual EquipmentType EquipmentType { get; set; }
        [ForeignKey(nameof(WarrantyId))]
        [InverseProperty("Equipment")]
        public virtual Warranty Warranty { get; set; }
        [InverseProperty("Equipment")]
        public virtual OnboarderEquipment OnboarderEquipment { get; set; }
    }
}

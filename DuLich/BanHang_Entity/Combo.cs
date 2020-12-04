namespace DuLich.BanHang_Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Combo")]
    public partial class Combo
    {
        public Combo()
        {
            InvoiceDetails = new HashSet<InvoiceDetail>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Combo_Name { get; set; }

        [Required]
        public DateTime CreateTime { get; set; }

        [Required]
        public int discountPercent { get; set; }

        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual ICollection<ComboProduct> ComboProducts { get; set; }


        public void Map(Combo combo)
        {
            this.ID = combo.ID;
            this.Combo_Name = combo.Combo_Name;
            this.ComboProducts = combo.ComboProducts;
            this.discountPercent = combo.discountPercent;
            this.CreateTime = combo.CreateTime;
            this.InvoiceDetails = combo.InvoiceDetails;
        }
    }
}

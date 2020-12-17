namespace DuLich.BanHang_Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("invoicedetail")]
    public partial class invoicedetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public int amount { get; set; }

        [Required]
        public long price { get; set; }

        public virtual combo combo { get; set; }

        public virtual invoice invoice { get; set; }

        public virtual product product { get; set; }

        public void Map(invoicedetail invoicedetail)
        {
            this.id = invoicedetail.id;
            this.amount = invoicedetail.amount;
            this.combo = invoicedetail.combo;
            this.invoice = invoicedetail.invoice;
            this.price = invoicedetail.price;
            this.product = invoicedetail.product;
        }
    }
}

namespace DuLich.BanHang_Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("product")]
    public partial class product
    {
        public product()
        {
            invoicedetails = new HashSet<invoicedetail>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public string product_name { get; set; }

        [Required]
        [StringLength(650)]
        public string detail { get; set; }

        [Required]
        public int amount { get; set; }

        [Required]
        public long price { get; set; }
        [Required]
        public DateTime createtime { get; set; }
        [Required]
        public int discountpercent { get; set; }

        public virtual catalog catalog { get; set; }
        public virtual ICollection<invoicedetail> invoicedetails { get; set; }
        public virtual ICollection<storage> storage { get; set; }
        public virtual ICollection<comboproducts> comboproducts { get; set; }

        public void Map(product product)
        {
            this.id = product.id;
            this.product_name = product.product_name;
            this.detail = product.detail;
            this.amount = product.amount;
            this.price = product.price;
            this.createtime = product.createtime;
            this.discountpercent = product.discountpercent;
            this.catalog = product.catalog;
            this.invoicedetails = product.invoicedetails;
            this.storage = product.storage;
        }
        public override string ToString()
        {
            return product_name;
        }
    }
}

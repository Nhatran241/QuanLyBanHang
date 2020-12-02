namespace DuLich.BanHang_Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public Product()
        {
            InvoiceDetails = new HashSet<InvoiceDetail>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Product_Name { get; set; }

        [Required]
        [StringLength(650)]
        public string Detail { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public long Price { get; set; }
        [Required]
        public DateTime CreateTime { get; set; }
        [Required]
        public int DiscountPercent { get; set; }

        public virtual Catalog Catalog { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual ICollection<Storage> Storage { get; set; }

        public void Map(Product product)
        {
            this.ID = product.ID;
            this.Product_Name = product.Product_Name;
            this.Detail = product.Detail;
            this.Amount = product.Amount;
            this.Price = product.Price;
            this.CreateTime = product.CreateTime;
            this.DiscountPercent = product.DiscountPercent;
            this.Catalog = product.Catalog;
            this.InvoiceDetails = product.InvoiceDetails;
            this.Storage = product.Storage;
        }
    }
}

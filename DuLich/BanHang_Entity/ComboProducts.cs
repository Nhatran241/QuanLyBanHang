namespace DuLich.BanHang_Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ComboProduct")]
    public partial class ComboProduct
    {
        public ComboProduct()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public virtual Product Product { get; set; }
        [Required]
        public int Product_Amount { get; set; }
        public virtual Combo Combo { get; set; }

        public void Map(ComboProduct comboProduct)
        {
            this.ID = comboProduct.ID;
            this.Combo = comboProduct.Combo;
            this.Product = comboProduct.Product;
            this.Product_Amount = comboProduct.Product_Amount;
        }
    }
}

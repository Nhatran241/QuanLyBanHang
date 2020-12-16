namespace DuLich.BanHang_Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("comboproduct")]
    public partial class comboproducts
    {
        public comboproducts()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public virtual product product { get; set; }
        [Required]
        public int product_amount { get; set; }
        public virtual combo combo { get; set; }

        public void Map(comboproducts comboProduct)
        {
            this.id = comboProduct.id;
            this.combo = comboProduct.combo;
            this.product = comboProduct.product;
            this.product_amount = comboProduct.product_amount;
        }
    }
}

namespace DuLich.BanHang_Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("combo")]
    public partial class combo
    {
        public combo()
        {
            invoicedetails = new HashSet<invoicedetail>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public string combo_name { get; set; }

        [Required]
        public DateTime createtime { get; set; }

        [Required]
        public int discountpercent { get; set; }

        public virtual ICollection<invoicedetail> invoicedetails { get; set; }
        public virtual ICollection<comboproducts> comboproducts { get; set; }


        public void Map(combo combo)
        {
            this.id = combo.id;
            this.combo_name = combo.combo_name;
            this.comboproducts = combo.comboproducts;
            this.discountpercent = combo.discountpercent;
            this.createtime = combo.createtime;
            this.invoicedetails = combo.invoicedetails;
        }
    }
}

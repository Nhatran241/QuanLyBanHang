namespace DuLich.BanHang_Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("catalog")]
    public partial class catalog
    {
        public catalog()
        {
            products = new HashSet<product>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public string catalog_name { get; set; }
        public virtual ICollection<product> products { get; set; }

        public override string ToString()
        {
            return catalog_name;
        }
    }
}

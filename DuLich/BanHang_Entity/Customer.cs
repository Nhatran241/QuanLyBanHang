namespace DuLich.BanHang_Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("customer")]
    public partial class customer
    {
        public customer()
        {
            invoices = new HashSet<invoice>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public string firstname { get; set; }

        [Required]
        public string lastname { get; set; }

        [Required]
        public bool gender { get; set; }

        [Required]
        public DateTime birthdate { get; set; }

        [Required]
        public string address { get; set; }

        [Required]
        public DateTime joindate { get; set; }

        public bool isnew { get; set; }

        public virtual ICollection<invoice> invoices { get; set; }

        public override string ToString()
        {
            return firstname +" "+ lastname;
        }
    }
}

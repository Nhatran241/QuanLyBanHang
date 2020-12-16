namespace DuLich.BanHang_Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("employee")]
    public partial class employee
    {
        public employee()
        {
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

        public bool gender { get; set; }

        [Required]
        public DateTime birthdate { get; set; }

        [Required]
        public string address { get; set; }

        [Required]
        public DateTime joindate { get; set; }

        public virtual role role { get; set; }
    }
}

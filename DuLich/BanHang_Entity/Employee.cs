namespace DuLich.BanHang_Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        public Employee()
        {
            Invoices = new HashSet<Invoice>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public string firstName { get; set; }

        [Required]
        public string lastName { get; set; }

        public bool gender { get; set; }

        [Required]
        public DateTime birthDate { get; set; }

        [Required]
        public string address { get; set; }

        [Required]
        public DateTime joinDate { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}

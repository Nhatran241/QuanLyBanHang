namespace DuLich.BanHang_Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Invoice")]
    public partial class Invoice
    {
        public Invoice()
        {
            InvoiceDetails = new HashSet<InvoiceDetail>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Invoice_Name { get; set; }
        [Required]
        public long totalMoney { get; set; }
        [Required]
        public DateTime createdDate { get; set; }
        [Required]
        public string customerAddress { get; set; }
        [Required]
        public DateTime shipDate { get; set; }
        public int status { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Shipper { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}

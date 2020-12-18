namespace DuLich.BanHang_Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Threading.Tasks;

    [Table("invoice")]
    public partial class invoice
    {
        public invoice()
        {
            invoicedetails = new HashSet<invoicedetail>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public string invoice_name { get; set; }
        [Required]
        public long totalmoney { get; set; }
        [Required]
        public DateTime createddate { get; set; }
        [Required]
        public string customeraddress { get; set; }
        [Required]
        public DateTime shipdate { get; set; }
        public int status { get; set; }
        public virtual customer customer { get; set; }
        public virtual ICollection<invoicedetail> invoicedetails { get; set; }

        public void Map(invoice invoice)
        {
            this.id = invoice.id;
            this.createddate = invoice.createddate;
            this.customer = invoice.customer;
            this.customeraddress = invoice.customeraddress;
            this.invoicedetails = invoice.invoicedetails;
            this.invoice_name = invoice.invoice_name;
            this.shipdate = invoice.shipdate;
            this.status = invoice.status;
            this.totalmoney = invoice.totalmoney;
        }

     
    }
}

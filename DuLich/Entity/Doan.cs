using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuLich.BUS
{
    public partial class Doan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaDoan { get; set; }
        public String TenDoan { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public virtual Gia GiaApDung { get; set; }
        public virtual Tour Tour { get; set; }
        public virtual ICollection<DoanKhach> DoanKhach { get; set; }
        public virtual ICollection<PhanCong> PhanCong { get; set; }
        public virtual ICollection<ChiPhi> ChiPhi { get; set; }
    }
}

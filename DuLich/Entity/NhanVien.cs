using DuLich.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DuLich.BUS
{
    public partial class NhanVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaNhanVien { get; set; }
        public String TenNhanVien { get; set; }
        public String DiaChi { get; set; }
        public String SoDienThoai { get; set; }
        public String SoCmnd { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public virtual ICollection<PhanCong> PhanCong { get; set; }
        public override string ToString()
        {
            return TenNhanVien;
        }
    }
}

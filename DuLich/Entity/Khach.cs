using DuLich.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace DuLich.BUS
{
    public partial class Khach
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaKhach { get; set; }
        public String TenKhach { get; set; }
        public String DiaChi { get; set; }
        public String SoDienThoai { get; set; }
        public String SoCmnd { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public virtual ICollection<DoanKhach> DoanKhach { get; set; }
        public override string ToString()
        {
            return TenKhach;
        }

    }
}

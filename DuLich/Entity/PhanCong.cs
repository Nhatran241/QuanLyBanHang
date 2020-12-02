using DuLich.DAL;
using DuLich.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich.BUS
{
    public class PhanCong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaPhanCong { get; set; }
        public virtual Doan Doan { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public String NhiemVu { get; set; }

        public void Map(PhanCong editPhanCong)
        {
            MaPhanCong = editPhanCong.MaPhanCong;
            Doan = editPhanCong.Doan;
            NhanVien = editPhanCong.NhanVien;
            NhiemVu = editPhanCong.NhiemVu;
        }
    }
}

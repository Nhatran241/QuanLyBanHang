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
        public Task AddOrUpdate()
        {
            return KhachDal.AddOrUpdate(this);
        }
        public Task Delete()
        {
            return KhachDal.Delete(this);
        }
        public void Map(Khach khach)
        {
            DiaChi = khach.DiaChi;
            DoanKhach = khach.DoanKhach;
            GioiTinh = khach.GioiTinh;
            MaKhach = khach.MaKhach;
            NgaySinh = khach.NgaySinh;
            SoCmnd = khach.SoCmnd;
            SoDienThoai = khach.SoDienThoai;
            TenKhach = khach.TenKhach;
        }
    }
}

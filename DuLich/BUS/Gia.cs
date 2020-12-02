using DuLich.DAL;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace DuLich.BUS
{
    public partial class Gia
    {
        public Task AddOrUpdate()
        {
            return GiaDal.AddOrUpdate(this);
        }
        public Task Delete()
        {
            return GiaDal.Delete(this);
        }

        public void Map(Gia editGia)
        {
            MaGia = editGia.MaGia;
            GiaTri = editGia.GiaTri;
            ThoiGianBatDau = editGia.ThoiGianBatDau;
            ThoiGianKetThuc = editGia.ThoiGianKetThuc;
            Tour = editGia.Tour;

        }
    }
}

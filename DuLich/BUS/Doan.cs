using DuLich.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DuLich.BUS
{
    public partial class Doan
    {
        public Task AddOrUpdate()
        {
            return DoanDal.AddOrUpdate(this);
        }
        public Task Delete()
        {
            return DoanDal.Delete(this);
        }

        public void DeleteAllKhach()
        {
            DoanDal.DeleteAllKhach(this);
        }
        public void Map(Doan doan)
        {
            ChiPhi = doan.ChiPhi;
            DoanKhach = doan.DoanKhach;
            GiaApDung = doan.GiaApDung;
            MaDoan = doan.MaDoan;
            TenDoan = doan.TenDoan;
            PhanCong = doan.PhanCong;
            ThoiGianBatDau = doan.ThoiGianBatDau;
            ThoiGianKetThuc = doan.ThoiGianKetThuc;
            Tour = doan.Tour;

        }

        public Task UpdateListDoanKhach(List<Khach> danhSachKhachTrongDoanUpdate)
        {
            List<DoanKhach> danhSachDoanKhach = new List<DoanKhach>();
            foreach (Khach khach in danhSachKhachTrongDoanUpdate)
            {
                DoanKhach doanKhach = new DoanKhach();
                doanKhach.Doan = this;
                doanKhach.Khach = khach;
                danhSachDoanKhach.Add(doanKhach);
            }
            return DoanDal.UpdateListDoanKhach(danhSachDoanKhach);

        }

        public List<PhanCong> GetListPhanCong()
        {
            if (PhanCong == null)
                return new List<PhanCong>();
            return PhanCong.ToList();
        }

        public List<ChiPhi> GetListChiPhi()
        {
            if (ChiPhi == null)
                return new List<ChiPhi>();
            return ChiPhi.ToList();
        }

        public List<Khach> GetListKhach()
        {
            List<Khach> listKhack = new List<Khach>();
            if (DoanKhach == null)
                return listKhack;
            foreach(DoanKhach doanKhach in DoanKhach)
            {
                listKhack.Add(doanKhach.Khach);
            }
            return listKhack;
        }

        public double TongChiPhiDoan()
        {
            if (ChiPhi == null)
                return 0;
            return ChiPhi.Sum(c => c.GiaTri);
        }

        public Task DeleteChiPhi(ChiPhi chiPhi)
        {
            return DoanDal.DeleteChiPhi(chiPhi);
        }

        public Task AddOrUpdateChiPhi(ChiPhi chiPhi)
        {
            return DoanDal.AddOrUpdateChiPhi(chiPhi);
        }

        public Task DeletePhanCong(PhanCong phanCong)
        {
            return DoanDal.DeletePhanCong(phanCong);
        }

        public Task AddOrUpdatePhanCong(PhanCong phanCong)
        {
            return DoanDal.AddOrUpdatePhanCong(phanCong);
        }
    }
}

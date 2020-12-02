using DuLich.BUS;
using DuLich.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace DuLich.DAL
{
    class DoanDal
    {
        static DuLichContext context = DuLichContext.GetInstance();

        public static List<Doan> GetAll()
        {
            return context.Doans.ToList();
        }
        public static Task AddOrUpdate(Doan doan)
        {
            context.Doans.AddOrUpdate(doan);
            return context.SaveChangesAsync();
        }
        public static Task Delete(Doan doan)
        {
            context.Doans.Remove(doan);
            return context.SaveChangesAsync();
        }

        public static void DeleteAllKhach(Doan doan)
        {
            if (doan.DoanKhach != null)
                context.DoanKhachs.RemoveRange(doan.DoanKhach);
        }

        public static Task UpdateListDoanKhach(List<DoanKhach> danhSachDoanKhach)
        {
            foreach(DoanKhach doanKhach in danhSachDoanKhach)
            {
                context.DoanKhachs.AddOrUpdate(doanKhach);
            }
            return context.SaveChangesAsync();
        }

        public static Task DeleteChiPhi(ChiPhi chiPhi)
        {
            context.ChiPhis.Remove(chiPhi);
            return context.SaveChangesAsync();
        }

        public static Task AddOrUpdateChiPhi(ChiPhi chiPhi)
        {
            var result = context.ChiPhis.SingleOrDefault(b => b.MaChiPhi == chiPhi.MaChiPhi);
            if (result != null)
            {
                result.Doan = chiPhi.Doan;
                result.GhiChu = chiPhi.GhiChu;
                result.GiaTri = chiPhi.GiaTri;
                result.LoaiChiPhi = chiPhi.LoaiChiPhi;
                return context.SaveChangesAsync();
            }
            else
            {
                context.ChiPhis.Add(chiPhi);
                return context.SaveChangesAsync();
            }
        }


        public static Task DeletePhanCong(PhanCong phanCong)
        {
            context.PhanCongs.Remove(phanCong);
            return context.SaveChangesAsync();
        }

        public static Task AddOrUpdatePhanCong(PhanCong phanCong)
        {
            var result = context.PhanCongs.SingleOrDefault(b => b.MaPhanCong == phanCong.MaPhanCong);
            if (result != null)
            {
                result.NhanVien = phanCong.NhanVien;
                result.Doan = phanCong.Doan;
                result.NhiemVu = phanCong.NhiemVu;
                return context.SaveChangesAsync();
            }
            else
            {
                context.PhanCongs.Add(phanCong);
                return context.SaveChangesAsync();
            }
        }
    }
}

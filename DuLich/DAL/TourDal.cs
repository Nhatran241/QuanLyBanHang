using DuLich.BUS;
using DuLich.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace DuLich.DAL
{
    class TourDal
    {
        static DuLichContext context = DuLichContext.GetInstance();


        public static List<Tour> GetAll()
        {
            return context.Touris.ToList();
        }
        public static Task AddOrUpdate(Tour tour)
        {
            var result = context.Touris.SingleOrDefault(b => b.MaTour == tour.MaTour);
            if (result != null)
            {
                result.ChiTietTour = tour.ChiTietTour;
                result.DoanTour = tour.DoanTour;
                result.GiaTour = tour.GiaTour;
                result.LoaiTour = tour.LoaiTour;
                result.TenTour = tour.TenTour;
                return context.SaveChangesAsync();
            }
            else
            {
                context.Touris.Add(tour);
                return context.SaveChangesAsync();
            }
        }
        public static Task Delete(Tour touris)
        {
            var result = context.Touris.SingleOrDefault(b => b.MaTour == touris.MaTour);
            if (result != null)
            {
                context.Touris.Remove(touris);
            }
            return context.SaveChangesAsync();
        }
        public static List<Doan> GetListDoanByTourId(int id)
        {
            return context.Doans.Where(c => c.Tour.MaTour == id).ToList();
        }

    

        public static List<DiaDiem> GetListDiaDiemByTour(Tour tour)
        {
            List<DiaDiem> danhSachDiaDiemCuaTor = new List<DiaDiem>();
            if (tour.ChiTietTour == null)
                return danhSachDiaDiemCuaTor;
            foreach (ChiTietTour chiTietTour in tour.ChiTietTour.OrderBy(c => c.ThuTu).ToList())
            {
                DiaDiem diaDiem = context.DiaDiem.Where(c => c.MaDienDiem == chiTietTour.DiaDiem.MaDienDiem).First();
                if (!danhSachDiaDiemCuaTor.Contains(diaDiem))
                    danhSachDiaDiemCuaTor.Add(diaDiem);
            }
            return danhSachDiaDiemCuaTor;
        }

        public static void DeleteAllChiTietByTour(Tour tour)
        {
            if (tour.ChiTietTour != null)
            {
                context.ChiTietTour.RemoveRange(tour.ChiTietTour);
            }
        }

        public static Task UpdateListDiaDiemTour(List<ChiTietTour> danhSachChiTietTour)
        {
            foreach(ChiTietTour chiTietTour in danhSachChiTietTour)
            {
                context.ChiTietTour.AddOrUpdate(chiTietTour);
            }
            return context.SaveChangesAsync();
        }

        public static List<Tour> GetListTourHasPrice()
        {
            return GetAll().Where(c => c.GiaTour!=null && c.GiaTour.Count >0).ToList();
        }

       
    }
}

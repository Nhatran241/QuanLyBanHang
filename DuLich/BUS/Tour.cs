using DuLich.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuLich.BUS
{
    public partial class Tour
    {
        public Task AddOrUpdate()
        {
            return TourDal.AddOrUpdate(this);
        }
        public Task Delete()
        {
            return TourDal.Delete(this);
        }
        public List<Doan> GetListDoanOfTour()
        {
            if (DoanTour == null)
                return new List<Doan>();
            return DoanTour.ToList();
        }

        public List<Doan> GetListDoanOfTourWithPrice(Gia gia)
        {
            if (DoanTour == null)
                return new List<Doan>();
            return DoanTour.Where(c=>c.GiaApDung.MaGia == gia.MaGia).ToList();
        }

        public List<Khach> GetListKhachOfTour()
        {
            List<Khach> khachTrongTour = new List<Khach>();
            if (DoanTour != null)
            {
                foreach (Doan doan in DoanTour)
                {
                    if (doan.DoanKhach != null)
                    {
                        foreach(DoanKhach doanKhach in doan.DoanKhach)
                        {
                            khachTrongTour.Add(doanKhach.Khach);
                        }
                    }
                }
            }
            return khachTrongTour.Distinct().ToList();
        }
        public List<Khach> GetListKhachOfTourByTime(DateTime from,DateTime to)
        {
            List<Khach> khachTrongTour = new List<Khach>();
            if (DoanTour != null)
            {
                foreach (Doan doan in DoanTour.Where(c=>c.ThoiGianBatDau>=from && c.ThoiGianKetThuc<=to))
                {
                    if (doan.DoanKhach != null)
                    {
                        foreach (DoanKhach doanKhach in doan.DoanKhach)
                        {
                            khachTrongTour.Add(doanKhach.Khach);
                        }
                    }
                }
            }
            return khachTrongTour.ToList();
        }

        public List<DiaDiem> GetListDiaDiemOfTour()
        {
            return TourDal.GetListDiaDiemByTour(this);
        }

        public List<Gia> GetListGiaOfTour()
        {
            if (GiaTour == null)
                return new List<Gia>();
            return GiaTour.ToList();
        }

        public void DeleteAllChiTietTour()
        {
            TourDal.DeleteAllChiTietByTour(this);
        }

        public double TongDoanhThuTourByTime(DateTime from, DateTime to)
        {
            return GetListDoanOfTourByTime(from,to).Where(c=>c.GiaApDung != null).Sum(c => c.GiaApDung.GiaTri*c.DoanKhach.Count());
        }
        public double TongChiPhiTourByTime(DateTime from, DateTime to)
        {
            List<Doan> listDoan = GetListDoanOfTourByTime(from, to);
            double tongChiPhi = 0;
            foreach(Doan doan in listDoan)
            {
                tongChiPhi +=doan.TongChiPhiDoan();
            }
            return tongChiPhi;
        }

        public Task UpdateListDiaDiemTour(List<DiaDiem> danhSachDiaDiemTrongDoanUpdate)
        {
            List<ChiTietTour> danhSachChiTietTour = new List<ChiTietTour>();
            for (int i = 0; i < danhSachDiaDiemTrongDoanUpdate.Count(); i++)
            {
                ChiTietTour chiTietTour = new ChiTietTour();
                chiTietTour.DiaDiem = danhSachDiaDiemTrongDoanUpdate.ToArray()[i];
                chiTietTour.Tour = this;
                chiTietTour.ThuTu = i + 1;
                danhSachChiTietTour.Add(chiTietTour);
            }
            return TourDal.UpdateListDiaDiemTour(danhSachChiTietTour);
        }

        public List<Doan> GetListDoanOfTourByTime(DateTime from, DateTime to)
        {
            return GetListDoanOfTour().Where(c => c.ThoiGianBatDau >= from && c.ThoiGianKetThuc <= to).ToList();
        }
        public void Map(Tour editTour)
        {
            MaTour = editTour.MaTour;
            ChiTietTour = editTour.ChiTietTour;
            DoanTour = editTour.DoanTour;
            ChiTietTour = editTour.ChiTietTour;
            LoaiTour = editTour.LoaiTour;
            TenTour = editTour.TenTour;
        }
    }
}

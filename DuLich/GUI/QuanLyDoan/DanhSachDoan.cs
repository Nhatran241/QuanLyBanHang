using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DuLich.BUS;

namespace DuLich.GUI.QuanLyDoan
{
    public partial class DanhSachDoan : UserControl,SearchDoan.ISearchDoanListener
    {
        private IDanhSachDoanListener danhSachDoanListener;
        private List<Doan> danhSachDoan;
        private List<Tour> danhSachTour;
        private List<NhanVien> danhSachNhanVien;
        private List<Khach> danhSachKhach;

        public DanhSachDoan(List<Doan> doans, List<Tour> tours,List<NhanVien> nhanViens,List<Khach> khaches,IDanhSachDoanListener danhSachDoanListener)
        {
            InitializeComponent();
            danhSachDoan = doans;
            danhSachKhach = khaches;
            danhSachNhanVien = nhanViens;
            danhSachTour = tours;
            this.danhSachDoanListener = danhSachDoanListener;
            InitData();
        }
     

        private void OnDoanDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int position = dataGridViewDoan.CurrentCell.RowIndex;
            danhSachDoanListener.onDanhSachDoan_DoanDoubleClick(danhSachDoan.ToList()[position]);
        }


        private void InitData()
        {
            dataGridViewDoan.DataSource = danhSachDoan.ToList();
            if(danhSachDoan.Count != 0)
            {
                DateTime min = danhSachDoan.First().ThoiGianBatDau;
                DateTime max = danhSachDoan.First().ThoiGianKetThuc;
                foreach (Doan doan in danhSachDoan)
                {
                    if (doan.ThoiGianBatDau < min)
                        min = doan.ThoiGianBatDau;
                    if (doan.ThoiGianKetThuc > max)
                        max = doan.ThoiGianKetThuc;
                }
                searchDoan1.SetData(danhSachTour, danhSachNhanVien, danhSachKhach, min, max, this);
            }
            else searchDoan1.SetData(danhSachTour, danhSachNhanVien, danhSachKhach, DateTime.MinValue, DateTime.MaxValue, this);
        }

        public void onSearchDoan(Tour tour, string ten, NhanVien nhanVien, Khach khach, DateTime min, DateTime max)
        {
            if (!ten.Equals(""))
            {
                if (tour.MaTour == -1)
                {
                    if(nhanVien.MaNhanVien == -1)
                    {
                        if(khach.MaKhach == -1)
                        {
                            dataGridViewDoan.DataSource = danhSachDoan.Where(c => c.TenDoan.ToLower().Contains(ten)&&c.ThoiGianBatDau>= min && c.ThoiGianKetThuc <=max).ToList();
                        }
                        else
                        {
                            dataGridViewDoan.DataSource = danhSachDoan.Where(c => c.TenDoan.ToLower().Contains(ten)
                            &&(c.DoanKhach!=null &&c.DoanKhach.Where(d=>d.Khach.MaKhach == khach.MaKhach).Any())
                            && c.ThoiGianBatDau >= min && c.ThoiGianKetThuc <= max).ToList();
                        }
                    }
                    else
                    {

                        if (khach.MaKhach == -1)
                        {
                            dataGridViewDoan.DataSource = danhSachDoan.Where(c => c.TenDoan.ToLower().Contains(ten)
                            && (c.PhanCong!=null &&c.PhanCong.Where(d => d.NhanVien.MaNhanVien == nhanVien.MaNhanVien).Any())
                            && c.ThoiGianBatDau >= min && c.ThoiGianKetThuc <= max).ToList();
                        }
                        else
                        {
                            dataGridViewDoan.DataSource = danhSachDoan.Where(c => c.TenDoan.ToLower().Contains(ten)
                            && (c.PhanCong!=null&&c.PhanCong.Where(d => d.NhanVien.MaNhanVien == nhanVien.MaNhanVien).Any())
                            && (c.DoanKhach!= null&&c.DoanKhach.Where(d => d.Khach.MaKhach == khach.MaKhach).Any())
                            && c.ThoiGianBatDau >= min && c.ThoiGianKetThuc <= max).ToList();
                        }
                    }
                }
                else
                {
                    if (nhanVien.MaNhanVien == -1)
                    {
                        if (khach.MaKhach == -1)
                        {
                            dataGridViewDoan.DataSource = danhSachDoan.Where(c => c.TenDoan.ToLower().Contains(ten)
                            && c.Tour.MaTour == tour.MaTour
                            && c.ThoiGianBatDau >= min && c.ThoiGianKetThuc <= max).ToList();
                        }
                        else
                        {
                            dataGridViewDoan.DataSource = danhSachDoan.Where(c => c.TenDoan.ToLower().Contains(ten)
                            && c.Tour.MaTour == tour.MaTour
                            && (c.DoanKhach!=null&&c.DoanKhach.Where(d => d.Khach.MaKhach == khach.MaKhach).Any())
                            && c.ThoiGianBatDau >= min && c.ThoiGianKetThuc <= max).ToList();
                        }
                    }
                    else
                    {

                        if (khach.MaKhach == -1)
                        {
                            dataGridViewDoan.DataSource = danhSachDoan.Where(c => c.TenDoan.ToLower().Contains(ten)
                            && c.Tour.MaTour == tour.MaTour
                            && (c.PhanCong!=null&&c.PhanCong.Where(d => d.NhanVien.MaNhanVien == nhanVien.MaNhanVien).Any())
                            && c.ThoiGianBatDau >= min && c.ThoiGianKetThuc <= max).ToList();
                        }
                        else
                        {
                            dataGridViewDoan.DataSource = danhSachDoan.Where(c => c.TenDoan.ToLower().Contains(ten)
                            && c.Tour.MaTour == tour.MaTour
                            && (c.PhanCong!=null&&c.PhanCong.Where(d => d.NhanVien.MaNhanVien == nhanVien.MaNhanVien).Any())
                            && (c.DoanKhach!=null&&c.DoanKhach.Where(d => d.Khach.MaKhach == khach.MaKhach).Any())
                            && c.ThoiGianBatDau >= min && c.ThoiGianKetThuc <= max).ToList();
                        }
                    }
                }
            }
            else
            {
                if (tour.MaTour == -1)
                {
                    if (nhanVien.MaNhanVien == -1)
                    {
                        if (khach.MaKhach == -1)
                        {
                            dataGridViewDoan.DataSource = danhSachDoan.Where(c =>c.ThoiGianBatDau >= min && c.ThoiGianKetThuc <= max).ToList();
                        }
                        else
                        {
                            dataGridViewDoan.DataSource = danhSachDoan.Where(c => 
                            (c.DoanKhach!=null&&c.DoanKhach.Where(d => (d.Khach != null ? d.Khach.MaKhach == khach.MaKhach : true)).Any())
                            && c.ThoiGianBatDau >= min && c.ThoiGianKetThuc <= max).ToList();
                        }
                    }
                    else
                    {

                        if (khach.MaKhach == -1)
                        {
                            dataGridViewDoan.DataSource = danhSachDoan.Where(c =>
                            (c.PhanCong!=null&&c.PhanCong.Where(d => d.NhanVien.MaNhanVien == nhanVien.MaNhanVien).Any())
                            && c.ThoiGianBatDau >= min && c.ThoiGianKetThuc <= max).ToList();
                        }
                        else
                        {
                            dataGridViewDoan.DataSource = danhSachDoan.Where(c => 
                            (c.PhanCong!=null&&c.PhanCong.Where(d => d.NhanVien.MaNhanVien == nhanVien.MaNhanVien).Any())
                            && (c.DoanKhach!=null&&c.DoanKhach.Where(d => d.Khach.MaKhach == khach.MaKhach).Any())
                            && c.ThoiGianBatDau >= min && c.ThoiGianKetThuc <= max).ToList();
                        }
                    }
                }
                else
                {
                    if (nhanVien.MaNhanVien == -1)
                    {
                        if (khach.MaKhach == -1)
                        {
                            dataGridViewDoan.DataSource = danhSachDoan.Where(c => 
                            c.Tour.MaTour == tour.MaTour
                            && c.ThoiGianBatDau >= min && c.ThoiGianKetThuc <= max).ToList();
                        }
                        else
                        {
                            dataGridViewDoan.DataSource = danhSachDoan.Where(c => 
                            c.Tour.MaTour == tour.MaTour
                            && (c.DoanKhach!= null &&c.DoanKhach.Where(d => d.Khach.MaKhach == khach.MaKhach).Any())
                            && c.ThoiGianBatDau >= min && c.ThoiGianKetThuc <= max).ToList();
                        }
                    }
                    else
                    {

                        if (khach.MaKhach == -1)
                        {
                            dataGridViewDoan.DataSource = danhSachDoan.Where(c => 
                            c.Tour.MaTour == tour.MaTour
                            && (c.PhanCong!=null&&c.PhanCong.Where(d => d.NhanVien.MaNhanVien == nhanVien.MaNhanVien).Any())
                            && c.ThoiGianBatDau >= min && c.ThoiGianKetThuc <= max).ToList();
                        }
                        else
                        {
                            dataGridViewDoan.DataSource = danhSachDoan.Where(c => 
                            c.Tour.MaTour == tour.MaTour
                            && (c.PhanCong!=null&&c.PhanCong.Where(d => d.NhanVien.MaNhanVien == nhanVien.MaNhanVien).Any())
                            && (c.DoanKhach!=null&&c.DoanKhach.Where(d => d.Khach.MaKhach == khach.MaKhach).Any())
                            && c.ThoiGianBatDau >= min && c.ThoiGianKetThuc <= max).ToList();
                        }
                    }
                }
            }
        }

        public interface IDanhSachDoanListener
        {
            void onDanhSachDoan_DoanDoubleClick(Doan doan);
            void onDanhSachDoan_ThemClick();
            void onDanhSachDoan_XoaClick(Doan doan);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(dataGridViewDoan.CurrentCell != null)
            {
                int position = dataGridViewDoan.CurrentCell.RowIndex;
                danhSachDoanListener.onDanhSachDoan_XoaClick(danhSachDoan[position]);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            danhSachDoanListener.onDanhSachDoan_ThemClick();
        }

        private void DanhSachDoan_Load(object sender, EventArgs e)
        {

        }
    }
}

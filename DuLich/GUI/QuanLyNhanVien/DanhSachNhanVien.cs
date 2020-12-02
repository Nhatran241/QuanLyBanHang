using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DuLich.BUS;

namespace DuLich.GUI.QuanLyNhanVien
{
    public partial class DanhSachNhanVien : UserControl,SearchNhanVien.ISearchNhanVienListener
    {
        private IDanhSachNhanVienListener danhSachNhanVienListener;
        private List<NhanVien> danhSachNhanVien;
        public DanhSachNhanVien(List<NhanVien> danhSachNhanVien, IDanhSachNhanVienListener danhSachNhanVienListener)
        {
            InitializeComponent();
            this.danhSachNhanVienListener = danhSachNhanVienListener;
            this.danhSachNhanVien = danhSachNhanVien;
            InitData();
        }
        private void InitData()
        {
            dataGridViewNhanVien.DataSource = danhSachNhanVien;
            if(danhSachNhanVien.Count > 0)
            {
                DateTime min = danhSachNhanVien.First().NgaySinh;
                DateTime max = danhSachNhanVien.First().NgaySinh;
                foreach (NhanVien nhanVien in danhSachNhanVien)
                {
                    if (nhanVien.NgaySinh < min)
                        min = nhanVien.NgaySinh;

                    if (nhanVien.NgaySinh > max)
                        max = nhanVien.NgaySinh;
                }
                searchNhanVien1.SetData(this, min, max);
            }else searchNhanVien1.SetData(this, DateTime.MinValue, DateTime.MaxValue);

        }
        private void listview_nhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = dataGridViewNhanVien.CurrentCell.RowIndex;
            if (position > 0)
            {
                btn_sua_nhanvien.Visible = true;
                btn_xoa_nhanvien.Visible = true;
            }
            else
            {
                btn_sua_nhanvien.Visible = false;
                btn_xoa_nhanvien.Visible = false;
            }
        }
        public interface IDanhSachNhanVienListener
        {
            void onDanhSachNhanVien_ThemClick();
            void onDanhSachNhanVien_SuaClick(NhanVien nhanVien);
            void onDanhSachNhanVien_XoaClick(NhanVien nhanVien);
        }

        private void btn_them_nhanvien_Click(object sender, EventArgs e)
        {
            danhSachNhanVienListener.onDanhSachNhanVien_ThemClick();
        }

        private void btn_xoa_nhanvien_Click(object sender, EventArgs e)
        {
            int position = dataGridViewNhanVien.CurrentCell.RowIndex;
            danhSachNhanVienListener.onDanhSachNhanVien_XoaClick(danhSachNhanVien.ToArray()[position]);
        }

        private void btn_sua_nhanvien_Click(object sender, EventArgs e)
        {
            int position = dataGridViewNhanVien.CurrentCell.RowIndex;
            danhSachNhanVienListener.onDanhSachNhanVien_SuaClick(danhSachNhanVien.ToArray()[position]);

        }

        public void onSearchNhanVien(string ten,string gioitinh, DateTime min, DateTime max)
        {
            if (ten.Equals(""))
            {
                if(gioitinh.Equals("Bất kỳ"))
                {
                    dataGridViewNhanVien.DataSource = danhSachNhanVien.Where(c => c.NgaySinh >= min && c.NgaySinh <= max).ToList();
                }
                else dataGridViewNhanVien.DataSource = danhSachNhanVien.Where(c => c.NgaySinh >= min && c.NgaySinh <= max&&c.GioiTinh.Equals(gioitinh)).ToList();
            }
            else
            {
                if(gioitinh.Equals("Bất kỳ"))
                {
                    dataGridViewNhanVien.DataSource = danhSachNhanVien.Where(c => c.NgaySinh >= min && c.NgaySinh <= max && c.TenNhanVien.ToLower().Contains(ten)).ToList();
                }else dataGridViewNhanVien.DataSource = danhSachNhanVien.Where(c => c.NgaySinh >= min && c.NgaySinh <= max && c.TenNhanVien.ToLower().Contains(ten) && c.GioiTinh.Equals(gioitinh)).ToList();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DuLich.BUS;

namespace DuLich.GUI.QuanLyKhach
{
    public partial class DanhSachKhach : UserControl,SearchKhach.ISearchKhachListener
    {
        private IDanhSachKhachListener danhSachKhachListener;
        private List<Khach> danhSachKhach;
        public DanhSachKhach(List<Khach> danhSachKhach, IDanhSachKhachListener danhSachKhachListener)
        {
            InitializeComponent();
            this.danhSachKhachListener = danhSachKhachListener;
            this.danhSachKhach = danhSachKhach;
            InitData();
        }
        private void InitData()
        {
            dataGridviewKhach.DataSource = danhSachKhach;
            if(danhSachKhach.Count > 0)
            {
                DateTime min = danhSachKhach.First().NgaySinh;
                DateTime max = danhSachKhach.First().NgaySinh;
                foreach (Khach khach in danhSachKhach)
                {
                    if (khach.NgaySinh < min)
                        min = khach.NgaySinh;

                    if (khach.NgaySinh > max)
                        max = khach.NgaySinh;
                }
                searchKhach1.SetData(this, min, max);
            }else searchKhach1.SetData(this,DateTime.MinValue,DateTime.MaxValue);

        }
        public interface IDanhSachKhachListener
        {
            void onDanhSachKhach_ThemClick();
            void onDanhSachKhach_SuaClick(Khach khach);
            void onDanhSachKhach_XoaClick(Khach khach);
        }

      

        public void onSeachKhach(string ten, string gioitinh, DateTime min, DateTime max)
        {
            if (ten.Equals(""))
            {
                if (gioitinh.Equals("Bất kỳ"))
                {
                    dataGridviewKhach.DataSource = danhSachKhach.Where(c => c.NgaySinh >= min && c.NgaySinh <= max).ToList();
                }
                else dataGridviewKhach.DataSource = danhSachKhach.Where(c => c.NgaySinh >= min && c.NgaySinh <= max && c.GioiTinh.Equals(gioitinh)).ToList();
            }
            else
            {
                if (gioitinh.Equals("Bất kỳ"))
                {
                    dataGridviewKhach.DataSource = danhSachKhach.Where(c => c.NgaySinh >= min && c.NgaySinh <= max && c.TenKhach.ToLower().Contains(ten)).ToList();
                }
                else dataGridviewKhach.DataSource = danhSachKhach.Where(c => c.NgaySinh >= min && c.NgaySinh <= max && c.TenKhach.ToLower().Contains(ten) && c.GioiTinh.Equals(gioitinh)).ToList();
            }
        }

        private void btn_them_khach_Click(object sender, EventArgs e)
        {

            danhSachKhachListener.onDanhSachKhach_ThemClick();
           
        }

        private void btn_sua_khach_Click(object sender, EventArgs e)
        {
            if (dataGridviewKhach.CurrentCell != null)
            {
                int position = dataGridviewKhach.CurrentCell.RowIndex;
                danhSachKhachListener.onDanhSachKhach_SuaClick(danhSachKhach[position]);
            }

        }

        private void btn_xoa_khach_Click(object sender, EventArgs e)
        {
            if (dataGridviewKhach.CurrentCell != null)
            {
                int position = dataGridviewKhach.CurrentCell.RowIndex;
                danhSachKhachListener.onDanhSachKhach_XoaClick(danhSachKhach[position]);
            }
        }

        private void searchKhach1_Load(object sender, EventArgs e)
        {

        }
    }
}

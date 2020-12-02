using DuLich.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DuLich.GUI.QuanLyPhanCong
{
    public partial class ChiTietPhanCong : Form
    {
        private IChiTietPhanCongListener chiTietPhanCongListener;
        private PhanCong basePhanCong;
        private PhanCong editPhanCong;
        private List<NhanVien> danhSachNhanVien = new List<NhanVien>();
        private List<String> danhSachNhiemVu;
        private bool isEditing = false;
        public ChiTietPhanCong(PhanCong phanCong, List<NhanVien> danhSachNhanVien, IChiTietPhanCongListener chiTietPhanCongListener)
        {
            InitializeComponent();
            basePhanCong = phanCong;

            editPhanCong = new PhanCong();
            editPhanCong.Map(phanCong);

            danhSachNhiemVu = new List<string>();
            danhSachNhiemVu.Add("Hướng Dẫn Viên");
            danhSachNhiemVu.Add("Lái Xe");
            danhSachNhiemVu.Add("Trưởng Đoàn");
            this.chiTietPhanCongListener = chiTietPhanCongListener;
            this.danhSachNhanVien.AddRange(danhSachNhanVien);
            if (editPhanCong.MaPhanCong == 0)
            {
                editPhanCong.NhanVien = danhSachNhanVien.First();
                editPhanCong.NhiemVu = danhSachNhiemVu.First();
            }
            InitUI();
        }
       
        private void InitUI()
        {
            if (editPhanCong.MaPhanCong != 0)
            {
                tb_maphancong.Text = editPhanCong.MaPhanCong.ToString();
            }
            else tb_maphancong.Text = "Mã tự động";
            tb_maphancong.Enabled = false;
            foreach(NhanVien nhanVien in danhSachNhanVien)
            {
                combobox_nhanvien.Items.Add(nhanVien);
            }
            combobox_nhanvien.SelectedItem = editPhanCong.NhanVien;
            foreach(String nv in danhSachNhiemVu)
            {
                cb_nhiemvu.Items.Add(nv);
            }
            cb_nhiemvu.SelectedItem = editPhanCong.NhiemVu;

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (Validation(editPhanCong))
            {
                basePhanCong.Map(editPhanCong);
                chiTietPhanCongListener.onChiTietPhanCong_LuuClick(basePhanCong.Doan, basePhanCong);
            }
            else
            {
                MessageBox.Show("Giá trị không được bỏ trống");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            chiTietPhanCongListener.onChiTietPhanCong_HuyClick();
        }
        public interface IChiTietPhanCongListener
        {
            void onChiTietPhanCong_LuuClick(Doan doanHienTai, PhanCong phanCong);
            void onChiTietPhanCong_HuyClick();
        }
        private bool Validation(PhanCong phanCong)
        {
            return true;
        }

        private void tb_maphancong_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_nhiemvu_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            editPhanCong.NhiemVu = danhSachNhiemVu.ToArray()[cb_nhiemvu.SelectedIndex];
        }

        private void combobox_nhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {

            editPhanCong.NhanVien = danhSachNhanVien.ToArray()[combobox_nhanvien.SelectedIndex];
        }
    }
}

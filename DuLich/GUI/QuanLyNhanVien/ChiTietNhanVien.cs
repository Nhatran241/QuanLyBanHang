using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DuLich.BUS;
using System.Text.RegularExpressions;

namespace DuLich.GUI.QuanLyNhanVien
{
    public partial class ChiTietNhanVien : Form
    {
        private IChiTietNhanVienListener chiTietNhanVienListener;
        private NhanVien baseNhanVien;
        private NhanVien editNhanVien;
        private bool isEditing = false;
        public ChiTietNhanVien(NhanVien nhanVien, IChiTietNhanVienListener chiTietNhanVienListener)
        {
            InitializeComponent();
            this.chiTietNhanVienListener = chiTietNhanVienListener;
            baseNhanVien = nhanVien;
            editNhanVien = new NhanVien();
            editNhanVien.Map(nhanVien);
            InitUI();
        }

        public interface IChiTietNhanVienListener
        {
            void onChiTietNhanVien_LuuClick(NhanVien nhanVien);
            void onChiTietNhanVien_HuyClick();
        }
        private void InitUI()
        {
            List<string> gioitinh = new List<string> { "Nam", "Nữ", "Khác" };
            foreach (string s in gioitinh)
            {
                cb_gioitinh.Items.Add(s);
            }
            if (editNhanVien.MaNhanVien != 0)
            {
                tb_name.Text = editNhanVien.TenNhanVien.ToString();
                tb_sdt.Text = editNhanVien.SoDienThoai.ToString();
                tb_diaChi.Text = editNhanVien.DiaChi.ToString();
                tb_cmnd.Text = editNhanVien.SoCmnd.ToString();
                datepicker_ngaysinh.Value = editNhanVien.NgaySinh;
                cb_gioitinh.SelectedItem = editNhanVien.GioiTinh;
            }else
            {
                cb_gioitinh.SelectedItem = gioitinh.First();
            }
            

            datepicker_ngaysinh.MaxDate = DateTime.Today.AddDays(-(18 * 365));
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
                editNhanVien.TenNhanVien = tb_name.Text.Trim();
        }

        private void tb_diaChi_TextChanged(object sender, EventArgs e)
        {
                editNhanVien.DiaChi = tb_diaChi.Text.Trim();
        }

        private void tb_sdt_TextChanged(object sender, EventArgs e)
        {
                editNhanVien.SoDienThoai = tb_sdt.Text.Trim();
        }

        private void tb_cmnd_TextChanged(object sender, EventArgs e)
        {
                editNhanVien.SoCmnd = tb_cmnd.Text.Trim();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(editNhanVien.TenNhanVien))
            {
                MessageBox.Show("Tên nhân viên không được để trống");
            }else
             if (string.IsNullOrEmpty(editNhanVien.DiaChi))
            {
                MessageBox.Show("Địa chỉ nhân viên không được để trống");
            }
            else
            if (string.IsNullOrEmpty(editNhanVien.SoDienThoai))
            {
                MessageBox.Show("Số điện thoại không được để trống");
            }else if (IsPhoneNumber(editNhanVien.SoDienThoai))
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
            }else
            if (string.IsNullOrEmpty(editNhanVien.SoCmnd))
            {
                MessageBox.Show("Số chứng minh nhân dân không được để trống");
            }else if (IsCmndNumber(editNhanVien.SoCmnd))
            {
                MessageBox.Show("Số chứng minh nhân dân không hợp lệ");
            }
            else
            {
                baseNhanVien.Map(editNhanVien);
                chiTietNhanVienListener.onChiTietNhanVien_LuuClick(baseNhanVien);
            }
        }
        public bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(\+[0-9]{9})$").Success;
        }
        public bool IsCmndNumber(string number)
        {
            return Regex.Match(number, @"^(\+[0-9])$").Success;
        }
        private void btn_huy_Click(object sender, EventArgs e)
        {
            chiTietNhanVienListener.onChiTietNhanVien_HuyClick();
        }

        private void datepicker_ngaysinh_ValueChanged(object sender, EventArgs e)
        {
            editNhanVien.NgaySinh = datepicker_ngaysinh.Value;
        }

        private void cb_gioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            editNhanVien.GioiTinh = (string)cb_gioitinh.SelectedItem;
        }

        private void tb_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void tb_cmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

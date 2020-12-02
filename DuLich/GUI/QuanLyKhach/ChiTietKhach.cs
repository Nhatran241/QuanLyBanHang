using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuLich.BUS;
using System.Text.RegularExpressions;

namespace DuLich.GUI.QuanLyKhach
{
    public partial class ChiTietKhach : Form
    {
        private IChiTietKhachListener chiTietKhachListener;
        private Khach baseKhach;
        private Khach editKhach;
        private bool isEditing = false;
        public ChiTietKhach(Khach khach,IChiTietKhachListener chiTietKhachListener)
        {
            InitializeComponent();
            this.chiTietKhachListener = chiTietKhachListener;
            baseKhach = khach;
            editKhach = new Khach();
            editKhach.Map(khach);
            InitUI();
        }

        public interface IChiTietKhachListener
        {
            void onLuuKhachClick(Khach khach);
            void onHuyKhachClick();
        }
        private void InitUI()
        {
            List<string> gioitinh = new List<string> { "Nam", "Nữ", "Khác" };
            foreach (string s in gioitinh)
            {
                cb_gioitinh.Items.Add(s);
            }
            if (editKhach.MaKhach != 0)
            {
                tb_name.Text = editKhach.TenKhach.ToString();
                tb_sdt.Text = editKhach.SoDienThoai.ToString();
                tb_diaChi.Text = editKhach.DiaChi.ToString();
                tb_cmnd.Text = editKhach.SoCmnd.ToString();
                datepicker_ngaysinh.Value = editKhach.NgaySinh;
                cb_gioitinh.SelectedItem = editKhach.GioiTinh;
            }
            else
            {
                cb_gioitinh.SelectedItem = gioitinh.First();
            }
            datepicker_ngaysinh.MaxDate = DateTime.Today;
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
                editKhach.TenKhach = tb_name.Text.Trim();
        }

        private void tb_diaChi_TextChanged(object sender, EventArgs e)
        {
                editKhach.DiaChi = tb_diaChi.Text.Trim();
        }

        private void tb_sdt_TextChanged(object sender, EventArgs e)
        {
                editKhach.SoDienThoai = tb_sdt.Text.Trim();
        }

        private void tb_cmnd_TextChanged(object sender, EventArgs e)
        {
                editKhach.SoCmnd = tb_cmnd.Text.Trim();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(editKhach.TenKhach))
            {
                MessageBox.Show("Tên khách không được để trống");
            }
            else
             if (string.IsNullOrEmpty(editKhach.DiaChi))
            {
                MessageBox.Show("Địa chỉ khách không được để trống");
            }
            else
            if (string.IsNullOrEmpty(editKhach.SoDienThoai))
            {
                MessageBox.Show("Số điện thoại không được để trống");
            }
            else if (IsPhoneNumber(editKhach.SoDienThoai))
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
            }
            else
           if (string.IsNullOrEmpty(editKhach.SoCmnd))
            {
                MessageBox.Show("Số chứng minh nhân dân không được để trống");
            }
            else if (IsCmndNumber(editKhach.SoCmnd))
            {
                MessageBox.Show("Số chứng minh nhân dân không hợp lệ");
            }
            else
            {
                baseKhach.Map(editKhach);
                chiTietKhachListener.onLuuKhachClick(baseKhach);
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
            chiTietKhachListener.onHuyKhachClick();
        }

        private void datepicker_ngaysinh_ValueChanged(object sender, EventArgs e)
        {
            editKhach.NgaySinh = datepicker_ngaysinh.Value;
        }

        private void cb_gioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            editKhach.GioiTinh = (string)cb_gioitinh.SelectedItem;
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

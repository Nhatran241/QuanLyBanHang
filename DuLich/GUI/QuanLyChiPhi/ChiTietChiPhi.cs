using DuLich.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DuLich.GUI.QuanLyChiPhi
{
    public partial class ChiTietChiPhi : Form
    {
        private IChiTietChiPhiListener chiTietChiPhiListener;
        private ChiPhi baseChiPhi;
        private ChiPhi editChiPhi;
        private List<LoaiChiPhi> danhSachLoaiChiPhi = new List<LoaiChiPhi>();
        private bool isEditing = false;
        public ChiTietChiPhi(ChiPhi chiPhi,List<LoaiChiPhi> danhSachLoaiChiPhi, IChiTietChiPhiListener chiTietChiPhiListener)
        {
            InitializeComponent();
            baseChiPhi = chiPhi;
            editChiPhi = new ChiPhi();
            editChiPhi.Map(chiPhi);
            this.danhSachLoaiChiPhi.AddRange(danhSachLoaiChiPhi);
            this.chiTietChiPhiListener = chiTietChiPhiListener;
            if(editChiPhi.MaChiPhi == 0)
            {
                editChiPhi.LoaiChiPhi = danhSachLoaiChiPhi.First();
                editChiPhi.GhiChu = "";
                editChiPhi.GiaTri = 0;
            }
            InitUI();
        }
     
        private void InitUI()
        {
            if (editChiPhi.MaChiPhi == 0)
            {
                tb_machiphi.Text = "Mã tự động";
            } else
            {
                tb_machiphi.Text = editChiPhi.MaChiPhi.ToString();
            } 
            tb_chiphi.Text = editChiPhi.GiaTri.ToString();
            foreach(LoaiChiPhi loaiChiPhi in danhSachLoaiChiPhi)
            {
                combobox_loaichiphi.Items.Add(loaiChiPhi);
            }
            combobox_loaichiphi.SelectedItem = editChiPhi.LoaiChiPhi;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (Validation(editChiPhi))
            {
                baseChiPhi.Map(editChiPhi);
                chiTietChiPhiListener.onChiTietChiPhi_LuuClick(baseChiPhi.Doan,baseChiPhi);
            }else
            {
                MessageBox.Show("Giá trị không hợp lệ");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            chiTietChiPhiListener.onChiTietChiPhi_HuyClick();
        }
        public interface IChiTietChiPhiListener
        {
            void onChiTietChiPhi_LuuClick(Doan doanHienTai,ChiPhi chiPhi);
            void onChiTietChiPhi_HuyClick();
        }
        private bool Validation(ChiPhi chiPhi)
        {
            if (chiPhi.GiaTri <= 0)
                return false;
            return true;
        }

        private void tb_maphancong_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboxloaichiphi_SelectedIndexChanged(object sender, EventArgs e)
        {
            editChiPhi.LoaiChiPhi = danhSachLoaiChiPhi.ToArray()[combobox_loaichiphi.SelectedIndex];
        }


        private void tb_giatri_TextChanged(object sender, EventArgs e)
        {
            if (!tb_chiphi.Text.Contains('$'))
            {
                if (!string.IsNullOrEmpty(tb_chiphi.Text.Trim()))
                {
                    editChiPhi.GiaTri = long.Parse(tb_chiphi.Text.Trim().ToString());
                }
                else
                {
                    editChiPhi.GiaTri = 0;
                }
                tb_chiphi.Text = "$" + tb_chiphi.Text;
            }
            else
            {
                if (tb_chiphi.TextLength > 1)
                {
                    tb_chiphi.Text = tb_chiphi.Text.Substring(tb_chiphi.Text.IndexOf('$'));
                    if (!string.IsNullOrEmpty(tb_chiphi.Text.Trim()))
                    {
                        editChiPhi.GiaTri = (long)double.Parse(tb_chiphi.Text.Trim().Replace("$", ""));
                    }
                    else
                    {
                        editChiPhi.GiaTri = 0;
                    }
                    if (tb_chiphi.Text.ToArray()[1] == '0')
                    {
                        tb_chiphi.Text = "$" + editChiPhi.GiaTri;
                        tb_chiphi.Focus();
                        tb_chiphi.SelectionStart = tb_chiphi.Text.Length;
                    }
                }
                else
                {
                    editChiPhi.GiaTri = 0;
                    tb_chiphi.Text = "$0";
                    tb_chiphi.Focus();
                    tb_chiphi.SelectionStart = tb_chiphi.Text.Length;
                }
            }
        }

        private void tv_maphancong_Click(object sender, EventArgs e)
        {

        }

        private void tb_ghichu_TextChanged(object sender, EventArgs e)
        {
            editChiPhi.GhiChu = tb_ghichu.Text;
        }

        private void tb_chiphi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

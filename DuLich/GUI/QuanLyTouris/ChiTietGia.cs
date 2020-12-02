using System;
using System.Linq;
using System.Windows.Forms;
using DuLich.BUS;

namespace DuLich.GUI.QuanLyTouris
{
    public partial class ChiTietGia : Form
    {
        private IChiTietGiaListener chiTietGiaListener;
        private Gia baseGia;
        private Gia editGia;
        private bool isEditing = false;
        public ChiTietGia(Gia gia,IChiTietGiaListener chiTietGiaListener)
        {
            InitializeComponent();
            this.chiTietGiaListener = chiTietGiaListener;

            baseGia = gia;
            editGia = new Gia();
            editGia.Map(gia);
            InitUI();
        }

        private void InitUI()
        {
            if (baseGia.MaGia == 0)
            {
                tb_magia.Text = "Mã tự động";
            } else {
                tb_magia.Text = baseGia.MaGia.ToString();
            }
            tb_giatri.Text = String.Format("{0:c1}", baseGia.GiaTri);
            if (baseGia.ThoiGianBatDau.Year < 1500 && baseGia.ThoiGianKetThuc.Year < 1500)
            {
                datepicker_batdau.Value = DateTime.Today;
                datepicker_ketthuc.Value = DateTime.Today;
            }else
            {
                datepicker_batdau.Value = baseGia.ThoiGianBatDau;
                datepicker_ketthuc.Value = baseGia.ThoiGianKetThuc;
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (Validation(editGia))
            {
                baseGia.Map(editGia);
                chiTietGiaListener.onChiTietGia_LuuClick(baseGia);
            }else
            {
                MessageBox.Show("Giá trị không hợp lệ");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            chiTietGiaListener.onChiTietGia_HuyClick();
        }
        public interface IChiTietGiaListener
        {
            void onChiTietGia_LuuClick(Gia gia);
            void onChiTietGia_HuyClick();
        }
        private bool Validation(Gia gia)
        {
            if (gia.GiaTri <= 0)
                return false;
            return true;
        }

        private void datepicker_batdau_ValueChanged(object sender, EventArgs e)
        {
            
            editGia.ThoiGianBatDau = datepicker_batdau.Value;
            if (editGia.ThoiGianBatDau > editGia.ThoiGianKetThuc)
            {
                editGia.ThoiGianKetThuc = editGia.ThoiGianBatDau;
                datepicker_ketthuc.Value = editGia.ThoiGianBatDau;
            }

            if (editGia.ThoiGianBatDau.Year < 1500)
                editGia.ThoiGianBatDau = DateTime.Today;
        }

        private void datepicker_ketthuc_ValueChanged(object sender, EventArgs e)
        {
            editGia.ThoiGianKetThuc = datepicker_ketthuc.Value;
            if (editGia.ThoiGianKetThuc < editGia.ThoiGianBatDau)
            {
                editGia.ThoiGianKetThuc = editGia.ThoiGianBatDau;
                datepicker_ketthuc.Value = editGia.ThoiGianBatDau;
            }

            if (editGia.ThoiGianKetThuc.Year < 1500)
                editGia.ThoiGianKetThuc = DateTime.Today;
        }
       

        private void tv_ngaybatdau_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_giatri_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void tb_giatri_TextChanged(object sender, EventArgs e)
        {
            if (!tb_giatri.Text.Contains('$'))
            {
                if (!string.IsNullOrEmpty(tb_giatri.Text.Trim()))
                {
                    editGia.GiaTri = long.Parse(tb_giatri.Text.Trim().ToString());
                }
                else
                {
                    editGia.GiaTri = 0;
                }
                tb_giatri.Text = "$" + tb_giatri.Text;
            }else
            {
                if(tb_giatri.TextLength > 1)
                {
                    tb_giatri.Text = tb_giatri.Text.Substring(tb_giatri.Text.IndexOf('$'));
                    if (!string.IsNullOrEmpty(tb_giatri.Text.Trim()))
                    {
                        editGia.GiaTri = (long)double.Parse(tb_giatri.Text.Trim().Replace("$", ""));
                    }
                    else
                        editGia.GiaTri = 0;
                    if (tb_giatri.Text.ToArray()[1] == '0')
                    {
                        tb_giatri.Text = "$" + editGia.GiaTri;
                        tb_giatri.Focus();
                        tb_giatri.SelectionStart = tb_giatri.Text.Length;
                    }
                }
                else
                {
                    editGia.GiaTri = 0;
                    tb_giatri.Text = "$0";
                    tb_giatri.Focus();
                    tb_giatri.SelectionStart = tb_giatri.Text.Length;
                }
            }
        }
    }
}

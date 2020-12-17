using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DuLich.BanHang_Dal;
using DuLich.BanHang_Entity;
using DuLich.BUS;
using DuLich.GUI.QuanLyThietBi;

namespace DuLich.GUI.QuanLyDonHang
{
    public partial class ChonThietBiHoacCombo : Form,DanhSachThietBi.IDanhSachThietBiChonThietBiListener
    {
        private bool isEditing = false;
        private product product;
        private combo combo;
        private int soluong = 1;
        private IChonThietBiListener chonThietBiListener;
        private IThayDoiSoLuongListener thayDoiSoLuongListener;
        private int mainvoicedetail;
        List<combo> danhSachCombo;
        public ChonThietBiHoacCombo(List<product> danhSachThietBiTrongChiTiet,List<combo> danhSachComboTrongChiTiet,IChonThietBiListener chonThietBiListener)
        {
            InitializeComponent();
            this.chonThietBiListener = chonThietBiListener;
            List<product> danhSachThietBi = Product_Dal.getInstance().GetAll();
            danhSachCombo = Combo_Dal.getInstance().GetAll();
            foreach (product product in danhSachThietBiTrongChiTiet)
            {
                if (danhSachThietBi.Contains(product))
                    danhSachThietBi.Remove(product);
            }
            foreach (combo combo in danhSachComboTrongChiTiet)
            {
                if (danhSachCombo.Contains(combo))
                    danhSachCombo.Remove(combo);
            }
            panel1.Controls.Clear();
            panel1.Controls.Add(new DanhSachThietBi(danhSachThietBi, Catalog_Dal.GetAll(), this));
        }
        public ChonThietBiHoacCombo(int mainvoicedetail, product product,combo combo , int soluong, IThayDoiSoLuongListener thayDoiSoLuongListener)
        {
            InitializeComponent();
            this.product = product;
            this.combo = combo;
            this.soluong = soluong;
            this.mainvoicedetail = mainvoicedetail;
            this.thayDoiSoLuongListener = thayDoiSoLuongListener;
            tb_soluong.Text = soluong.ToString();
            tb_thietbidachon.Text = product != null ? product.product_name : combo.combo_name;
        }


        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (product != null || combo != null) {
                if(chonThietBiListener != null)
                    chonThietBiListener.onLuuClick(product, combo, soluong);

                if (thayDoiSoLuongListener != null)
                    thayDoiSoLuongListener.onLuuThayDoiClick(mainvoicedetail, soluong);
            }
            else
            {
                MessageBox.Show("Vui lòng thêm ít nhất 1 thiết bị");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            if(chonThietBiListener != null)
                chonThietBiListener.onHuyClick();
            if (thayDoiSoLuongListener != null)
                thayDoiSoLuongListener.onHuyClick();
        }

        public interface IChonThietBiListener
        {
            void onLuuClick(product product,combo combo,int soluong);
            void onHuyClick();
        }
        public interface IThayDoiSoLuongListener
        {
            void onLuuThayDoiClick(int ma, int soluong);
            void onHuyClick();
        }


        private void tb_soluong_TextChanged(object sender, EventArgs e)
        {
            string number = numberOnly(tb_soluong.Text.Trim());
            if (number.Length > 0)
            {
                soluong = int.Parse(number);
            }
            else
            {
                tb_soluong.Text = "1";
            }
        }
        private string numberOnly(string v)
        {
            string actualdata = string.Empty;
            char[] entereddata = v.ToCharArray();
            foreach (char aChar in entereddata.AsEnumerable())
            {
                if (char.IsDigit(aChar))
                {
                    actualdata = actualdata + aChar;
                }
                else
                {
                    actualdata.Replace(aChar, ' ');
                    actualdata.Trim();
                }
            }
            return actualdata;
        }

        public void onDanhSachThietBi_DoubleClick(product product)
        {
            this.product = product;
            tb_thietbidachon.Text = product.product_name;
            tb_soluong.Text = "1";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

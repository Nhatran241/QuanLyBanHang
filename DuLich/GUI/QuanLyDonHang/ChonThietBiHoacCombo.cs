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
        private int soluong = 1;
        private IChonThietBiListener chonThietBiListener;
        private IThayDoiSoLuongListener thayDoiSoLuongListener;
        private int maProductCombo;
        public ChonThietBiHoacCombo(List<product> danhSachThietBiTrongCombo,IChonThietBiListener chonThietBiListener)
        {
            InitializeComponent();
            this.chonThietBiListener = chonThietBiListener;
            List<product> danhSachThietBi = Product_Dal.getInstance().GetAll();
            foreach(product product in danhSachThietBiTrongCombo)
            {
                if (danhSachThietBi.Contains(product))
                    danhSachThietBi.Remove(product);
            }
            panel1.Controls.Clear();
            panel1.Controls.Add(new DanhSachThietBi(danhSachThietBi, Catalog_Dal.GetAll(), this));
        }
        public ChonThietBiHoacCombo(int maComboProduct , product product , int soluong, IThayDoiSoLuongListener thayDoiSoLuongListener)
        {
            InitializeComponent();
            this.maProductCombo = maProductCombo;
            this.product = product;
            this.soluong = soluong;
            this.thayDoiSoLuongListener = thayDoiSoLuongListener;
            tb_soluong.Text = soluong.ToString();
            tb_thietbidachon.Text = product.product_name;
        }


        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (product != null) {
                if(chonThietBiListener != null)
                    chonThietBiListener.onLuuClick(product, soluong);

                if (thayDoiSoLuongListener != null)
                    thayDoiSoLuongListener.onLuuClick(maProductCombo,product, soluong);
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
            void onLuuClick(product product,int soluong);
            void onHuyClick();
        }
        public interface IThayDoiSoLuongListener
        {
            void onLuuClick(int maComboProduct ,product product, int soluong);
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

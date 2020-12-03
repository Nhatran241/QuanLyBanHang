using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DuLich.BanHang_Dal;
using DuLich.BanHang_Entity;
using DuLich.BUS;
using DuLich.GUI.QuanLyThietBi;

namespace DuLich.GUI.QuanLyCombo
{
    public partial class ChonThietBi : Form,DanhSachThietBi.IDanhSachThietBiChonThietBiListener
    {
        private bool isEditing = false;
        private Product product;
        private int soluong = 1;
        private IChonThietBiListener chonThietBiListener;
        public ChonThietBi(List<Product> danhSachThietBiTrongCombo,IChonThietBiListener chonThietBiListener)
        {
            InitializeComponent();
            this.chonThietBiListener = chonThietBiListener;
            List<Product> danhSachThietBi = Product_Dal.getInstance().GetAll();
            foreach(Product product in danhSachThietBi)
            {
                if (danhSachThietBiTrongCombo.Contains(product))
                    danhSachThietBi.Remove(product);
            }
            panel1.Controls.Clear();
            panel1.Controls.Add(new DanhSachThietBi(danhSachThietBi, Catalog_Dal.GetAll(), this));
        }


        private void btn_luu_Click(object sender, EventArgs e)
        {
            chonThietBiListener.onLuuClick(product,soluong);
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            chonThietBiListener.onHuyClick();
        }

        public interface IChonThietBiListener
        {
            void onLuuClick(Product product,int soluong);
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

        public void onDanhSachThietBi_DoubleClick(Product product)
        {
            this.product = product;
            tb_soluong.Text = "1";
        }
    }
}

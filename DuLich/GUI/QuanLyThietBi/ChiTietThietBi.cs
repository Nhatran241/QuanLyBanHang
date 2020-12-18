using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DuLich.BanHang_Entity;
using DuLich.BUS;

namespace DuLich.GUI.QuanLyThietBi
{
    public partial class ChiTietThietBi : Form
    {
        private product product;
        private product tmpProduct;
        private List<catalog> catalogs;
        private bool isEditing = false;
        private IChiTietThietBiListener chiTietThietBiListener;
        public ChiTietThietBi(product product,List<catalog> catalogs,IChiTietThietBiListener chiTietThietBiListener)
        {
            InitializeComponent();
            this.product = product;
            this.catalogs = catalogs;
            this.chiTietThietBiListener = chiTietThietBiListener;
            tmpProduct = new product();
            tmpProduct.Map(this.product);
            InitUI();
        }

        private void InitUI()
        {
            if (product.id == 0)
            {
                // Create new
                tmpProduct.createtime = DateTime.Now;
                tmpProduct.price = 0;
                tmpProduct.discountpercent = 0;
                tmpProduct.catalog = catalogs.FirstOrDefault();
                tmpProduct.amount = 0;
            }
            foreach (catalog catalog in catalogs)
            {
                cb_danhmuc.Items.Add(catalog);
            }
            tb_tenthietbi.Text = tmpProduct.product_name;
            tb_soluong.Text = tmpProduct.amount.ToString();
            tb_gia.Text = tmpProduct.price.ToString();
            tb_giamgia.Text = tmpProduct.discountpercent.ToString();
            tb_chitiet.Text = tmpProduct.detail;
            cb_danhmuc.SelectedItem = tmpProduct.catalog;
            updateGiaSauGiam();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (Validation(tmpProduct))
            {
                product.Map(tmpProduct);
                chiTietThietBiListener.onLuuClick(product);
            }else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            chiTietThietBiListener.onHuyChiTietThietBiClick();
        }
        private bool Validation(product product)
        {
            if (string.IsNullOrEmpty(product.product_name) || product.catalog == null || string.IsNullOrEmpty(product.detail))
                return false;
            return true;
        }

        private void tv_ngaybatdau_Click(object sender, EventArgs e)
        {

        }

        public interface IChiTietThietBiListener
        {
            void onLuuClick(product product);
            void onHuyChiTietThietBiClick();
        }

        private void tb_tenthietbi_TextChanged(object sender, EventArgs e)
        {
            tmpProduct.product_name = tb_tenthietbi.Text.Trim();
        }

        private void cb_danhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            tmpProduct.catalog = catalogs.ToArray()[cb_danhmuc.SelectedIndex];
        }

        private void tb_soluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_gia_TextChanged(object sender, EventArgs e)
        {
            string nodotnod = tb_gia.Text.ToString().Replace(",", "").Replace("đ", "");
            string number = numberOnly(nodotnod);
            if (number.Length > 0)
            {
                tb_gia.Text = long.Parse(number).ToString("N0") + "đ";
                tb_gia.Focus();
                tb_gia.SelectionStart = tb_gia.Text.Length - 1;
                tmpProduct.price = long.Parse(number);

            }
            else
            {
                tb_gia.Text = "0đ";
                tmpProduct.price = 0;
            }
            updateGiaSauGiam();
        }

        private void updateGiaSauGiam()
        {
            tb_giasaugiam.Text = tmpProduct.PriceAfterDiscount().ToString("N0")+"đ";
        }

        private void tb_giamgia_TextChanged(object sender, EventArgs e)
        {
            string nodotnod = tb_giamgia.Text.ToString().Replace("%", "");
            string number = numberOnly(nodotnod);
            if (number.Length > 0)
            {
                int percent = int.Parse(number);
                if (percent >= 100)
                {
                    tb_giamgia.Text = "100%";
                    tb_giamgia.Focus();
                    tb_giamgia.SelectionStart = tb_giamgia.Text.Length - 1;
                    tmpProduct.discountpercent = 100;
                }
                else
                {
                    tb_giamgia.Text = percent + "%";
                    tb_giamgia.Focus();
                    tb_giamgia.SelectionStart = tb_giamgia.Text.Length - 1;
                    tmpProduct.discountpercent = percent;
                }
            }
            else
            {
                tb_giamgia.Text = "0%";
                tb_giamgia.Focus();
                tb_giamgia.SelectionStart = tb_giamgia.Text.Length - 1;
                tmpProduct.discountpercent = 0;
            }
            updateGiaSauGiam();
        }

        private void tb_chitiet_TextChanged(object sender, EventArgs e)
        {
            tmpProduct.detail = tb_chitiet.Text.Trim();
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

    }
}

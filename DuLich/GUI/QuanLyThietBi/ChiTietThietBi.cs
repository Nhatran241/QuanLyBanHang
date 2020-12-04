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
        private Product product;
        private Product tmpProduct;
        private List<Catalog> catalogs;
        private bool isEditing = false;
        private IChiTietThietBiListener chiTietThietBiListener;
        public ChiTietThietBi(Product product,List<Catalog> catalogs,IChiTietThietBiListener chiTietThietBiListener)
        {
            InitializeComponent();
            this.product = product;
            this.catalogs = catalogs;
            this.chiTietThietBiListener = chiTietThietBiListener;
            tmpProduct = new Product();
            tmpProduct.Map(this.product);
            InitUI();
        }

        private void InitUI()
        {
            if (product.ID == 0)
            {
                // Create new
                tmpProduct.CreateTime = DateTime.Now;
                tmpProduct.Price = 0;
                tmpProduct.DiscountPercent = 0;
                tmpProduct.Catalog = catalogs.FirstOrDefault();
                tmpProduct.Amount = 0;
            }
            foreach (Catalog catalog in catalogs)
            {
                cb_danhmuc.Items.Add(catalog);
            }
            tb_tenthietbi.Text = tmpProduct.Product_Name;
            tb_soluong.Text = tmpProduct.Amount.ToString();
            tb_gia.Text = tmpProduct.Price.ToString();
            tb_giamgia.Text = tmpProduct.DiscountPercent.ToString();
            tb_chitiet.Text = tmpProduct.Detail;
            cb_danhmuc.SelectedItem = tmpProduct.Catalog;
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
                MessageBox.Show("Tên thiết bị không được bỏ trống");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            chiTietThietBiListener.onHuyChiTietThietBiClick();
        }
        private bool Validation(Product product)
        {
            if (string.IsNullOrEmpty(product.Product_Name) || product.Catalog == null)
                return false;
            return true;
        }

        private void tv_ngaybatdau_Click(object sender, EventArgs e)
        {

        }

        public interface IChiTietThietBiListener
        {
            void onLuuClick(Product product);
            void onHuyChiTietThietBiClick();
        }

        private void tb_tenthietbi_TextChanged(object sender, EventArgs e)
        {
            tmpProduct.Product_Name = tb_tenthietbi.Text.Trim();
        }

        private void cb_danhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            tmpProduct.Catalog = catalogs.ToArray()[cb_danhmuc.SelectedIndex];
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
                tmpProduct.Price = long.Parse(number);

            }
            else
            {
                tb_gia.Text = "0đ";
                tmpProduct.Price = 0;
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
                    tmpProduct.DiscountPercent = 100;
                }
                else
                {
                    tb_giamgia.Text = percent + "%";
                    tb_giamgia.Focus();
                    tb_giamgia.SelectionStart = tb_giamgia.Text.Length - 1;
                    tmpProduct.DiscountPercent = percent;
                }
            }
            else
            {
                tb_giamgia.Text = "0%";
                tb_giamgia.Focus();
                tb_giamgia.SelectionStart = tb_giamgia.Text.Length - 1;
                tmpProduct.DiscountPercent = 0;
            }
            updateGiaSauGiam();
        }

        private void tb_chitiet_TextChanged(object sender, EventArgs e)
        {
            tmpProduct.Detail = tb_chitiet.Text.Trim();
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

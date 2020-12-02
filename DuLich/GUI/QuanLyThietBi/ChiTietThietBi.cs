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

            }
            else
            {
                tb_tenthietbi.Text = tmpProduct.Product_Name;
                tb_soluong.Text = tmpProduct.Amount.ToString();
                tb_gia.Text = tmpProduct.Price.ToString();
                tb_giamgia.Text = tmpProduct.DiscountPercent.ToString();
                tb_giasaugiam.Text = (tmpProduct.Price - (tmpProduct.Price * tmpProduct.DiscountPercent) / 100).ToString();
                tb_chitiet.Text = tmpProduct.Detail;
                foreach(Catalog catalog in catalogs)
                {
                    cb_danhmuc.Items.Add(catalog);
                }
                cb_danhmuc.SelectedItem = tmpProduct.Catalog;

            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (Validation(tmpProduct))
            {
                product.Map(tmpProduct);
                chiTietThietBiListener.onLuuClick(product);
            }else
            {
                MessageBox.Show("Giá trị không hợp lệ");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            chiTietThietBiListener.onHuyClick();
        }
        private bool Validation(Product product)
        {
            return true;
        }

        private void tv_ngaybatdau_Click(object sender, EventArgs e)
        {

        }

        private void tb_giatri_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public interface IChiTietThietBiListener
        {
            void onLuuClick(Product product);
            void onHuyClick();
        }

        private void tb_tenthietbi_TextChanged(object sender, EventArgs e)
        {

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
            string nodotnod = tb_gia.Text.ToString().Replace(".", "").Replace("đ", "");
            string number = numberOnly(nodotnod);
            if (nodotnod != number)
                tb_gia.Text = string.Format("{0:n0}", number);
            if (nodotnod.Length > 0)
            {
               tmpProduct.Price = long.Parse(nodotnod);
             
            }
            else
            {
                tb_gia.Text = "0đ";
            }
            updateGiaSauGiam();
        }

        private void updateGiaSauGiam()
        {
            tb_giasaugiam.Text = (tmpProduct.Price - (tmpProduct.Price * tmpProduct.DiscountPercent) / 100).ToString();
        }

        private void tb_giamgia_TextChanged(object sender, EventArgs e)
        {
            string nodotnod = tb_giamgia.Text.ToString().Replace(".", "").Replace("đ", "");
            string number = numberOnly(nodotnod);
            if (nodotnod != number)
                tb_giamgia.Text = string.Format("{0:n0}", number);
            if (nodotnod.Length > 0)
            {
                int percent = int.Parse(nodotnod);
                if (percent > 100)
                {
                    tb_giamgia.Text = "100";
                }
                else  
                    tmpProduct.Price = percent;
            }
            else
            {
                tb_giamgia.Text = "0";
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

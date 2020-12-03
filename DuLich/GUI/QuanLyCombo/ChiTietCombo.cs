using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DuLich.BanHang_Entity;
using DuLich.BUS;

namespace DuLich.GUI.QuanLyCombo
{
    public partial class ChiTietCombo : Form,ChonThietBi.IChonThietBiListener
    {
        private Combo combo;
        private Combo tmpCombo;
        private IChiTietComboListener chiTietComboListener;
        private ChonThietBi chonThietBi;
        public ChiTietCombo(Combo combo,IChiTietComboListener chiTietComboListener)
        {
            InitializeComponent();
            this.combo = combo;
            this.chiTietComboListener = chiTietComboListener;
            tmpCombo = new Combo();
            tmpCombo.Map(this.combo);
            InitUI();
        }

        private void InitUI()
        {
            if (tmpCombo.ID == 0)
            {
                // Create new
                tmpCombo.discountPercent = 0;
            }
           
            updateGiaSauGiam();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (Validation(tmpCombo))
            {
                combo.Map(tmpCombo);
                chiTietComboListener.onLuuClick(combo);
            }else
            {
                MessageBox.Show("Vui lòng thêm ít nhất 1 sản phẩm vào combo");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            chiTietComboListener.onHuyClick();
        }
        private bool Validation(Combo combo)
        {
            if (combo.ComboProducts == null)
                return false;
            return true;
        }

        public interface IChiTietComboListener
        {
            void onLuuClick(Combo combo);
            void onHuyClick();
        }

        private void tb_tenthietbi_TextChanged(object sender, EventArgs e)
        {
            tmpCombo.Combo_Name = tb_tenthietbi.Text.Trim();
        }

       

        private void updateGiaSauGiam()
        {
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
                    tmpCombo.discountPercent = 100;
                }
                else
                {
                    tb_giamgia.Text = percent + "%";
                    tb_giamgia.Focus();
                    tb_giamgia.SelectionStart = tb_giamgia.Text.Length - 1;
                    tmpCombo.discountPercent = percent;
                }
            }
            else
            {
                tb_giamgia.Text = "0%";
                tb_giamgia.Focus();
                tb_giamgia.SelectionStart = tb_giamgia.Text.Length - 1;
                tmpCombo.discountPercent = 0;
            }
            updateGiaSauGiam();
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

        private void ChiTietCombo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void themSanPhamVaoComboClick(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            if (tmpCombo.ComboProducts != null) { 
                foreach(ComboProduct comboProduct in tmpCombo.ComboProducts)
                {
                    products.Add(comboProduct.Product);
                }
            
            }
            chonThietBi = new ChonThietBi(products, this);
            chonThietBi.ShowDialog();
        }

        public void onLuuClick(Product product, int soluong)
        {
            ComboProduct comboProduct = new ComboProduct();
            comboProduct.Product = product;
            comboProduct.Product_Amount = soluong;
            tmpCombo.ComboProducts.Add(comboProduct);
        }

        public void onHuyClick()
        {
            chonThietBi.Close();
        }
    }
}

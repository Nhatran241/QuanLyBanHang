using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DuLich.BanHang_Entity;
using DuLich.BUS;

namespace DuLich.GUI.QuanLyCombo
{
    public partial class ChiTietCombo : Form,ChonThietBi.IChonThietBiListener,ChonThietBi.IThayDoiSoLuongListener
    {
        private Combo combo;
        private Combo tmpCombo;
        private List<ComboProduct> comboProducts;
        private IChiTietComboListener chiTietComboListener;
        private ChonThietBi chonThietBi;
        public ChiTietCombo(Combo combo,IChiTietComboListener chiTietComboListener)
        {
            InitializeComponent();
            this.combo = combo;
            this.chiTietComboListener = chiTietComboListener;
            tmpCombo = new Combo();
            tmpCombo.Map(this.combo);
            comboProducts = tmpCombo.GetListComboProduct();
            InitUI();
        }

        private void InitUI()
        {
            if (tmpCombo.ID == 0)
            {
                // Create new
                tmpCombo.discountPercent = 0;
                tmpCombo.CreateTime = DateTime.Now;
            }
            tb_tenthietbi.Text = tmpCombo.Combo_Name;
            tb_giamgia.Text = tmpCombo.discountPercent.ToString()+"%";
            loadListProductInCombo();
        }

        private void loadListProductInCombo()
        {
                lv_productincombo.Items.Clear();
                foreach(ComboProduct comboProduct in comboProducts)
                {
                    ListViewItem item = new ListViewItem(new string[] {
                    comboProduct.Product.ID.ToString(),
                    comboProduct.Product.Product_Name,
                    comboProduct.Product_Amount.ToString(),
                    comboProduct.Product.Price.ToString("N0")+"đ",
                    (comboProduct.Product.Price * comboProduct.Product_Amount).ToString("N0")+"đ"
                }, -1);
                    lv_productincombo.Items.Add(item);
                }
                updateGiaSauGiam();

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (comboProducts.Count == 0) {
                MessageBox.Show("Vui lòng thêm ít nhất 1 sản phẩm vào combo");
                return;            
            }
            if(string.IsNullOrEmpty(tmpCombo.Combo_Name))
            {
                MessageBox.Show("Vui lòng nhập tên combo");
                return;
            }
            combo.Map(tmpCombo);
            combo.ComboProducts = comboProducts;
            chiTietComboListener.onLuuClick(combo);
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            chiTietComboListener.onHuyChiTietComboClick();
        }
       
        public interface IChiTietComboListener
        {
            void onLuuClick(Combo combo);
            void onHuyChiTietComboClick();
        }

        private void tb_tenthietbi_TextChanged(object sender, EventArgs e)
        {
            tmpCombo.Combo_Name = tb_tenthietbi.Text.Trim();
        }

       

        private void updateGiaSauGiam()
        {
            long tongia = 0;
            foreach(ComboProduct comboProduct in comboProducts)
                {
                    tongia += comboProduct.Product.Price * comboProduct.Product_Amount;
                }
                tb_tonggiasanpham.Text = tongia.ToString("N0") + "đ";
                tb_giacombo.Text = (tongia-(tongia*tmpCombo.discountPercent)/100).ToString("N0") + "đ";
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

        private void btn_xoaThietBiKhoiCombo(object sender, EventArgs e)
        {
            if (lv_productincombo.SelectedItems.Count <= 0)
                return;
            int position = lv_productincombo.SelectedItems[0].Index;
            ComboProduct comboProduct = comboProducts[position];
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thiết bị "+ comboProduct.Product.Product_Name +" ra khỏi combo này không","", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                comboProducts.RemoveAt(position);
                loadListProductInCombo();
            }
        }

        private void themSanPhamVaoComboClick(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            foreach (ComboProduct comboProduct in comboProducts)
            {
                products.Add(comboProduct.Product);
            }
            chonThietBi = new ChonThietBi(products, this);
            chonThietBi.ShowDialog();
        }

        public void onLuuClick(Product product, int soluong)
        {
            ComboProduct comboProduct = new ComboProduct();
            comboProduct.Product = product;
            comboProduct.Product_Amount = soluong;
            comboProducts.Add(comboProduct);
            loadListProductInCombo();
            chonThietBi.Close();
        }

        public void onHuyClick()
        {
            chonThietBi.Close();
        }

        private void btn_thaydoisoluong_Click(object sender, EventArgs e)
        {

            if (lv_productincombo.SelectedItems.Count <= 0)
              return;
            int position = lv_productincombo.SelectedItems[0].Index;
            ComboProduct comboProduct = comboProducts[position];
            chonThietBi = new ChonThietBi(comboProduct.ID,comboProduct.Product,comboProduct.Product_Amount, this);
            chonThietBi.ShowDialog();
        }

        public void onLuuClick(int maComboProduct, Product product, int soluong)
        {
            ComboProduct comboProduct = comboProducts.Where(c => c.ID == maComboProduct).FirstOrDefault();
            if (comboProduct != null)
                comboProduct.Product_Amount = soluong;
            loadListProductInCombo();
            chonThietBi.Close();
        }
    }
}

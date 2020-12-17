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
        private combo combo;
        private combo tmpCombo;
        private List<comboproducts> comboProducts;
        private IChiTietComboListener chiTietComboListener;
        private ChonThietBi chonThietBi;
        public ChiTietCombo(combo combo,IChiTietComboListener chiTietComboListener)
        {
            InitializeComponent();
            this.combo = combo;
            this.chiTietComboListener = chiTietComboListener;
            tmpCombo = new combo();
            tmpCombo.Map(this.combo);
            comboProducts = tmpCombo.GetListComboProduct();
            InitUI();
        }

        private void InitUI()
        {
            if (tmpCombo.id == 0)
            {
                // Create new
                tmpCombo.discountpercent = 0;
                tmpCombo.createtime = DateTime.Now;
            }
            tb_tenthietbi.Text = tmpCombo.combo_name;
            tb_giamgia.Text = tmpCombo.discountpercent.ToString()+"%";
            loadListProductInCombo();
        }

        private void loadListProductInCombo()
        {
                lv_productincombo.Items.Clear();
                foreach(comboproducts comboProduct in comboProducts)
                {
                    ListViewItem item = new ListViewItem(new string[] {
                    comboProduct.product.id.ToString(),
                    comboProduct.product.product_name,
                    comboProduct.product_amount.ToString(),
                    comboProduct.product.price.ToString("N0")+"đ",
                    (comboProduct.product.price * comboProduct.product_amount).ToString("N0")+"đ"
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
            if(string.IsNullOrEmpty(tmpCombo.combo_name))
            {
                MessageBox.Show("Vui lòng nhập tên combo");
                return;
            }
            combo.Map(tmpCombo);
            combo.comboproducts = comboProducts;
            chiTietComboListener.onLuuClick(combo);
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            chiTietComboListener.onHuyChiTietComboClick();
        }
       
        public interface IChiTietComboListener
        {
            void onLuuClick(combo combo);
            void onHuyChiTietComboClick();
        }

        private void tb_tenthietbi_TextChanged(object sender, EventArgs e)
        {
            tmpCombo.combo_name = tb_tenthietbi.Text.Trim();
        }

       

        private void updateGiaSauGiam()
        {
            long tongia = 0;
            foreach(comboproducts comboProduct in comboProducts)
                {
                    tongia += comboProduct.product.price * comboProduct.product_amount;
                }
                tb_tonggiasanpham.Text = tongia.ToString("N0") + "đ";
                tb_giacombo.Text = (tongia-(tongia*tmpCombo.discountpercent)/100).ToString("N0") + "đ";
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
                    tmpCombo.discountpercent = 100;
                }
                else
                {
                    tb_giamgia.Text = percent + "%";
                    tb_giamgia.Focus();
                    tb_giamgia.SelectionStart = tb_giamgia.Text.Length - 1;
                    tmpCombo.discountpercent = percent;
                }
            }
            else
            {
                tb_giamgia.Text = "0%";
                tb_giamgia.Focus();
                tb_giamgia.SelectionStart = tb_giamgia.Text.Length - 1;
                tmpCombo.discountpercent = 0;
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
            comboproducts comboProduct = comboProducts[position];
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thiết bị "+ comboProduct.product.product_name +" ra khỏi combo này không","", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                comboProducts.RemoveAt(position);
                loadListProductInCombo();
            }
        }

        private void themSanPhamVaoComboClick(object sender, EventArgs e)
        {
            List<product> products = new List<product>();
            foreach (comboproducts comboProduct in comboProducts)
            {
                products.Add(comboProduct.product);
            }
            chonThietBi = new ChonThietBi(products, this);
            chonThietBi.ShowDialog();
        }

        public void onLuuClick(product product, int soluong)
        {
            comboproducts comboProduct = new comboproducts();
            comboProduct.product = product;
            comboProduct.product_amount = soluong;
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
            comboproducts comboProduct = comboProducts[position];
            chonThietBi = new ChonThietBi(comboProduct.id,comboProduct.product,comboProduct.product_amount, this);
            chonThietBi.ShowDialog();
        }

        public void onLuuClick(int maComboProduct, product product, int soluong)
        {
            comboproducts comboProduct = comboProducts.Where(c => c.id == maComboProduct).FirstOrDefault();
            if (comboProduct != null)
                comboProduct.product_amount = soluong;
            loadListProductInCombo();
            chonThietBi.Close();
        }

        private void tb_tonggiasanpham_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

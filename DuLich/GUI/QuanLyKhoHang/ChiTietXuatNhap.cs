using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DuLich.BanHang_Entity;
using DuLich.BUS;

namespace DuLich.GUI.QuanLyKhoHang
{
    public partial class ChiTietXuatNhap : Form
    {
        private Storage storage;
        private Storage tmpStorage;
        private List<Product> products;
        private bool isEditing = false;
        private IChiTietXuatNhapListener chiTietXuatNhapListener;
        public ChiTietXuatNhap(Storage storage,List<Product> products,IChiTietXuatNhapListener chiTietXuatNhapListener)
        {
            InitializeComponent();
            this.storage = storage;
            this.products = products;
            this.chiTietXuatNhapListener = chiTietXuatNhapListener;
            tmpStorage = new Storage();
            tmpStorage.Map(this.storage);
            InitUI();
        }

        private void InitUI()
        {
           
            if (tmpStorage.ID == 0)
            {
                // Create new
                tmpStorage.createTime = DateTime.Now;
                tmpStorage.Product = products.First();
            }else
            {
                cb_loaiphieu.Enabled = false;
                cb_sanpham.Enabled = false;
            }
            foreach (Product product in products)
            {
                cb_sanpham.Items.Add(product);
            }
            cb_sanpham.SelectedItem = tmpStorage.Product;
            if (tmpStorage.Amount > 0)
            {
                cb_loaiphieu.SelectedIndex = 0;
            }
            else cb_loaiphieu.SelectedIndex = 1;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if(tmpStorage.Amount == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                return;
            }
            if (cb_loaiphieu.SelectedIndex == 1 && tmpStorage.Product.Amount < tmpStorage.Amount)
            {
                MessageBox.Show("Sản phẩm không đủ số lượng để xuất , số lượng sản phẩm trong kho là : " + tmpStorage.Product.Amount);
                return;
            }
            if (cb_loaiphieu.SelectedIndex == 1)
                tmpStorage.Amount = -tmpStorage.Amount;
            int difAmount = tmpStorage.Amount - storage.Amount;
            storage.Map(tmpStorage);
            chiTietXuatNhapListener.onLuuClick(storage,difAmount);
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            chiTietXuatNhapListener.onHuyChiTietXuatNhapClick();
        }

        private void tv_ngaybatdau_Click(object sender, EventArgs e)
        {

        }

        public interface IChiTietXuatNhapListener
        {
            void onLuuClick(Storage storage,int difAmount);
            void onHuyChiTietXuatNhapClick();
        }


        private void tb_soluong_TextChanged(object sender, EventArgs e)
        {
            string number = numberOnly(tb_soluong.Text.ToString());
            if (number.Length > 0)
            {
                tmpStorage.Amount = int.Parse(number);

            }
            else
            {
                tmpStorage.Amount = 0;
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

        private void sanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            tmpStorage.Product = products.ToArray()[cb_sanpham.SelectedIndex];
        }
    }
}

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
        private storage storage;
        private storage tmpStorage;
        private List<product> products;
        private bool isEditing = false;
        private IChiTietXuatNhapListener chiTietXuatNhapListener;
        public ChiTietXuatNhap(storage storage,List<product> products,IChiTietXuatNhapListener chiTietXuatNhapListener)
        {
            InitializeComponent();
            this.storage = storage;
            this.products = products;
            this.chiTietXuatNhapListener = chiTietXuatNhapListener;
            tmpStorage = new storage();
            tmpStorage.Map(this.storage);
            InitUI();
        }

        private void InitUI()
        {
           
            if (tmpStorage.id == 0)
            {
                // Create new
                tmpStorage.createtime = DateTime.Now;
                tmpStorage.product = products.First();
            }else
            {
                cb_loaiphieu.Enabled = false;
                cb_sanpham.Enabled = false;
            }
            foreach (product product in products)
            {
                cb_sanpham.Items.Add(product);
            }
            cb_sanpham.SelectedItem = tmpStorage.product;
            if (tmpStorage.amount > 0)
            {
                cb_loaiphieu.SelectedIndex = 0;
            }
            else cb_loaiphieu.SelectedIndex = 1;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if(tmpStorage.amount == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                return;
            }
            if (cb_loaiphieu.SelectedIndex == 1 && tmpStorage.product.amount < tmpStorage.amount)
            {
                MessageBox.Show("Sản phẩm không đủ số lượng để xuất , số lượng sản phẩm trong kho là : " + tmpStorage.product.amount);
                return;
            }
            if (cb_loaiphieu.SelectedIndex == 1)
                tmpStorage.amount = -tmpStorage.amount;
            int difAmount = tmpStorage.amount - storage.amount;
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
            void onLuuClick(storage storage,int difAmount);
            void onHuyChiTietXuatNhapClick();
        }


        private void tb_soluong_TextChanged(object sender, EventArgs e)
        {
            string number = numberOnly(tb_soluong.Text.ToString());
            if (number.Length > 0)
            {
                tmpStorage.amount = int.Parse(number);

            }
            else
            {
                tmpStorage.amount = 0;
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
            tmpStorage.product = products.ToArray()[cb_sanpham.SelectedIndex];
        }
    }
}

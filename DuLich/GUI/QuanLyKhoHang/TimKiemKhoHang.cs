using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DuLich.BanHang_Entity;
using DuLich.BUS;

namespace DuLich.GUI.QuanLyKhoHang
{
    public partial class TimKiemKhoHang : UserControl
    {
        private List<product> products = new List<product>();
        private product filterProduct = new product();
        private employee filterEmployee = new employee();
        private long soluongtu = 0;
        private long soluongden = long.MaxValue;
        private DateTime ngaytu = new DateTime();
        private DateTime ngayden = new DateTime();
        private ITimKiemKhoHangListener timKiemKhoHangListener;
        private bool initDataCompleted = false;

        public TimKiemKhoHang()
        {
            InitializeComponent();
        }
        public void SetData(List<product> products,DateTime ngaytu,DateTime ngayden,long soluongtu,long soluongden,ITimKiemKhoHangListener timKiemKhoHangListener)
        {
            this.timKiemKhoHangListener = timKiemKhoHangListener;
            this.products.AddRange(products);
            this.ngaytu = ngaytu;
            this.ngayden = ngayden;
            this.soluongtu = Math.Abs(soluongtu);
            this.soluongden = Math.Abs(soluongden);

            if (soluongtu > soluongden)
                this.soluongden = soluongtu;
            this.soluongtu = 0;
            filterProduct.id = -1;
            filterProduct.product_name = "Bất kỳ";
            this.products.Insert(0, filterProduct);
            InitData();
        }

        private void InitData()
        {
            foreach(product product in products)
            {
                cb_search.Items.Add(product);
            }
            cb_search.SelectedItem = filterProduct;
            tb_pricefrom.Text = soluongtu.ToString();
            tb_priceto.Text = soluongden.ToString();
            datepickbatdau.MaxDate = ngayden;
            datepickbatdau.MinDate = ngaytu;
            datepickketthuc.MaxDate = ngayden;
            datepickketthuc.MinDate = ngaytu;
            datepickbatdau.Value = datepickbatdau.MinDate;
            datepickketthuc.Value = datepickketthuc.MaxDate;
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            initDataCompleted = true;
        }

        private void cb_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterProduct = products[cb_search.SelectedIndex];
            timKiemKhoHangListener.onTimKiem(filterProduct,soluongtu,soluongden,ngaytu,ngayden,checkBox1.Checked,checkBox2.Checked);
        }

        public interface ITimKiemKhoHangListener
        {
            void onTimKiem(product product,long soluongtu,long soluongden,DateTime ngaytu,DateTime ngayden,bool isNhap,bool isXuat);
        }

        private void datepickbatdau_ValueChanged(object sender, EventArgs e)
        {
            if (!initDataCompleted)
                return;
            if (datepickbatdau.Value >= datepickketthuc.Value)
                datepickketthuc.Value = datepickbatdau.Value;
            timKiemKhoHangListener.onTimKiem(filterProduct,soluongtu,soluongden, datepickbatdau.Value, datepickketthuc.Value,checkBox1.Checked,checkBox2.Checked) ;
        }

        private void datepickketthuc_ValueChanged(object sender, EventArgs e)
        {
            if (!initDataCompleted)
                return;
            if (datepickketthuc.Value < datepickbatdau.Value)
                datepickbatdau.Value = datepickketthuc.Value;
            timKiemKhoHangListener.onTimKiem(filterProduct, soluongtu, soluongden, datepickbatdau.Value, datepickketthuc.Value,checkBox1.Checked,checkBox2.Checked);
        }

        private void tb_pricefrom_TextChanged(object sender, EventArgs e)
        {
            if (!initDataCompleted)
                return;
            string number = numberOnly(tb_pricefrom.Text.ToString());
            if (number.Length > 0)
            {
                soluongtu = long.Parse(number);

            }
            else
            {
                soluongtu = 0;
            }
            timKiemKhoHangListener.onTimKiem(filterProduct, soluongtu, soluongden, datepickbatdau.Value, datepickketthuc.Value,checkBox1.Checked,checkBox2.Checked);
     
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

        private void tb_priceto_TextChanged(object sender, EventArgs e)
        {
            if (!initDataCompleted)
                return;
            string number = numberOnly(tb_priceto.Text.ToString());
            if (number.Length > 0)
            {
                soluongden = long.Parse(number);
            }
            else
            {
                soluongden = 0;
            }
            timKiemKhoHangListener.onTimKiem(filterProduct, soluongtu, soluongden, datepickbatdau.Value, datepickketthuc.Value,checkBox1.Checked,checkBox2.Checked);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(timKiemKhoHangListener != null)
                timKiemKhoHangListener.onTimKiem(filterProduct, soluongtu, soluongden, datepickbatdau.Value, datepickketthuc.Value, checkBox1.Checked, checkBox2.Checked);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (timKiemKhoHangListener != null)
                timKiemKhoHangListener.onTimKiem(filterProduct, soluongtu, soluongden, datepickbatdau.Value, datepickketthuc.Value, checkBox1.Checked, checkBox2.Checked);

        }
    }
}

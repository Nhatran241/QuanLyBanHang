using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DuLich.BUS;
using System.Windows.Forms.DataVisualization.Charting;
using DuLich.BanHang_Entity;

namespace DuLich.GUI.ThongKe
{
    public partial class ThongKe : UserControl
    {
        private List<product> danhSachThietBi;
        private List<invoice> danhSachInvoice;
        public ThongKe(List<product> danhSachThietBi,List<invoice> danhSachInvoice)
        {
            InitializeComponent();
            this.danhSachThietBi = danhSachThietBi;
            this.danhSachInvoice = danhSachInvoice;
            InitData();
        }


        private void InitThongKeTonKho(List<product> products)
        {
            listview_solanditour.Items.Clear();
            foreach(product product in products.Where(c=>c.id != -1))
            {

                for (DateTime date = tonkhotu.Value; date.Date <= tonkhoden.Value; date = date.AddDays(1))
                {
                    int amount = product.GetAmountInStorageByTime(date);
                    ListViewItem listViewItem1 = new ListViewItem(new string[] {
                    product.id.ToString(),
                    product.product_name,
                    amount.ToString(),
                    date.ToString()}, -1);
                    listview_solanditour.Items.Add(listViewItem1);
                }
            }
        }

        private void InitThongKeDonHang(List<invoice> invoices)
        {
            listview_thongkedonhang.Items.Clear();
            int countItem = 0;
            long total = 0;
            foreach (invoice invoice in invoices.Where(c => c.createddate.Day >= datepicker_tu_doanhthutour.Value.Day && c.createddate.Day <= datepicker_den_doanhthutour.Value.Day))
            {
                countItem += invoice.invoicedetails.Count();
                total += invoice.totalmoney;
                ListViewItem listViewItem1 = new ListViewItem(new string[] {
                    invoice.id.ToString(),
                    invoice.invoicedetails.Count().ToString(),
                    invoice.totalmoney.ToString("N0")+"đ"
                }, -1);
                listview_thongkedonhang.Items.Add(listViewItem1);
            }
            tv_tongdonhang.Text = invoices.Count().ToString();
            tv_tongtien.Text = total.ToString("N0") + "đ";
        }


        private void InitData()
        {
            if(danhSachThietBi.Count > 0)
            {
                DateTime min = danhSachThietBi.First().createtime;
                product tmp = new product();
                tmp.id = -1;
                tmp.product_name = "Tất cả";
                danhSachThietBi.Insert(0, tmp);
                foreach (product product in danhSachThietBi.Where(c=>c.id != -1))
                {
                    if (product.createtime < min)
                        min = product.createtime;
                }
                comboBox1.DataSource = danhSachThietBi;
;                tonkhotu.MinDate = min;
                tonkhotu.MaxDate = DateTime.Now;
                tonkhoden.MinDate = min;
                tonkhoden.MaxDate = DateTime.Now;

                datepicker_tu_doanhthutour.MinDate = min;
                datepicker_tu_doanhthutour.MaxDate = DateTime.Now;
                datepicker_den_doanhthutour.MinDate = min;
                datepicker_den_doanhthutour.MaxDate = DateTime.Now;

                tonkhotu.Value = min;
                datepicker_tu_doanhthutour.Value = min;

            }
    
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (tonkhotu.Value > tonkhoden.Value)
                tonkhoden.Value = tonkhotu.Value;
            int position = comboBox1.SelectedIndex;
            if (position != 0)
            {
                InitThongKeTonKho(danhSachThietBi.Where(c => c.id == danhSachThietBi.ToArray()[position].id).ToList());
            }
            else
            {
                InitThongKeTonKho(danhSachThietBi);
            }


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (tonkhoden.Value < tonkhotu.Value)
                tonkhotu.Value = tonkhoden.Value;
            int position = comboBox1.SelectedIndex;
            if (position != 0)
            {
                InitThongKeTonKho(danhSachThietBi.Where(c => c.id == danhSachThietBi.ToArray()[position].id).ToList());
            }
            else
            {
                InitThongKeTonKho(danhSachThietBi);
            }

        }
        private void datepicker_tu_doanhthutour_ValueChanged_1(object sender, EventArgs e)
        {
            if (datepicker_tu_doanhthutour.Value > datepicker_den_doanhthutour.Value)
                datepicker_den_doanhthutour.Value = datepicker_tu_doanhthutour.Value;
            InitThongKeDonHang(danhSachInvoice);
        }
        private void datepicker_den_doanhthutour_ValueChanged_1(object sender, EventArgs e)
        {
            if (datepicker_den_doanhthutour.Value < datepicker_tu_doanhthutour.Value)
                datepicker_tu_doanhthutour.Value = datepicker_den_doanhthutour.Value;
            InitThongKeDonHang(danhSachInvoice);
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = comboBox1.SelectedIndex;
            if(position != 0)
            {
                InitThongKeTonKho(danhSachThietBi.Where(c => c.id == danhSachThietBi.ToArray()[position].id).ToList());
            }else
            {
                InitThongKeTonKho(danhSachThietBi);
            }

        }
    }
}

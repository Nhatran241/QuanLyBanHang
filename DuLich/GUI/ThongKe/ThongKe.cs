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
        private List<Product> danhSachThietBi;
        public ThongKe(List<Product> danhSachThietBi)
        {
            InitializeComponent();
            this.danhSachThietBi = danhSachThietBi;
            InitData();
        }


        private void InitThongKeTonKho(List<Product> products)
        {
            listview_solanditour.Items.Clear();
            foreach(Product product in products.Where(c=>c.ID != -1))
            {

                for (DateTime date = tonkhotu.Value; date.Date <= tonkhoden.Value; date = date.AddDays(1))
                {
                    int amount = product.GetAmountInStorageByTime(date);
                    ListViewItem listViewItem1 = new ListViewItem(new string[] {
                    product.ID.ToString(),
                    product.Product_Name,
                    amount.ToString(),
                    date.ToString()}, -1);
                    listview_solanditour.Items.Add(listViewItem1);
                }
            }
        }


        private void InitData()
        {
            if(danhSachThietBi.Count > 0)
            {
                DateTime min = danhSachThietBi.First().CreateTime;
                Product tmp = new Product();
                tmp.ID = -1;
                tmp.Product_Name = "Tất cả";
                danhSachThietBi.Insert(0, tmp);
                foreach (Product product in danhSachThietBi.Where(c=>c.ID != -1))
                {
                    if (product.CreateTime < min)
                        min = product.CreateTime;
                }
                comboBox1.DataSource = danhSachThietBi;
                tonkhotu.MinDate = min;
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
                InitThongKeTonKho(danhSachThietBi.Where(c => c.ID == danhSachThietBi.ToArray()[position].ID).ToList());
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
                InitThongKeTonKho(danhSachThietBi.Where(c => c.ID == danhSachThietBi.ToArray()[position].ID).ToList());
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
        }
        private void datepicker_den_doanhthutour_ValueChanged_1(object sender, EventArgs e)
        {
            if (datepicker_den_doanhthutour.Value < datepicker_tu_doanhthutour.Value)
                datepicker_tu_doanhthutour.Value = datepicker_den_doanhthutour.Value;
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = comboBox1.SelectedIndex;
            if(position != 0)
            {
                InitThongKeTonKho(danhSachThietBi.Where(c => c.ID == danhSachThietBi.ToArray()[position].ID).ToList());
            }else
            {
                InitThongKeTonKho(danhSachThietBi);
            }

        }
    }
}

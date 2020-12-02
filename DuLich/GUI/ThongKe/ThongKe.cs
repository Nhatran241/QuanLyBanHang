using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DuLich.BUS;
using System.Windows.Forms.DataVisualization.Charting;

namespace DuLich.GUI.ThongKe
{
    public partial class ThongKe : UserControl
    {
        private List<NhanVien> danhSachNhanVien;
        private List<Tour> danhSachTour;
        private List<Doan> danhSachDoan;
        private List<Khach> danhSachKhach;
        List<String> nam = new List<String>();
        public ThongKe(List<NhanVien> danhSachNhanVien,List<Tour> danhSachTour,List<Doan> danhSachDoan,List<Khach> danhSachKhach)
        {
            InitializeComponent();
            this.danhSachNhanVien = danhSachNhanVien;
            this.danhSachTour = danhSachTour;
            this.danhSachDoan = danhSachDoan;
            this.danhSachKhach = danhSachKhach;
            InitData();
        }


        private void InitThongKeTour()
        {
            double tongdanhthu = 0;
            double tongchiphi = 0;
            double tongloinhuan = 0;
            int tongdoan = 0;
            int tongtour = 0;
            int tongkhach = 0;
            listview_thongketheodoan.Items.Clear();
            foreach(Tour tour in danhSachTour)
            {
                tongtour++;
                List<Doan> listDoanTour = tour.GetListDoanOfTourByTime(datepicker_tu_doanhthutour.Value, datepicker_den_doanhthutour.Value);
                double doanhthutour = tour.TongDoanhThuTourByTime(datepicker_tu_doanhthutour.Value,datepicker_den_doanhthutour.Value);
                double chiphitour = tour.TongChiPhiTourByTime(datepicker_tu_doanhthutour.Value, datepicker_den_doanhthutour.Value);
                double loinhuantour = doanhthutour - chiphitour;
                int khachtour = tour.GetListKhachOfTourByTime(datepicker_tu_doanhthutour.Value, datepicker_den_doanhthutour.Value).Count;
                tongkhach += khachtour;
                tongdoan += listDoanTour.Count;
                tongdanhthu += doanhthutour;
                tongchiphi += chiphitour;
                tongloinhuan += loinhuantour;
                ListViewItem listViewItem1 = new ListViewItem(new string[] {
                tour.TenTour,
                doanhthutour+" $",
                chiphitour+" $",
                loinhuantour+ "$",
                khachtour+"",
                listDoanTour.Count+""}, -1);
                listview_thongketheodoan.Items.Add(listViewItem1);
            }
            tv_tongdoan.Text = tongdoan.ToString();
            tv_tongkhach.Text = tongkhach.ToString();
            tv_tongtour.Text = tongtour.ToString();
            tv_tongdanhthu.Text = tongdanhthu.ToString();
            tv_tongchiphi.Text = tongchiphi.ToString();
            tv_tongloinhuan.Text = tongloinhuan.ToString();
        }

        private void InitThongKeNhanVienDiTour()
        {
            listview_solanditour.Items.Clear();
            foreach (NhanVien nhanVien in danhSachNhanVien)
            {
                ListViewItem listViewItem1 = new ListViewItem(new string[] {
                nhanVien.MaNhanVien.ToString(),
                nhanVien.TenNhanVien,
                nhanVien.GetListDoanPhanCongByTime(dateTimePicker1.Value,dateTimePicker2.Value).Count().ToString()});
                listview_solanditour.Items.Add(listViewItem1);
            }
        }

        private void InitData()
        {
            nam.Add("Bất Kỳ");
            if(danhSachDoan.Count > 0)
            {
                DateTime min = danhSachDoan.First().ThoiGianBatDau;
                DateTime max = danhSachDoan.First().ThoiGianKetThuc;
                foreach (Doan doan in danhSachDoan)
                {
                    if (doan.ThoiGianBatDau < min)
                        min = doan.ThoiGianBatDau;
                    if (doan.ThoiGianKetThuc > max)
                        max = doan.ThoiGianKetThuc;
                }
                dateTimePicker1.MinDate = min;
                dateTimePicker1.MaxDate = max;
                dateTimePicker2.MinDate = min;
                dateTimePicker2.MaxDate = max;

                datepicker_tu_doanhthutour.MinDate = min;
                datepicker_tu_doanhthutour.MaxDate = max;
                datepicker_den_doanhthutour.MinDate = min;
                datepicker_den_doanhthutour.MaxDate = max;



                dateTimePicker1.Value = min;
                dateTimePicker2.Value = max;
                datepicker_tu_doanhthutour.Value = min;
                datepicker_den_doanhthutour.Value = max;

            }
    
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
                dateTimePicker2.Value = dateTimePicker1.Value;
            InitThongKeNhanVienDiTour();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value < dateTimePicker1.Value)
                dateTimePicker1.Value = dateTimePicker2.Value;
            InitThongKeNhanVienDiTour();
        }
        private void datepicker_tu_doanhthutour_ValueChanged_1(object sender, EventArgs e)
        {
            if (datepicker_tu_doanhthutour.Value > datepicker_den_doanhthutour.Value)
                datepicker_den_doanhthutour.Value = datepicker_tu_doanhthutour.Value;
            InitThongKeTour();
        }
        private void datepicker_den_doanhthutour_ValueChanged_1(object sender, EventArgs e)
        {
            if (datepicker_den_doanhthutour.Value < datepicker_tu_doanhthutour.Value)
                datepicker_tu_doanhthutour.Value = datepicker_den_doanhthutour.Value;
            InitThongKeTour();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {

        }

       

    }
}

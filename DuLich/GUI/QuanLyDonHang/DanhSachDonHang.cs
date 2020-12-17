using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DuLich.BanHang_Entity;
using DuLich.BUS;
using DuLich.GUI.QuanLyTouris;

namespace DuLich.GUI.QuanLyDonHang
{

    public partial class DanhSachDonHang : UserControl,TimKiemDonHang.ITimKiemDonHang
    {
        private IDanhSachDonHangListener danhSachDonHangListener;
        private List<invoice> invoice_list;
        private List<String> trangthai = new List<string>();

        public DanhSachDonHang()
        {
            InitializeComponent();
        }
        public DanhSachDonHang(List<invoice> _invoice_list, IDanhSachDonHangListener danhSachDonHangListener)
        {
            InitializeComponent();
            this.danhSachDonHangListener = danhSachDonHangListener;
            this.invoice_list = _invoice_list;
            trangthai.Add("Chờ xác nhận");
            trangthai.Add("Đã xác nhận");
            trangthai.Add("Chờ giao hàng");
            trangthai.Add("Shipper đã nhận hàng");
            trangthai.Add("Hoàn thành");
            trangthai.Add("Hủy bỏ");
            if (invoice_list.Count > 0) 
                InitData();
        }

        private void InitData()
        {
            DateTime ngaytu = invoice_list.First().createddate;
            DateTime ngayden = invoice_list.First().createddate;
            long giatu = invoice_list.First().totalmoney;
            long giaden = invoice_list.First().totalmoney;

            foreach (invoice invoice in invoice_list)
            {
                if (invoice.createddate < ngaytu)
                    ngaytu = invoice.createddate;
                if (invoice.createddate > ngayden)
                    ngayden = invoice.createddate;
                if (invoice.totalmoney > giaden)
                    giaden = invoice.totalmoney;
                if (invoice.totalmoney < giatu)
                    giatu = invoice.totalmoney;
                ListViewItem item = new ListViewItem(new string[] {
                   invoice.id.ToString(),
                   invoice.customer.firstname + invoice.customer.lastname,
                   invoice.customeraddress,
                   invoice.totalmoney.ToString("N0")+"đ",
                   trangthai.ToArray()[invoice.status]
                }, -1);
                lv_combo.Items.Add(item);
            } 
            search1.SetData(ngaytu,ngayden,giatu,giaden, this);
        }

        private void initListViewData(List<invoice> invoices)
        {
            lv_combo.Items.Clear();
            foreach (invoice invoice in invoices)
            {
                ListViewItem item = new ListViewItem(new string[] {
                   invoice.id.ToString(),
                   invoice.customer.firstname,
                   invoice.customer.lastname,
                   invoice.customeraddress,
                   invoice.totalmoney.ToString("N0")+"đ",
                   trangthai.ToArray()[invoice.status]
                }, -1);
                lv_combo.Items.Add(item);
            }
        }

        public interface IDanhSachDonHangListener
        {
            void onDanhSachDonHang_SuaClick(invoice invoice);
            void onDanhSachDonHang_ThemClick();
            void onDanhSachDonHang_XoaClick(invoice invoice);
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            danhSachDonHangListener.onDanhSachDonHang_ThemClick();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            if (lv_combo.SelectedItems.Count <= 0)
                return;
            int position = lv_combo.SelectedItems[0].Index;
           danhSachDonHangListener.onDanhSachDonHang_XoaClick(invoice_list.ToList()[position]);
        }

        private void tourisBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        public void onTimKiem(long giatu, long giaden, DateTime ngaytu, DateTime ngayden)
        {
               initListViewData(invoice_list.Where(c => c.createddate >= ngaytu && c.createddate <= ngayden
                        && c.totalmoney >= giatu && c.totalmoney <= giaden
                    ).ToList());
        }

        private void lv_product_item_doubleclick(object sender, EventArgs e)
        {
            if (lv_combo.SelectedItems.Count <= 0)
                return;
            int position = lv_combo.SelectedItems[0].Index;
            danhSachDonHangListener.onDanhSachDonHang_SuaClick(invoice_list.ToList()[position]);

        }
    }
}

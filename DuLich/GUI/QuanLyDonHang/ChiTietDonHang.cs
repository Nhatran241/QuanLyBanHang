using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DuLich.BanHang_Entity;
using DuLich.BUS;

namespace DuLich.GUI.QuanLyDonHang
{
    public partial class ChiTietDonHang : Form,ChonThietBiHoacCombo.IChonThietBiListener, ChonThietBiHoacCombo.IThayDoiSoLuongListener
    {
        private invoice invoice;
        private invoice tmpInvoice;
        private List<invoicedetail> invoicedetails;
        private List<customer> customers;
        private IChiTietDonHangListener chiTietDonHangListener;
        private ChonThietBiHoacCombo chonThietBiHoacCombo;
        private List<String> trangthai = new List<string>();
        public ChiTietDonHang(invoice invoice,List<customer> customers,IChiTietDonHangListener chiTietDonHangListener)
        {
            InitializeComponent();
            this.invoice = invoice;
            this.customers = customers;
            this.chiTietDonHangListener = chiTietDonHangListener;
            tmpInvoice = new invoice();
            tmpInvoice.Map(this.invoice);
            invoicedetails = tmpInvoice.GetListInvoiceDetails();
            InitUI();
        }

        private void InitUI()
        {
            if (tmpInvoice.id == 0)
            {
                // Create new
                tmpInvoice.createddate = DateTime.Now;
                tmpInvoice.status = 0;
                tmpInvoice.customer = customers.FirstOrDefault();
                tmpInvoice.shipdate = DateTime.Now;
                tmpInvoice.invoice_name = "a";

            }
            foreach (customer cus in customers)
            {
                cb_customer.Items.Add(cus);
            }
            trangthai.Add("Chờ xác nhận");
            trangthai.Add("Đã xác nhận");
            trangthai.Add("Chờ giao hàng");
            trangthai.Add("Shipper đã nhận hàng");
            trangthai.Add("Hoàn thành");
            trangthai.Add("Hủy bỏ");
            foreach (String tranthai in trangthai)
            {
                cb_status.Items.Add(tranthai);
            }
            cb_customer.SelectedItem = tmpInvoice.customer;
            cb_status.SelectedIndex = tmpInvoice.status;
            loadListDetails();
        }

        private void loadListDetails()
        {
                lv_details.Items.Clear();
                foreach(invoicedetail de in invoicedetails)
                {
                ListViewItem item = new ListViewItem(new string[] {
                        de.id.ToString(),
                        de.combo != null ? de.combo.combo_name : de.product.product_name,
                        de.amount.ToString(),
                        (de.amount * de.price).ToString("N0")+"đ",
                }, -1) ;
                    lv_details.Items.Add(item);
                }
                updateGiaSauGiam();

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (invoicedetails.Count == 0) {
                MessageBox.Show("Vui lòng thêm ít nhất 1 chi tiết đơn hàng");
                return;            
            }
            invoice.Map(tmpInvoice);
            invoice.invoicedetails = invoicedetails;
            chiTietDonHangListener.onLuuClick(invoice);
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            chiTietDonHangListener.onHuyChiTietInvoiceClick();
        }
       
        public interface IChiTietDonHangListener
        {
            void onLuuClick(invoice invoice);
            void onHuyChiTietInvoiceClick();
        }

        private void updateGiaSauGiam()
        {
            long tongia = 0;
            foreach(invoicedetail de in invoicedetails)
                {
                    tongia += de.price * de.amount;
                }
                tb_tonggiasanpham.Text = tongia.ToString("N0") + "đ";
            tmpInvoice.totalmoney = tongia;
        }

        private void ChiTietCombo_Load(object sender, EventArgs e)
        {

        }

        private void btn_xoaThietBiKhoiCombo(object sender, EventArgs e)
        {
            if (lv_details.SelectedItems.Count <= 0)
                return;
            int position = lv_details.SelectedItems[0].Index;
            invoicedetail detail = invoicedetails[position];
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa chi tiết đơn hàng "+ detail.id +" ra khỏi đơn hàng này không","", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                invoicedetails.RemoveAt(position);
                loadListDetails();
            }
        }

        private void themSanPhamVaoComboClick(object sender, EventArgs e)
        {
            List<product> products = new List<product>();
            List<combo> combos = new List<combo>();
            foreach (invoicedetail de in invoicedetails)
            {
                if (de.combo != null)
                    combos.Add(de.combo);
                if (de.product != null)
                    products.Add(de.product);
            }
            chonThietBiHoacCombo = new ChonThietBiHoacCombo(products,combos, this);
            chonThietBiHoacCombo.ShowDialog();
        }

        public void onLuuClick(product product,combo combo, int soluong)
        {
            invoicedetail invoicedetail = new invoicedetail();
            if (combo != null)
            {
                invoicedetail.combo = combo;
                invoicedetail.price = combo.TotalPriceOfCombo() * soluong;
            }
            if (product != null)
            {
                invoicedetail.product = product;
                invoicedetail.price = product.PriceAfterDiscount() * soluong;
            }
            invoicedetail.amount = soluong;
            invoicedetails.Add(invoicedetail);
            loadListDetails();
            chonThietBiHoacCombo.Close();
        }

        public void onHuyClick()
        {
            chonThietBiHoacCombo.Close();
        }

        private void btn_thaydoisoluong_Click(object sender, EventArgs e)
        {

            if (lv_details.SelectedItems.Count <= 0)
              return;
            int position = lv_details.SelectedItems[0].Index;
            invoicedetail invoicedetail = invoicedetails[position];
            chonThietBiHoacCombo = new ChonThietBiHoacCombo(invoicedetail.id,invoicedetail.product, invoicedetail.combo, invoicedetail.amount, this);
            chonThietBiHoacCombo.ShowDialog();
        }

        public void onLuuThayDoiClick(int mainvoicedetail, int soluong)
        {
            invoicedetail invoicedetail = invoicedetails.Where(c => c.id == mainvoicedetail).FirstOrDefault();
            if (invoicedetail != null)
                invoicedetail.amount = soluong;
            loadListDetails();
            chonThietBiHoacCombo.Close();
        }

        private void cb_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            tmpInvoice.customer = customers.ToArray()[cb_customer.SelectedIndex];
            tmpInvoice.customeraddress = tmpInvoice.customer.address;
        }

        private void tb_tonggiasanpham_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            tmpInvoice.status = cb_status.SelectedIndex;
        }
    }
}

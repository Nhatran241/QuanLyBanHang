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

    public partial class DanhSachDonHang : UserControl,TimKiemDonHang.ITimKiemCombo
    {
        private IDanhSachDonHangListener danhSachDonHangListener;
        private List<combo> combo_list;
        private List<product> product_list;

        public DanhSachDonHang()
        {
            InitializeComponent();
        }
        public DanhSachDonHang(List<combo> _combo_list,List<product> _product_list, IDanhSachDonHangListener danhSachDonHangListener)
        {
            InitializeComponent();
            this.danhSachDonHangListener = danhSachDonHangListener;
            this.combo_list = _combo_list;
            this.product_list = _product_list;
            if(combo_list.Count > 0) 
                InitData();
        }

        private void InitData()
        {
            DateTime ngaytu = combo_list.First().createtime;
            DateTime ngayden = combo_list.First().createtime;
            long giatu = combo_list.First().TotalPriceOfCombo();
            long giaden = combo_list.First().TotalPriceOfCombo();

            foreach (combo combo in combo_list)
            {
                if (combo.createtime < ngaytu)
                    ngaytu = combo.createtime;
                if (combo.createtime > ngayden)
                    ngayden = combo.createtime;
                if (combo.TotalPriceOfCombo() > giaden)
                    giaden = combo.TotalPriceOfCombo();
                if (combo.TotalPriceOfCombo() < giatu)
                    giatu = combo.TotalPriceOfCombo();
                ListViewItem item = new ListViewItem(new string[] {
                   combo.id.ToString(),
                   combo.combo_name,
                   combo.createtime.ToString(),
                   combo.TotalPriceOfProductsCombo().ToString("N0")+"đ",
                   combo.discountpercent+"%",
                   combo.TotalPriceOfCombo().ToString("N0")+"đ"
                }, -1);;
                lv_combo.Items.Add(item);
            } 
            search1.SetData(ngaytu,ngayden,giatu,giaden, this);
        }

        private void initListViewData(List<combo> newlist)
        {
            lv_combo.Items.Clear();
            foreach (combo combo in newlist)
            {
                ListViewItem item = new ListViewItem(new string[] {
                   combo.id.ToString(),
                   combo.combo_name,
                   combo.createtime.ToString(),
                   combo.TotalPriceOfProductsCombo().ToString("N0")+"đ",
                   combo.discountpercent+"%",
                   combo.TotalPriceOfCombo().ToString("N0")+"đ"
                }, -1); ;
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
           // danhSachDonHangListener.onDanhSachDonHang_XoaClick(combo_list.ToList()[position]);
        }

        private void tourisBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        public void onTimKiem(string ten, long giatu, long giaden, DateTime ngaytu, DateTime ngayden)
        {
            if (!ten.Equals(""))
            {
                    initListViewData(combo_list.Where(c => c.combo_name.ToLower().Contains(ten)
                        && c.createtime >= ngaytu && c.createtime <=ngayden
                        && c.TotalPriceOfCombo() >= giatu && c.TotalPriceOfCombo() <= giaden
                    ).ToList());
            }
            else
            {
               initListViewData(combo_list.Where(c => c.createtime >= ngaytu && c.createtime <= ngayden
                        && c.TotalPriceOfCombo() >= giatu && c.TotalPriceOfCombo() <= giaden
                    ).ToList());
            }
        }

        private void lv_product_item_doubleclick(object sender, EventArgs e)
        {
            if (lv_combo.SelectedItems.Count <= 0)
                return;
            int position = lv_combo.SelectedItems[0].Index;
            //danhSachComboListener.onDanhSachCombo_SuaClick(combo_list.ToList()[position]);

        }
    }
}

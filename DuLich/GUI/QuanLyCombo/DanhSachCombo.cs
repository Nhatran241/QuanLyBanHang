using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DuLich.BanHang_Entity;
using DuLich.BUS;
using DuLich.GUI.QuanLyTouris;

namespace DuLich.GUI.QuanLyCombo
{

    public partial class DanhSachCombo : UserControl,TimKiemCombo.ITimKiemCombo
    {
        private IDanhSachComboListener danhSachComboListener;
        private IDanhSachChonComboListener danhSachChonComboListener;
        private List<combo> combo_list;

        public DanhSachCombo()
        {
            InitializeComponent();
        }
        public DanhSachCombo(List<combo> _combo_list, IDanhSachComboListener danhSachComboListener)
        {
            InitializeComponent();
            this.danhSachComboListener = danhSachComboListener;
            this.combo_list = _combo_list;
            if(combo_list.Count > 0) 
                InitData();
        }
        public DanhSachCombo(List<combo> _combo_list, IDanhSachChonComboListener danhSachChonComboListener)
        {
            InitializeComponent();
            btn_them.Visible = false;
            btn_xoa.Visible = false;
            this.danhSachChonComboListener = danhSachChonComboListener;
            this.combo_list = _combo_list;
            if (combo_list.Count > 0)
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

        public interface IDanhSachComboListener
        {
            void onDanhSachCombo_SuaClick(combo combo);
            void onDanhSachCombo_ThemClick();
            void onDanhSachCombo_XoaClick(combo combo);
        }
        public interface IDanhSachChonComboListener
        {
            void onDanhSachCombo_DoubleClick(combo combo);
        }



        private void btn_them_Click(object sender, EventArgs e)
        {
            danhSachComboListener.onDanhSachCombo_ThemClick();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            if (lv_combo.SelectedItems.Count <= 0)
                return;
            int position = lv_combo.SelectedItems[0].Index;
            danhSachComboListener.onDanhSachCombo_XoaClick(combo_list.ToList()[position]);
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
            if (danhSachComboListener != null)
                danhSachComboListener.onDanhSachCombo_SuaClick(combo_list.ToList()[position]);
            if (danhSachChonComboListener != null)
                danhSachChonComboListener.onDanhSachCombo_DoubleClick(combo_list.ToList()[position]);


        }
    }
}

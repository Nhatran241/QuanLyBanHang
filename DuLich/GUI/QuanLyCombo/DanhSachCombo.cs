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
        private List<Combo> combo_list;

        public DanhSachCombo()
        {
            InitializeComponent();
        }
        public DanhSachCombo(List<Combo> _combo_list, IDanhSachComboListener danhSachComboListener)
        {
            InitializeComponent();
            this.danhSachComboListener = danhSachComboListener;
            this.combo_list = _combo_list;
            InitData();
        }

        private void InitData()
        {
            DateTime ngaytu = combo_list.First().CreateTime;
            DateTime ngayden = combo_list.First().CreateTime;
            long giatu = combo_list.First().TotalPriceOfCombo();
            long giaden = combo_list.First().TotalPriceOfCombo();

            foreach (Combo combo in combo_list)
            {
                if (combo.CreateTime < ngaytu)
                    ngaytu = combo.CreateTime;
                if (combo.CreateTime > ngayden)
                    ngayden = combo.CreateTime;
                if (combo.TotalPriceOfCombo() > giaden)
                    giaden = combo.TotalPriceOfCombo();
                if (combo.TotalPriceOfCombo() < giatu)
                    giatu = combo.TotalPriceOfCombo();
                ListViewItem item = new ListViewItem(new string[] {
                   combo.ID.ToString(),
                   combo.Combo_Name,
                   combo.CreateTime.ToString(),
                   combo.TotalPriceOfProductsCombo().ToString("N0")+"đ",
                   combo.discountPercent+"%",
                   combo.TotalPriceOfCombo().ToString("N0")+"đ"
                }, -1);;
                lv_combo.Items.Add(item);
            }

           // search1.SetData(catalog_list,ngaytu,ngayden,giatu,giaden, this);
        }

        private void initListViewData(List<Combo> newlist)
        {
            lv_combo.Items.Clear();
            foreach (Combo combo in newlist)
            {
                ListViewItem item = new ListViewItem(new string[] {
                   combo.ID.ToString(),
                   combo.Combo_Name,
                   combo.CreateTime.ToString(),
                   combo.TotalPriceOfProductsCombo().ToString("N0")+"đ",
                   combo.discountPercent+"%",
                   combo.TotalPriceOfCombo().ToString("N0")+"đ"
                }, -1); ;
                lv_combo.Items.Add(item);
            }
        }

        public interface IDanhSachComboListener
        {
            void onDanhSachCombo_SuaClick(Combo combo);
            void onDanhSachCombo_ThemClick();
            void onDanhSachCombo_XoaClick(Combo combo);
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
                    initListViewData(combo_list.Where(c => c.Combo_Name.ToLower().Contains(ten)
                        && c.CreateTime >= ngaytu && c.CreateTime <=ngayden
                        && c.TotalPriceOfCombo() >= giatu && c.TotalPriceOfCombo() <= giaden
                    ).ToList());
            }
            else
            {
               initListViewData(combo_list.Where(c => c.CreateTime >= ngaytu && c.CreateTime <= ngayden
                        && c.TotalPriceOfCombo() >= giatu && c.TotalPriceOfCombo() <= giaden
                    ).ToList());
            }
        }

        private void lv_product_item_doubleclick(object sender, EventArgs e)
        {
            if (lv_combo.SelectedItems.Count <= 0)
                return;
            int position = lv_combo.SelectedItems[0].Index;
            danhSachComboListener.onDanhSachCombo_SuaClick(combo_list.ToList()[position]);

        }
    }
}

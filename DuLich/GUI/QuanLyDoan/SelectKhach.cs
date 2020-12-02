using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DuLich.BUS;

namespace DuLich.GUI.QuanLyDoan
{
    public partial class SelectKhach : UserControl
    {
        private List<Khach> danhSachTatCaKhach = new List<Khach>();
        private List<Khach> danhSachKhachTrongDoan = new List<Khach>();
        private List<Khach> danhSachKhachTrongDoanTam = new List<Khach>();
        private ISelectKhachListener selectKhachListener;
        private Doan baseDoan;
        public SelectKhach(Doan doanHienTai, List<Khach> danhSachTatCaKhach, List<Khach> danhSachKhachTrongDoan, ISelectKhachListener selectKhachListener)
        {
            InitializeComponent();
            UpdateComponentState();
            this.danhSachTatCaKhach.AddRange(danhSachTatCaKhach);
            this.danhSachKhachTrongDoan.AddRange(danhSachKhachTrongDoan);
            this.danhSachKhachTrongDoanTam.AddRange(danhSachKhachTrongDoan);
            this.selectKhachListener = selectKhachListener;
            baseDoan = doanHienTai;
            initData();
        }

        public void UpdateComponentState()
        {
            btn_luu.Visible = false;
        }


        private void initData()
        {
            if (danhSachTatCaKhach != null && danhSachKhachTrongDoan != null)
            {
                danhSachTatCaKhach.RemoveAll(c => danhSachKhachTrongDoan.Contains(c));
            }
            resetData();

        }

        private void resetData()
        {
            listbox_tatcakhach.Items.Clear();
            foreach (Khach khach in danhSachTatCaKhach)
            {
                ListViewItem listViewItem1 = new ListViewItem(new string[] {
            khach.MaKhach+"",
            khach.TenKhach,
            khach.SoDienThoai});
                this.listbox_tatcakhach.Items.Add(listViewItem1);
            }
            if (listbox_tatcakhach.Items.Count >= 1)
                listbox_tatcakhach.Items[listbox_tatcakhach.Items.Count - 1].Selected = true;

            listbox_khachtrongdoan.Items.Clear();
            foreach (Khach khach in danhSachKhachTrongDoan)
            {
                ListViewItem listViewItem1 = new ListViewItem(new string[] {
            khach.MaKhach+"",
            khach.TenKhach,
            khach.SoDienThoai});
                this.listbox_khachtrongdoan.Items.Add(listViewItem1);
            }
            if (listbox_khachtrongdoan.Items.Count >= 1)
                listbox_khachtrongdoan.Items[listbox_khachtrongdoan.Items.Count - 1].Selected = true;

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (listbox_tatcakhach.SelectedItems.Count == 0)
                return;
            Khach khach = (Khach)danhSachTatCaKhach[listbox_tatcakhach.SelectedItems[0].Index];
            danhSachKhachTrongDoan.Add(khach);
            ListViewItem listViewItem1 = new ListViewItem(new string[] {
            khach.MaKhach+"",
            khach.TenKhach,
            khach.SoDienThoai});
            listbox_khachtrongdoan.Items.Add(listViewItem1);
            if(listbox_khachtrongdoan.Items.Count>=1)
                listbox_khachtrongdoan.Items[listbox_khachtrongdoan.Items.Count - 1].Selected = true;
            danhSachTatCaKhach.RemoveAt(listbox_tatcakhach.SelectedItems[0].Index);
            listbox_tatcakhach.Items.RemoveAt(listbox_tatcakhach.SelectedItems[0].Index);
            if (listbox_tatcakhach.Items.Count >= 1)
                listbox_tatcakhach.Items[listbox_tatcakhach.Items.Count - 1].Selected = true;
            checkSuThayDoi();
        }


        private void checkSuThayDoi()
        {
            if (danhSachKhachTrongDoan.Count == danhSachKhachTrongDoanTam.Count)
            {
                foreach(Khach khach in danhSachKhachTrongDoan)
                {
                    if (!danhSachKhachTrongDoanTam.Contains(khach))
                    {
                        ShowLuuButton();
                        return;
                    }
                    HideLuuButton();
                }
            }
            else {
                ShowLuuButton();
            }
        }

        private void listbox_chondiadiem_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (listbox_khachtrongdoan.SelectedItems.Count == 0)
                return;
            Khach khach = (Khach)danhSachKhachTrongDoan[listbox_khachtrongdoan.SelectedItems[0].Index];
            danhSachTatCaKhach.Add(khach);
            ListViewItem listViewItem1 = new ListViewItem(new string[] {
            khach.MaKhach+"",
            khach.TenKhach,
            khach.SoDienThoai});
            listbox_tatcakhach.Items.Add(listViewItem1);

            if (listbox_tatcakhach.Items.Count >= 1)
                listbox_tatcakhach.Items[listbox_tatcakhach.Items.Count - 1].Selected = true;

            danhSachKhachTrongDoan.RemoveAt(listbox_khachtrongdoan.SelectedItems[0].Index);
            listbox_khachtrongdoan.Items.RemoveAt(listbox_khachtrongdoan.SelectedItems[0].Index);
            if (listbox_khachtrongdoan.Items.Count >= 1)
                listbox_khachtrongdoan.Items[listbox_khachtrongdoan.Items.Count - 1].Selected = true;
            checkSuThayDoi();
        }

        public interface ISelectKhachListener
        {
            void onSelectKhach_LuuClick(Doan doanHienTai,List<Khach> danhSachKhachTrongDoanUpdate);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            selectKhachListener.onSelectKhach_LuuClick(baseDoan,danhSachKhachTrongDoan);
        }

        internal void ShowLuuButton()
        {
            btn_luu.Visible = true;
        }

        internal void HideLuuButton()
        {
            btn_luu.Visible = false;
        }

        private void SelectKhach_Load(object sender, EventArgs e)
        {

        }

        private void tv_khachtrongdoan_Click(object sender, EventArgs e)
        {

        }

        private void btn_up_Click(object sender, EventArgs e)
        {

        }

        private void btn_down_Click(object sender, EventArgs e)
        {

        }

        private void tv_tatcakhach_Click(object sender, EventArgs e)
        {

        }
    }
}

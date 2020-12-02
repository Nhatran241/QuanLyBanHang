using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DuLich.BUS;

namespace DuLich.GUI.QuanLyTouris
{
    public partial class SearchTour : UserControl
    {
        private List<Loai> danhSachLoai = new List<Loai>();
        private Loai filterLoai = new Loai();
        private String filterTen = "";
        private ISearchListener searchListener;

        public SearchTour()
        {
            InitializeComponent();
        }
        public void SetData(List<Loai> loai,ISearchListener searchListener)
        {
            tv_searchbox.Text = "Tên Tour";
            tv_combo.Text = "Loại";
            this.danhSachLoai.AddRange(loai);
            this.searchListener = searchListener;
            filterLoai.MaLoai = -1;
            filterLoai.TenLoai = "Bất kỳ";
            danhSachLoai.Insert(0,filterLoai);
            InitData(danhSachLoai);
        }

        private void InitData(List<Loai> danhSachLoai)
        {
            cb_search.SelectedItem = filterLoai;
            foreach(Loai loai in danhSachLoai)
            {
                cb_search.Items.Add(loai);
            }
        }

        private void cb_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterLoai = danhSachLoai[cb_search.SelectedIndex];
            searchListener.onSearch(filterLoai, filterTen);
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            filterTen = tb_search.Text.Trim().ToLower();
            if(searchListener != null)
                searchListener.onSearch(filterLoai, filterTen);
        }

        public interface ISearchListener
        {
            void onSearch(Loai loai, string ten);
        }
    }
}

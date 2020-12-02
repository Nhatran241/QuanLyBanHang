using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DuLich.GUI.QuanLyNhanVien
{
    public partial class SearchNhanVien : UserControl
    {
        private String filterTen = "";
        private DateTime minDate = new DateTime();
        private DateTime maxDate = new DateTime();
        private string gioitinh = "Bất kỳ";
        private ISearchNhanVienListener searchNhanVienListener;

        public SearchNhanVien()
        {
            InitializeComponent();
        }
        public void SetData(ISearchNhanVienListener searchNhanVienListener,DateTime min,DateTime max)
        {
            this.searchNhanVienListener = searchNhanVienListener;
            if (min != DateTime.MinValue && max != DateTime.MaxValue)
            {
                this.minDate = min;
                this.maxDate = max;
                datepicker_ketthuc.Value = max;
                datepicker_batdau.Value = min;
            }
            InitData();
        }

        private void InitData()
        {
            if (minDate != DateTime.MinValue && maxDate != DateTime.MaxValue)
            {
                datepicker_batdau.MinDate = minDate;
                datepicker_batdau.MaxDate = maxDate;
                datepicker_ketthuc.MaxDate = maxDate;
                datepicker_ketthuc.MinDate = minDate;
            }
            List<string> list = new List<string> { "Bất kỳ", "Nam", "Nữ", "Khác" };
            cb_gioitinh.DataSource = list;
        }


        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            filterTen = tb_search.Text.Trim().ToLower();
            if(searchNhanVienListener != null)
                searchNhanVienListener.onSearchNhanVien(filterTen,gioitinh,minDate,maxDate);
        }

        public interface ISearchNhanVienListener
        {
            void onSearchNhanVien(string ten,string gioiTinh,DateTime min,DateTime max);
        }



        private void datepicker_batdau_ValueChanged(object sender, EventArgs e)
        {

            minDate = datepicker_batdau.Value;
            if (minDate >= maxDate)
                datepicker_ketthuc.Value = minDate;
            searchNhanVienListener.onSearchNhanVien(filterTen,gioitinh, minDate, maxDate);
        }

        private void datepicker_ketthuc_ValueChanged(object sender, EventArgs e)
        {

            maxDate = datepicker_ketthuc.Value;
            if (maxDate < minDate)
                datepicker_batdau.Value = maxDate;
            searchNhanVienListener.onSearchNhanVien(filterTen,gioitinh, minDate, maxDate);
        }

        private void cb_gioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            gioitinh = (string)cb_gioitinh.SelectedItem;
            searchNhanVienListener.onSearchNhanVien(filterTen,gioitinh , minDate, maxDate);
        }
    }
}

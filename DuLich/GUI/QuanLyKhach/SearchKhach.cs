using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DuLich.GUI.QuanLyKhach
{
    public partial class SearchKhach : UserControl
    {
        private String filterTen = "";
        private DateTime minDate = new DateTime();
        private DateTime maxDate = new DateTime();
        private string gioitinh = "Bất kỳ";
        private ISearchKhachListener searchKhachListener;

        public SearchKhach()
        {
            InitializeComponent();
        }
        public void SetData(ISearchKhachListener searchKhachListener,DateTime min,DateTime max)
        {
            this.searchKhachListener = searchKhachListener;
            if(min!=DateTime.MinValue && max!=DateTime.MaxValue)
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
            if (minDate!=DateTime.MinValue && maxDate != DateTime.MaxValue)
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
            if(searchKhachListener != null)
                searchKhachListener.onSeachKhach(filterTen,gioitinh,minDate,maxDate);
        }

        public interface ISearchKhachListener
        {
            void onSeachKhach(string ten,string gioiTinh,DateTime min,DateTime max);
        }



        private void datepicker_batdau_ValueChanged(object sender, EventArgs e)
        {

            minDate = datepicker_batdau.Value;
            if (minDate >= maxDate)
                datepicker_ketthuc.Value = minDate;
            searchKhachListener.onSeachKhach(filterTen,gioitinh, minDate, maxDate);
        }

        private void datepicker_ketthuc_ValueChanged(object sender, EventArgs e)
        {

            maxDate = datepicker_ketthuc.Value;
            if (maxDate < minDate)
                datepicker_batdau.Value = maxDate;
            searchKhachListener.onSeachKhach(filterTen,gioitinh, minDate, maxDate);
        }

        private void cb_gioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            gioitinh = (string)cb_gioitinh.SelectedItem;
            searchKhachListener.onSeachKhach(filterTen,gioitinh , minDate, maxDate);
        }
    }
}

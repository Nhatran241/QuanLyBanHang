using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DuLich.BanHang_Entity;
using DuLich.BUS;

namespace DuLich.GUI.QuanLyThietBi
{
    public partial class TimKiemThietBi : UserControl
    {
        private List<Catalog> catalogs = new List<Catalog>();
        private Catalog filterCatalog = new Catalog();
        private string filterTen = "";
        private long giatu = 0;
        private long giaden = long.MaxValue;
        private DateTime ngaytu = new DateTime();
        private DateTime ngayden = new DateTime();
        private ITimKiemThietBiListener timKiemThietBiListener;
        private bool initDataCompleted = false;

        public TimKiemThietBi()
        {
            InitializeComponent();
        }
        public void SetData(List<Catalog> catalogs,DateTime ngaytu,DateTime ngayden,long giatu,long giaden,ITimKiemThietBiListener timKiemThietBiListener)
        {
            this.timKiemThietBiListener = timKiemThietBiListener;
            this.catalogs.AddRange(catalogs);
            this.ngaytu = ngaytu;
            this.ngayden = ngayden;
            this.giatu = giatu;
            this.giaden = giaden;
            filterCatalog.ID = -1;
            filterCatalog.Catalog_Name = "Bất kỳ";
            this.catalogs.Insert(0, filterCatalog);
            InitData();
        }

        private void InitData()
        {
            foreach(Catalog cat in catalogs)
            {
                cb_search.Items.Add(cat);
            }
            cb_search.SelectedItem = filterCatalog;
            tb_pricefrom.Text = giatu.ToString();
            tb_priceto.Text = giaden.ToString();
            datepickbatdau.MaxDate = ngayden;
            datepickbatdau.MinDate = ngaytu;
            datepickketthuc.MaxDate = ngayden;
            datepickketthuc.MinDate = ngaytu;
            datepickbatdau.Value = datepickbatdau.MinDate;
            datepickketthuc.Value = datepickketthuc.MaxDate;
            initDataCompleted = true;
        }

        private void cb_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterCatalog = catalogs[cb_search.SelectedIndex];
            timKiemThietBiListener.onTimKiem(filterCatalog, filterTen,giatu,giaden,ngaytu,ngayden);
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            filterTen = tb_search.Text.Trim().ToLower();
            if(timKiemThietBiListener != null)
                timKiemThietBiListener.onTimKiem(filterCatalog, filterTen, giatu, giaden, ngaytu, ngayden);
        }

        public interface ITimKiemThietBiListener
        {
            void onTimKiem(Catalog cat, string ten,long giatu,long giaden,DateTime ngaytu,DateTime ngayden);
        }

        private void datepickbatdau_ValueChanged(object sender, EventArgs e)
        {
            if (!initDataCompleted)
                return;
            if (datepickbatdau.Value >= datepickketthuc.Value)
                datepickketthuc.Value = datepickbatdau.Value;
            timKiemThietBiListener.onTimKiem(filterCatalog, filterTen,giatu,giaden, datepickbatdau.Value, datepickketthuc.Value) ;
        }

        private void datepickketthuc_ValueChanged(object sender, EventArgs e)
        {
            if (!initDataCompleted)
                return;
            if (datepickketthuc.Value < datepickbatdau.Value)
                datepickbatdau.Value = datepickketthuc.Value;
            timKiemThietBiListener.onTimKiem(filterCatalog, filterTen, giatu, giaden, datepickbatdau.Value, datepickketthuc.Value);
        }

        private void tb_pricefrom_TextChanged(object sender, EventArgs e)
        {
            if (!initDataCompleted)
                return;
            string number = numberOnly(tb_pricefrom.Text.ToString());
            if (tb_pricefrom.Text != number)
                tb_pricefrom.Text = number;
            if (tb_pricefrom.Text.Length > 0)
            {
                giatu = long.Parse(number);
            }
            else giatu = 0;
            timKiemThietBiListener.onTimKiem(filterCatalog, filterTen, giatu, giaden, datepickbatdau.Value, datepickketthuc.Value);
     
        }

        private string numberOnly(string v)
        {
            string actualdata = string.Empty;
            char[] entereddata = v.ToCharArray();
            foreach (char aChar in entereddata.AsEnumerable())
            {
                if (char.IsDigit(aChar))
                {
                    actualdata = actualdata + aChar;
                }
                else
                {
                    actualdata.Replace(aChar, ' ');
                    actualdata.Trim();
                }
            }
            return actualdata;
        }

        private void tb_priceto_TextChanged(object sender, EventArgs e)
        {
            if (!initDataCompleted)
                return;
            string number = numberOnly(tb_priceto.Text.ToString());
            if (tb_priceto.Text != number)
                tb_priceto.Text = number;
            if (tb_priceto.Text.Length > 0)
            {
                giaden = long.Parse(number);
            }
            else giatu = 0;
            timKiemThietBiListener.onTimKiem(filterCatalog, filterTen, giatu, giaden, datepickbatdau.Value, datepickketthuc.Value);
        }
    }
}

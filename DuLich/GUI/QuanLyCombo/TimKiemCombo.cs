﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DuLich.BanHang_Entity;
using DuLich.BUS;

namespace DuLich.GUI.QuanLyCombo
{
    public partial class TimKiemCombo : UserControl
    {
        private string filterTen = "";
        private long giatu = 0;
        private long giaden = long.MaxValue;
        private DateTime ngaytu = new DateTime();
        private DateTime ngayden = new DateTime();
        private ITimKiemCombo timKiemCombo;
        private bool initDataCompleted = false;

        public TimKiemCombo()
        {
            InitializeComponent();
        }
        public void SetData(DateTime ngaytu,DateTime ngayden,long giatu,long giaden,ITimKiemCombo timKiemCombo)
        {
            this.timKiemCombo = timKiemCombo;
            this.ngaytu = ngaytu;
            this.ngayden = ngayden;
            this.giatu = giatu;
            this.giaden = giaden;
            InitData();
        }

        private void InitData()
        {
         
            tb_pricefrom.Text = giatu.ToString("N0")+"đ";
            tb_priceto.Text = giaden.ToString("N0")+"đ";
            datepickbatdau.MaxDate = ngayden;
            datepickbatdau.MinDate = ngaytu;
            datepickketthuc.MaxDate = ngayden;
            datepickketthuc.MinDate = ngaytu;
            datepickbatdau.Value = datepickbatdau.MinDate;
            datepickketthuc.Value = datepickketthuc.MaxDate;
            initDataCompleted = true;
        }


        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            filterTen = tb_search.Text.Trim().ToLower();
            if(timKiemCombo != null)
                timKiemCombo.onTimKiem(filterTen, giatu, giaden, ngaytu, ngayden);
        }

        public interface ITimKiemCombo
        {
            void onTimKiem(string ten,long giatu,long giaden,DateTime ngaytu,DateTime ngayden);
        }

        private void datepickbatdau_ValueChanged(object sender, EventArgs e)
        {
            if (!initDataCompleted)
                return;
            if (datepickbatdau.Value >= datepickketthuc.Value)
                datepickketthuc.Value = datepickbatdau.Value;
            timKiemCombo.onTimKiem(filterTen,giatu,giaden, datepickbatdau.Value, datepickketthuc.Value) ;
        }

        private void datepickketthuc_ValueChanged(object sender, EventArgs e)
        {
            if (!initDataCompleted)
                return;
            if (datepickketthuc.Value < datepickbatdau.Value)
                datepickbatdau.Value = datepickketthuc.Value;
            timKiemCombo.onTimKiem(filterTen, giatu, giaden, datepickbatdau.Value, datepickketthuc.Value);
        }

        private void tb_pricefrom_TextChanged(object sender, EventArgs e)
        {
            if (!initDataCompleted)
                return;
            string nodotnod = tb_pricefrom.Text.ToString().Replace(",", "").Replace("đ", "");
            string number = numberOnly(nodotnod);
            if (number.Length > 0)
            {
                tb_pricefrom.Text = long.Parse(number).ToString("N0") + "đ";
                tb_pricefrom.Focus();
                tb_pricefrom.SelectionStart = tb_pricefrom.Text.Length - 1;
                giatu = long.Parse(number);

            }
            else
            {
                tb_pricefrom.Text = "0đ";
                giatu = 0;
            }
            timKiemCombo.onTimKiem(filterTen, giatu, giaden, datepickbatdau.Value, datepickketthuc.Value);
     
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
            string nodotnod = tb_priceto.Text.ToString().Replace(",", "").Replace("đ", "");
            string number = numberOnly(nodotnod);
            if (number.Length > 0)
            {
                tb_priceto.Text = long.Parse(number).ToString("N0") + "đ";
                tb_priceto.Focus();
                tb_priceto.SelectionStart = tb_priceto.Text.Length - 1;
                giaden = long.Parse(number);

            }
            else
            {
                tb_priceto.Text = "0đ";
                giaden = 0;
            }
            timKiemCombo.onTimKiem(filterTen, giatu, giaden, datepickbatdau.Value, datepickketthuc.Value);
        }
    }
}

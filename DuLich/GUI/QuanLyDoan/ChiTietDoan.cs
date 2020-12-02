using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DuLich.BUS;
using DuLich.GUI.QuanLyChiPhi;
using DuLich.GUI.QuanLyPhanCong;

namespace DuLich.GUI.QuanLyDoan
{
    public partial class ChiTietDoan : UserControl
    {
        private IChiTietDoanListener chiTietDoanListener;
        private DanhSachPhanCong.IDanhSachPhanCongListener danhSachPhanCongListener;
        private DanhSachChiPhi.IDanhSachChiPhiListener danhSachChiPhiListener;
        private SelectKhach.ISelectKhachListener selectKhachListener;
        private UserControl chiTietUserControl;
        private bool isEditing = false;

        private Doan baseDoan;
        private Doan editDoan;
        private List<Tour> danhSachTour;
        private List<PhanCong> danhSachPhanCong;
        private List<Khach> danhSachTatCaKhach;
        private List<Khach> danhSachKhachTrongDoan;
        private List<ChiPhi> danhSachChiPhi;

        public ChiTietDoan(Doan doan, List<Tour> listTour, List<PhanCong> phanCongs,List<ChiPhi> danhSachChiPhi, List<Khach> tatcakhach, List<Khach> khachtrongdoan,IChiTietDoanListener chiTietDoanListener,DanhSachPhanCong.IDanhSachPhanCongListener danhSachPhanCongListener,SelectKhach.ISelectKhachListener selectKhachListener,DanhSachChiPhi.IDanhSachChiPhiListener danhSachChiPhiListener)
        {
            InitializeComponent();
            this.chiTietDoanListener = chiTietDoanListener;
            this.danhSachPhanCongListener = danhSachPhanCongListener;
            this.selectKhachListener = selectKhachListener;
            this.danhSachChiPhiListener = danhSachChiPhiListener;
            this.danhSachChiPhi = danhSachChiPhi;
            this.danhSachTour = listTour;
            this.danhSachPhanCong = phanCongs;
            this.danhSachTatCaKhach = tatcakhach;
            this.danhSachKhachTrongDoan = khachtrongdoan;
            this.baseDoan = doan;
            editDoan = new Doan();
            editDoan.Map(doan);

            if (danhSachTour.Count() == 0)
            {
                panel_thongbao.Visible = true;
                return;
            }
            if (doan.MaDoan == 0)
            {
                this.editDoan = new Doan();
                if (editDoan.Tour == null)
                    editDoan.Tour = danhSachTour.First();
                textbox_id.Enabled = false;
                btn_xoa.Visible = false;
                isEditing = true;
            }    
            UpdateComponentState();
            InitData();
        }
      

        public void UpdateComponentState()
        {
            if (editDoan.MaDoan == 0)
            {
                tab_chitiet.Enabled = false;
                tb_loinhuan.Visible = false;
                tb_tongchiphi.Visible = false;
                tv_loinhuan.Visible = false;
                tv_tongchiphi.Visible = false;
            }
            else
            {
                tab_chitiet.Enabled = true;
                tb_loinhuan.Visible = true;
                tb_tongchiphi.Visible = true;
                tv_loinhuan.Visible = true;
                tv_tongchiphi.Visible = true;
            }
            if (isEditing)
            {
                EnableComponent();
                btn_chinhsua.Text = "Lưu";

            }
            else
            {
                DisableComponent();
                btn_chinhsua.Text = "Sửa";
            }
       
        }

        private void DisableComponent()
        {
           // textbox_id.Visible = true;
            //doan_id.Visible = true;
            btn_xoa.Visible = true;
            textbox_id.Enabled = false;
            textbox_name.Enabled = false;
            combobox_loai.Enabled = false;
            cb_giatour.Enabled = false;
            datepicker_batdau.Enabled = false;
            datepicker_ketthuc.Enabled = false;
        }
        private void EnableComponent()
        {
            btn_xoa.Visible = false;
            //textbox_id.Enabled = false;
            textbox_name.Enabled = true;
            combobox_loai.Enabled = true;
            cb_giatour.Enabled = true;
            datepicker_batdau.Enabled = true;
            datepicker_ketthuc.Enabled = true;
        }


        public void UpdateData(List<PhanCong> phanCongs, List<ChiPhi> danhSachChiPhi, List<Khach> tatcakhach, List<Khach> khachtrongdoan)
        {
            this.danhSachChiPhi = danhSachChiPhi;
            this.danhSachPhanCong = phanCongs;
            this.danhSachTatCaKhach = tatcakhach;
            this.danhSachKhachTrongDoan = khachtrongdoan;
            InitData();
        }
        private void InitData()
        {
          
            InitUI(editDoan);
            if (tab_chitiet.SelectedTab.Name.Equals("tab_phancong"))
            {
                if(danhSachPhanCong != null)
                    LoadDanhSachPhanCong(danhSachPhanCong);
            }else if (tab_chitiet.SelectedTab.Name.Equals("tab_khach"))
            {
                if (danhSachKhachTrongDoan != null)
                    LoadDanhSachKhach(danhSachTatCaKhach, danhSachKhachTrongDoan);
            }
            else
            {
                if (danhSachChiPhi != null)
                    LoadDanhSachChiPhi(danhSachChiPhi);
            }
            
        }

        public void LoadDanhSachPhanCong(List<PhanCong> phanCongs)
        {
            tab_phancong.Controls.Clear();
            tab_phancong.Controls.Add(new DanhSachPhanCong(baseDoan,phanCongs,danhSachPhanCongListener));
        }
        public void LoadDanhSachKhach(List<Khach> danhSachTatCaKhach,List<Khach> danhSachKhachTrongDoan)
        {
            tab_khach.Controls.Clear();
            tab_khach.Controls.Add(new SelectKhach(baseDoan,danhSachTatCaKhach,danhSachKhachTrongDoan,selectKhachListener));
        }
        private void LoadDanhSachChiPhi(List<ChiPhi> danhSachChiPhi)
        {
            tab_chiphi.Controls.Clear();
            tab_chiphi.Controls.Add(new DanhSachChiPhi(baseDoan,danhSachChiPhi,danhSachChiPhiListener));

        }

        public void InitUI(Doan doan)
        {
            if (doan.MaDoan != 0)
            {
                textbox_id.Text = doan.MaDoan.ToString();
                datepicker_batdau.Value = editDoan.ThoiGianBatDau;
                datepicker_ketthuc.Value = editDoan.ThoiGianKetThuc;
                datepicker_batdau.MinDate = editDoan.GiaApDung.ThoiGianBatDau;
                datepicker_ketthuc.MinDate = editDoan.GiaApDung.ThoiGianBatDau;

            }
            else
            {
                textbox_id.Text = "Mã tự động";
            }
            textbox_name.Text = doan.TenDoan;
            if(combobox_loai.Items.Count ==0) {
                foreach (Tour tour in danhSachTour)
                {
                    combobox_loai.Items.Add(tour);
                }
            }
           
            if(editDoan.Tour != null)
                combobox_loai.Text = editDoan.Tour.TenTour;
            if (editDoan.Tour!= null && editDoan.Tour.GiaTour != null)
            {
                if(cb_giatour.Items.Count ==0)
                {
                    foreach (Gia gia in editDoan.Tour.GiaTour)
                    {
                        cb_giatour.Items.Add(gia);
                    }
                }
                cb_giatour.SelectedItem = editDoan.GiaApDung;
            }
            UpDateLoiNhuan();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isEditing)
                return;
            editDoan.Tour = danhSachTour.ToArray()[combobox_loai.SelectedIndex];
            cb_giatour.DataSource = editDoan.Tour.GiaTour.ToList();
        }
        private void cb_giatour_SelectedIndexChanged(object sender, EventArgs e)
        {
            editDoan.GiaApDung = editDoan.Tour.GiaTour.ToArray()[cb_giatour.SelectedIndex];
            UpdateMinMaxDatepicker();
        }

        private void UpdateMinMaxDatepicker()
        {
            DateTimePicker temp = new DateTimePicker();
            datepicker_batdau.MinDate = temp.MinDate;
            datepicker_batdau.MaxDate = temp.MaxDate;
            datepicker_ketthuc.MinDate = temp.MinDate;
            datepicker_batdau.MaxDate = editDoan.GiaApDung.ThoiGianKetThuc;
            datepicker_batdau.MinDate = editDoan.GiaApDung.ThoiGianBatDau;
            datepicker_ketthuc.MinDate = editDoan.GiaApDung.ThoiGianBatDau;
        }

        private void TabControl1_Selected(Object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Name=="tab_phancong") {
                LoadDanhSachPhanCong(danhSachPhanCong);
            }
            else if(e.TabPage.Name == "tab_khach")
            {
                LoadDanhSachKhach(danhSachTatCaKhach,danhSachKhachTrongDoan);
            }else
            {
                LoadDanhSachChiPhi(danhSachChiPhi);
            }
        }

      

        public interface IChiTietDoanListener
        {
            void onChiTietDoanClick_CapNhat(Doan doanSauKhiCapNhat);
            void onChiTietDoanClick_Xoa(Doan doanCanXoa);
        }

        
     

        private void btn_chinhsua_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {

                if (Validation(editDoan))
                {
                    baseDoan.Map(editDoan);
                    chiTietDoanListener.onChiTietDoanClick_CapNhat(baseDoan);
                }
                else
                {
                    MessageBox.Show("Tên đoàn hoặc tour không được bỏ trống");
                    return;
                }
            }
            isEditing = !isEditing;
            UpdateComponentState();
        }

        private void textbox_name_TextChanged(object sender, EventArgs e)
        {
            editDoan.TenDoan = textbox_name.Text.Trim();
        }

        private bool Validation(Doan doanSauKhiCapNhat)
        {
            if (string.IsNullOrEmpty(doanSauKhiCapNhat.TenDoan) || doanSauKhiCapNhat.Tour == null)
                return false;
            return true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            chiTietDoanListener.onChiTietDoanClick_Xoa(baseDoan);
        }


        private void datepicker_batdau_ValueChanged(object sender, EventArgs e)
        {

            editDoan.ThoiGianBatDau = datepicker_batdau.Value;
            if (editDoan.ThoiGianBatDau > editDoan.ThoiGianKetThuc)
            {
                editDoan.ThoiGianKetThuc = editDoan.ThoiGianBatDau;
                datepicker_ketthuc.Value = editDoan.ThoiGianBatDau;
            }
            UpDateLoiNhuan();

        }

        private void UpDateLoiNhuan()
        {
            if (editDoan.GiaApDung != null)
            {
                if (danhSachChiPhi != null)
                {
                    long tongChiPhi = danhSachChiPhi.Sum(c => c.GiaTri);
                    tb_tongchiphi.Text = tongChiPhi.ToString();
                    tb_loinhuan.Text = ((editDoan.GiaApDung.GiaTri * (danhSachKhachTrongDoan!= null ?danhSachKhachTrongDoan.Count:0)) - tongChiPhi).ToString();
                }
                else
                {
                    tb_loinhuan.Text = tb_loinhuan.Text = ((editDoan.GiaApDung.GiaTri * (danhSachKhachTrongDoan != null ?danhSachKhachTrongDoan.Count:0))).ToString();
                    tb_tongchiphi.Text = "0";
                }
            }
            else
            {
                tb_loinhuan.Text = "0";
                tb_tongchiphi.Text = "0";
            }
        }

        /**
private void TinhGiaTour()
{
   long giaTam = doanHienTai.GiaTour;
   if(doanHienTai.Touris.Gias != null)
   {
       foreach (Gia gia in doanHienTai.Touris.Gias)
       {
           if(doanHienTai.ThoiGianBatDau>=gia.ThoiGianBatDau&&doanHienTai.ThoiGianBatDau <= gia.ThoiGianKetThuc)
           {
               tb_giatour.Text = gia.GiaTri.ToString();
               doanHienTai.GiaTour = long.Parse(gia.GiaTri.ToString());
               long tongChiPhi = danhSachChiPhi.Sum(c => c.giaTri);
               tb_loinhuan.Text = (doanHienTai.GiaTour - tongChiPhi).ToString();
               return;
           }
       }

       doanHienTai.GiaTour = giaTam;
       tb_loinhuan.Text = (doanHienTai.GiaTour - danhSachChiPhi.Sum(c => c.giaTri)).ToString();
   }
  
}
*/


        private void datepicker_ketthuc_ValueChanged_1(object sender, EventArgs e)
        {
            editDoan.ThoiGianKetThuc = datepicker_ketthuc.Value;
            if (editDoan.ThoiGianKetThuc < editDoan.ThoiGianBatDau)
            {
                editDoan.ThoiGianKetThuc = editDoan.ThoiGianBatDau;
                datepicker_ketthuc.Value = editDoan.ThoiGianBatDau;
            }
        }

        private void ChiTietDoan_Load(object sender, EventArgs e)
        {

        }
    }
}

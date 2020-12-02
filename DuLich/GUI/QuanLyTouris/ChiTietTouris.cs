using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DuLich.View.QuanLyTouris;
using DuLich.BUS;

namespace DuLich.GUI.QuanLyTouris
{
    public partial class ChiTietTouris : UserControl
    {
        private OnChiTietTourListener onChiTietClickListener;
        private DanhSachChonDiaDiem.IDanhSachChonDiaDiemListener danhSachChonDiaDiemListener;
        private DanhSachGia.IDanhSachGiaListener danhSachGiaListener;
        private bool isEditing = false;
        private Tour baseTour;
        private Tour editTour;
        private Loai currentLoai;
        private List<Loai> danhSachLoai;
        private List<Gia> danhSachGia;
        private List<DiaDiem> danhSachTatCaDiaDiem;
        private List<DiaDiem> danhSachDiaDiemCuaTor;
        public ChiTietTouris(Tour touris,List<Loai> loais, List<Gia> gias, List<DiaDiem> tatCaDiaDiem, List<DiaDiem> diaDiemCuaTour, OnChiTietTourListener onChiTietClickListener,DanhSachChonDiaDiem.IDanhSachChonDiaDiemListener danhSachChonDiaDiemListener,DanhSachGia.IDanhSachGiaListener danhSachGiaListener)
        {
            InitializeComponent();
            this.onChiTietClickListener = onChiTietClickListener;
            this.danhSachChonDiaDiemListener = danhSachChonDiaDiemListener;
            this.danhSachGiaListener = danhSachGiaListener;
            baseTour = touris;
            editTour = new Tour();
            editTour.Map(touris);
            this.danhSachLoai = loais;
            this.danhSachGia = gias;
            this.danhSachTatCaDiaDiem = tatCaDiaDiem;
            this.danhSachDiaDiemCuaTor = diaDiemCuaTour;
            if (editTour.MaTour == 0)
            {
                currentLoai = danhSachLoai.First();
                btn_xoa.Visible = false;
                isEditing = true;
            }
            UpdateComponentState();
            InitData();
        }
 
        public void UpdateComponentState()
        {
            if (editTour.MaTour == 0)
            {
                tab_chitiet.Enabled = false;
            }
            else
            {
                tab_chitiet.Enabled = true;
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
            btn_xoa.Visible = true;
            textbox_id.Enabled = false;
            textbox_name.Enabled = false;
            combobox_loai.Enabled = false;
        }
        private void EnableComponent()
        {
            btn_xoa.Visible = false;
            textbox_id.Enabled = false;
            textbox_name.Enabled = true;
            combobox_loai.Enabled = true;
        }

        
         
        private void InitData()
        {
            InitUI(editTour);
            if (tab_chitiet.SelectedTab.Name.Equals("tab_gia"))
            {
                if (danhSachGia != null)
                    LoadDanhSachGia();
            }
            else if (tab_chitiet.SelectedTab.Name.Equals("tab_diadiem"))
            {
                if (danhSachDiaDiemCuaTor != null)
                    LoadDanhSachDiaDiem();
            }
            else
            {
                LoadThongKeTheoTour();
            }
        }
        public void UpdateData(List<Gia> danhSachGia, List<DiaDiem> danhSachDiaDiemCuaTour)
        {
            this.danhSachGia = danhSachGia;
            this.danhSachDiaDiemCuaTor = danhSachDiaDiemCuaTour;
            InitData();
        }
        public void InitUI(Tour touris)
        {
            foreach (Loai loai in danhSachLoai)
            {
                if (editTour.LoaiTour != null && loai.MaLoai == editTour.LoaiTour.MaLoai)
                    currentLoai = loai;
                combobox_loai.Items.Add(loai);
            }
            if (touris.MaTour != 0)
            {
                textbox_id.Text = touris.MaTour.ToString();
                combobox_loai.SelectedItem = touris.LoaiTour;
            }
            else
            {
                textbox_id.Text = "Mã tự động";
                combobox_loai.SelectedItem = danhSachLoai.First();
            }
            textbox_name.Text = touris.TenTour;
            
        }

        public void LoadDanhSachGia()
        {
            tab_gia.Controls.Clear();
            tab_gia.Controls.Add(new DanhSachGia(baseTour, danhSachGia, danhSachGiaListener));
        }

        public void LoadDanhSachDiaDiem()
        {

            //chiTietUserControl = new DanhSachDiaDiem(tatCaDiaDiem,diaDiemCuaTour,this);
            tab_diadiem.Controls.Clear();
            tab_diadiem.Controls.Add(new DanhSachChonDiaDiem(baseTour, danhSachTatCaDiaDiem, danhSachDiaDiemCuaTor, danhSachChonDiaDiemListener));
        }
        private void LoadThongKeTheoTour()
        {
            tab_thongke.Controls.Clear();
            tab_thongke.Controls.Add(new ThongKeTheoTour(baseTour));
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            editTour.LoaiTour = danhSachLoai.ToArray()[combobox_loai.SelectedIndex];
        }
        private void TabControl1_Selected(Object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Name=="tab_gia") {
                LoadDanhSachGia();
            }
            else if(e.TabPage.Name=="tab_diadiem")
            {
                LoadDanhSachDiaDiem();
            }else
            {
                LoadThongKeTheoTour();
            }
        }

       

        public interface OnChiTietTourListener
        {
            void onChiTietTourCapNhatClick(Tour tourisAfterUpdate);
            void onChiTietTourXoaTourClick(Tour currentTouris);
        }

        
     

        private void btn_chinhsua_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {

                if (Validation(editTour))
                {
                    baseTour.Map(editTour);
                    onChiTietClickListener.onChiTietTourCapNhatClick(baseTour);
                }
                else
                {
                    MessageBox.Show("Tên hoặc loại tour không được bỏ trống");
                    return;
                }
            }
            isEditing = !isEditing;
            UpdateComponentState();
        }


        private void textbox_name_TextChanged(object sender, EventArgs e)
        {
            editTour.TenTour = textbox_name.Text.Trim();
        }

        private bool Validation(Tour tourisAfterUpdate)
        {
            if (tourisAfterUpdate.TenTour == null ||tourisAfterUpdate.TenTour == "" || tourisAfterUpdate.LoaiTour.MaLoai == 0)
                return false;
            return true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            baseTour.Map(editTour);
            onChiTietClickListener.onChiTietTourXoaTourClick(baseTour);
        }

        private void tab_gia_Click(object sender, EventArgs e)
        {

        }
    }
}

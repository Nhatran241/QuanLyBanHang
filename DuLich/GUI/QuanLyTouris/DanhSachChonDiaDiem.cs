using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DuLich.BUS;

namespace DuLich.GUI.QuanLyTouris
{
    public partial class DanhSachChonDiaDiem : UserControl
    {
        private List<DiaDiem> danhSachTatCaDiaDiem = new List<DiaDiem>();
        private List<DiaDiem> danhSachDiaDiemTrongDoan = new List<DiaDiem>();
        private List<DiaDiem> danhSachDiaDiemTrongDoanTam = new List<DiaDiem>();
        private IDanhSachChonDiaDiemListener danhSachChonDiaDiemListener;
        private Tour tourHienTai;
        public DanhSachChonDiaDiem(Tour tourHienTai,List<DiaDiem> danhSachTatCaDiaDiem , List<DiaDiem> danhSachDiaDiemTrongDoan, IDanhSachChonDiaDiemListener danhSachChonDiaDiemListener)
        {
            InitializeComponent();
            UpdateComponentState();
            this.danhSachTatCaDiaDiem.AddRange(danhSachTatCaDiaDiem);
            this.danhSachDiaDiemTrongDoan.AddRange(danhSachDiaDiemTrongDoan);
            this.danhSachDiaDiemTrongDoanTam.AddRange(danhSachDiaDiemTrongDoan);
            this.danhSachChonDiaDiemListener = danhSachChonDiaDiemListener;
            this.tourHienTai = tourHienTai;
            initData();
        }

        public void UpdateComponentState()
        {
            btn_luu.Visible = false;
        }
         

        private void initData()
        {
            listbox_tatcakhach.DataSource = danhSachDiaDiemTrongDoan;
            listbox_tatcadiadiem.DataSource = danhSachTatCaDiaDiem;
            if (danhSachTatCaDiaDiem != null && danhSachDiaDiemTrongDoan != null)
            {
                danhSachTatCaDiaDiem.RemoveAll(c=> danhSachDiaDiemTrongDoan.Contains(c));
            }
            listbox_tatcakhach.DataSource = null;
            listbox_tatcakhach.DataSource = danhSachDiaDiemTrongDoan;

            listbox_tatcadiadiem.DataSource = null;
            listbox_tatcadiadiem.DataSource = danhSachTatCaDiaDiem;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (listbox_tatcadiadiem.SelectedItem == null)
                return;
            danhSachDiaDiemTrongDoan.Add((DiaDiem)listbox_tatcadiadiem.SelectedItem);
            danhSachTatCaDiaDiem.Remove((DiaDiem)listbox_tatcadiadiem.SelectedItem);

            listbox_tatcakhach.DataSource = null;
            listbox_tatcakhach.DataSource = danhSachDiaDiemTrongDoan;
            listbox_tatcakhach.SelectedIndex = listbox_tatcakhach.Items.Count - 1;

            listbox_tatcadiadiem.DataSource = null;
            listbox_tatcadiadiem.DataSource = danhSachTatCaDiaDiem;
            listbox_tatcadiadiem.SelectedIndex = listbox_tatcadiadiem.Items.Count - 1;
            checkSuThayDoi();
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if (listbox_tatcakhach.SelectedItem == null)
                return;
            int position = listbox_tatcakhach.SelectedIndex;
            if (position != 0) {
                DiaDiem temp = (DiaDiem)listbox_tatcakhach.SelectedItem;
                danhSachDiaDiemTrongDoan.RemoveAt(position);
                danhSachDiaDiemTrongDoan.Insert(position - 1, temp);
                listbox_tatcakhach.SelectedIndex = position - 1;

                listbox_tatcakhach.DataSource = null;
                listbox_tatcakhach.DataSource = danhSachDiaDiemTrongDoan;

                listbox_tatcadiadiem.DataSource = null;
                listbox_tatcadiadiem.DataSource = danhSachTatCaDiaDiem;
                checkSuThayDoi();
            }
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            if (listbox_tatcakhach.SelectedItem == null)
                return;
            int position = listbox_tatcakhach.SelectedIndex;
            if (position != danhSachDiaDiemTrongDoan.Count-1)
            {
                DiaDiem temp = (DiaDiem)listbox_tatcakhach.SelectedItem;
                danhSachDiaDiemTrongDoan.RemoveAt(position);
                danhSachDiaDiemTrongDoan.Insert(position + 1, temp);
                listbox_tatcakhach.SelectedIndex = position + 1;

                listbox_tatcakhach.DataSource = null;
                listbox_tatcakhach.DataSource = danhSachDiaDiemTrongDoan;

                listbox_tatcadiadiem.DataSource = null;
                listbox_tatcadiadiem.DataSource = danhSachTatCaDiaDiem;
                checkSuThayDoi();
            }
        }

        private void checkSuThayDoi()
        {
            if (danhSachDiaDiemTrongDoan.Count == danhSachDiaDiemTrongDoanTam.Count)
            {
                for(int i = 0; i < danhSachDiaDiemTrongDoan.Count; i++)
                {
                    for(int j = 0; j < danhSachDiaDiemTrongDoanTam.Count; i++)
                    {
                        if (danhSachDiaDiemTrongDoan[i] != danhSachDiaDiemTrongDoanTam[j])
                        {
                            ShowLuuButton();
                            return;
                        }
                    }
                }
                HideLuuButton();
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
            if (listbox_tatcakhach.SelectedItem == null)
                return;

            danhSachTatCaDiaDiem.Add((DiaDiem)listbox_tatcakhach.SelectedItem);
            danhSachDiaDiemTrongDoan.Remove((DiaDiem)listbox_tatcakhach.SelectedItem);

            listbox_tatcakhach.DataSource = null;
            listbox_tatcakhach.DataSource = danhSachDiaDiemTrongDoan;
            listbox_tatcakhach.SelectedIndex = listbox_tatcakhach.Items.Count - 1;

            listbox_tatcadiadiem.DataSource = null;
            listbox_tatcadiadiem.DataSource = danhSachTatCaDiaDiem;
            listbox_tatcadiadiem.SelectedIndex = listbox_tatcadiadiem.Items.Count - 1;
            checkSuThayDoi();
        }

        public interface IDanhSachChonDiaDiemListener
        {
            void onDanhSachChonDiaDiem_LuuClick(Tour tourHienTai,List<DiaDiem> danhSachDiaDiemTrongDoanUpdate);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            danhSachChonDiaDiemListener.onDanhSachChonDiaDiem_LuuClick(tourHienTai, danhSachDiaDiemTrongDoan);
        }

        internal void ShowLuuButton()
        {
            btn_luu.Visible = true;
        }

        internal void HideLuuButton()
        {
            btn_luu.Visible = false;
        }

    }
}

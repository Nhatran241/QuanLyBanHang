using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DuLich.BUS;

namespace DuLich.GUI.QuanLyPhanCong
{
    public partial class DanhSachPhanCong : UserControl
    {
        private IDanhSachPhanCongListener danhSachPhanCongListener;
        private List<PhanCong> PhanCongs = new List<PhanCong>();
        private Doan doanHienTai;
        public DanhSachPhanCong(Doan doanHienTai,List<PhanCong> phanCongs, IDanhSachPhanCongListener danhSachPhanCongListener)
        {
            InitializeComponent();
            this.danhSachPhanCongListener = danhSachPhanCongListener;
            this.PhanCongs.AddRange(phanCongs);
            this.doanHienTai = doanHienTai;
            InitData(phanCongs);
        }
        private void InitData(List<PhanCong> phanCongs)
        {
            foreach (PhanCong phanCong in phanCongs)
            {
                listview_phancong.Items.Add(new ListViewItem(new string[] {phanCong.MaPhanCong+"", phanCong.NhanVien.TenNhanVien,phanCong.NhiemVu}));
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = listview_phancong.SelectedIndices.Count;
            if (position > 0)
            {
                btn_sua_phancong.Visible = true;
                btn_xoa_phancong.Visible = true;
            }else
            {
                btn_sua_phancong.Visible = false;
                btn_xoa_phancong.Visible = false;
            }

        }


        private void btn_them_phancong_Click(object sender, EventArgs e)
        {
            danhSachPhanCongListener.onDanhSachPhanCongThemClick(doanHienTai);
        }
     

        private void btn_sua_phancong_Click(object sender, EventArgs e)
        {

            int position = listview_phancong.SelectedItems[0].Index;
            danhSachPhanCongListener.onDanhSachPhanCongSuaClick(PhanCongs.ToArray()[position]);
        }

        private void btn_xoa_phancong_Click(object sender, EventArgs e)
        {
            if (listview_phancong.SelectedItems.Count > 0)
            {
                int position = listview_phancong.SelectedItems[0].Index;
                danhSachPhanCongListener.onDanhSachPhanCongXoaClick(doanHienTai,PhanCongs.ToArray()[position]);
            }
        }
        public interface IDanhSachPhanCongListener
        {
            void onDanhSachPhanCongThemClick(Doan doanHienTai);
            void onDanhSachPhanCongSuaClick(PhanCong phanCong);
            void onDanhSachPhanCongXoaClick(Doan doanHienTai, PhanCong phanCong);
        }
    }
}

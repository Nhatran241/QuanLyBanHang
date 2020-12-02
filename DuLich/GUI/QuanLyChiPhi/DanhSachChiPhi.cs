using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuLich.BUS;

namespace DuLich.GUI.QuanLyChiPhi
{
    public partial class DanhSachChiPhi : UserControl
    {
        private IDanhSachChiPhiListener danhSachChiPhiListener;
        private List<ChiPhi> danhSachChiPhi;
        private Doan doanHienTai;
        public DanhSachChiPhi(Doan doanHienTai,List<ChiPhi> danhSachChiPhi, IDanhSachChiPhiListener danhSachChiPhiListener)
        {
            InitializeComponent();
            this.doanHienTai = doanHienTai;
            this.danhSachChiPhi = danhSachChiPhi;
            this.danhSachChiPhiListener = danhSachChiPhiListener;
            InitData(danhSachChiPhi);
        }

        private void InitData(List<ChiPhi> danhSachChiPhi)
        {
            dataGridView1.DataSource = danhSachChiPhi;
        }

        private void listview_doan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = dataGridView1.CurrentCell.RowIndex;
            if (position > 0)
            {
                btn_sua_doan.Visible = true;
                btn_xoa_doan.Visible = true;
            }
            else
            {
                btn_sua_doan.Visible = false;
                btn_xoa_doan.Visible = false;
            }
        }
        public interface IDanhSachChiPhiListener
        {
            void onDanhSachChiPhi_ThemClick(Doan doanHienTai);
            void onDanhSachChiPhi_SuaClick(ChiPhi chiPhi);
            void onDanhSachChiPhi_XoaClick(Doan doanHienTai,ChiPhi chiPhi);
        }

        private void btn_them_doan_Click(object sender, EventArgs e)
        {
            danhSachChiPhiListener.onDanhSachChiPhi_ThemClick(doanHienTai);
        }

        private void btn_xoa_doan_Click(object sender, EventArgs e)
        {
            int position = dataGridView1.CurrentCell.RowIndex;
            danhSachChiPhiListener.onDanhSachChiPhi_XoaClick(doanHienTai,danhSachChiPhi.ToArray()[position]);
            
        }

        private void btn_sua_doan_Click(object sender, EventArgs e)
        {
            int position = dataGridView1.CurrentCell.RowIndex;
            danhSachChiPhiListener.onDanhSachChiPhi_SuaClick(danhSachChiPhi.ToArray()[position]);
        }
    }
}
